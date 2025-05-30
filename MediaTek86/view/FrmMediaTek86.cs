using MediaTek86.controller;
using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre d'affichage des personnels et du service auquel ils appartiennent
    /// </summary>
    public partial class FrmMediaTek86 : Form
    {
        /// <summary>
        /// Booléan pour savoir si une modification d'un personnel est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;

        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private BindingSource bdgPersonnels = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private BindingSource bdgServices = new BindingSource();

        ///<summary>
        ///Boolean pour savoir si une modification d'une absence est demandée
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;

        ///<summary>
        ///Objet pour gérer la liste des absences
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();

        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmMediaTek86Controller controller;

        /// <summary>
        /// Stocke l'ancienne absence sélectionnée avant modification,
        /// afin de pouvoir l'identifier lors de la mise à jour dans la base de données
        /// </summary>
        private Absence ancienneAbsence = null;

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmMediaTek86()
        {
            InitializeComponent();
            Init();

            // Abonnement à l'événement de sélection d'un personnel
            dgvPersonnels.SelectionChanged += dgvPersonnels_SelectionChanged;
        }

       
        /// <summary>
        /// Initialisations : Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmMediaTek86Controller();
            RemplirListePersonnels();
            RemplirListeServices();
            EnCoursDeModifPersonnel(false);
        }


        /// <summary>
        /// Affiche les personnels
        /// </summary>
        private void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dgvPersonnels.DataSource = bdgPersonnels;
            dgvPersonnels.Columns["idpersonnel"].Visible = false;
            dgvPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListeServices()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            cboService.DataSource = bdgServices;
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDemandeModifPers_Click_1(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                grbPersonnel.Enabled = true;
                EnCoursDeModifPersonnel(true);
                Personnel personnel = (Personnel)dgvPersonnels.SelectedRows[0].DataBoundItem;
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemandeSupprPers_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)dgvPersonnels.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemandeAjoutPers_Click_1(object sender, EventArgs e)
        {
            grbPersonnel.Enabled = true;
        }


        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregPers_Click_1(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                string nom = txtNom.Text;
                string prenom = txtPrenom.Text;
                string tel = txtTel.Text;
                string mail = txtMail.Text;
                Service service = (Service)bdgServices.List[bdgServices.Position];

                // Déterminer le personnel à exclure en cas de modification
                Personnel personnelExclu = enCoursDeModifPersonnel ? (Personnel)dgvPersonnels.SelectedRows[0].DataBoundItem : null;

                // Vérifie s'il existe déjà un personnel avec le même nom, prénom et service (sans tenir compte de celui qu'on modifie)
                if (PersonnelDejaExistant(nom, prenom, service, personnelExclu))
                {
                    MessageBox.Show("Un personnel avec ce nom, prénom et service existe déjà.", "Doublon détecté");
                    return;
                }


                if (enCoursDeModifPersonnel)
                {
                    // Confirmation d'enregistrement
                    DialogResult result = MessageBox.Show("Voulez-vous enregistrer ces modifications ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result != DialogResult.Yes)
                    {
                        return; // L'utilisateur a cliqué sur Non et on annule l'enregistrement
                    }

                    Personnel personnel = (Personnel)dgvPersonnels.SelectedRows[0].DataBoundItem;
                    personnel.Nom = nom;
                    personnel.Prenom = prenom;
                    personnel.Tel = tel;
                    personnel.Mail = mail;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnels();
                EnCoursDeModifPersonnel(false);
                grbPersonnel.Enabled = false;
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Information");
            }
            
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'un personnel
        /// </summary>
        /// Vide les zones de saisie du personnel
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulPers_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModifPersonnel(false);
                grbPersonnel.Enabled = false;
            }

        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un personnel
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            grbLesPersonnels.Enabled = !modif;
            if (modif)
            {
                grbPersonnel.Text = "Modifier un personnel";
            }
            else
            {
                grbPersonnel.Text = "Ajouter un personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }


        /// <summary>
        /// Vérifie si un personnel avec le même nom, prénom et service existe déjà (sans tenir compte du personnel sélectionné si modification)
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="service"></param>
        /// <param name="personnelModifie"></param>
        /// <returns></returns>
        private bool PersonnelDejaExistant(string nom, string prenom, Service service, Personnel personnelModifie = null)
        {
            List<Personnel> personnels = controller.GetLesPersonnels();

            foreach (Personnel p in personnels)
            {
                // Ne pas comparer avec lui-même en cas de modification
                if (personnelModifie != null && p.Idpersonnel == personnelModifie.Idpersonnel)
                    continue;

                if (p.Nom.Equals(nom, StringComparison.InvariantCultureIgnoreCase) &&
                    p.Prenom.Equals(prenom, StringComparison.InvariantCultureIgnoreCase) &&
                    p.Service.Idservice == service.Idservice)
                {
                    return true;
                }
            }
            return false;
        }



        /// <summary>
        /// Demande de gérer les absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemandeAbsences_Click(object sender, EventArgs e)
        {
            
            grbLesAbsences.Enabled = true;
            RemplirListeAbsences();
            dgvAbsences.Enabled = true;
            EnCoursDeModifAbsence(false);
        }

        /// <summary>
        /// Afficher les absences
        /// </summary>
        private void RemplirListeAbsences()
        {
            if (dgvPersonnels.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un personnel d'abord.", "Information");
                return;
            }
            Personnel personnel = (Personnel)dgvPersonnels.SelectedRows[0].DataBoundItem;
            List<Absence> lesAbsences = controller.GetLesAbsences(personnel.Nom, personnel.Prenom);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAbsences.Columns["Idpersonnel"].Visible = false;
        }

        /// <summary>
        /// Afficher les motifs
        /// </summary>
        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            cboMotif.DataSource = null;
            cboMotif.DataSource = lesMotifs;
        }

        /// <summary>
        /// Demande de modifier une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemandeModifAbs_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                RemplirListeMotifs();
                grbAbsence.Enabled = true;
                EnCoursDeModifAbsence(true);
                ancienneAbsence = (Absence)dgvAbsences.SelectedRows[0].DataBoundItem;

                //Remplissage des champs du formulaire avec les valeurs existantes 
                dtpDateDebut.Value = ancienneAbsence.Datedebut;
                dtpDateFin.Value = ancienneAbsence.Datefin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(ancienneAbsence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande de supprimer une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemandeSupprAbs_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)dgvAbsences.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence du " + dtpDateDebut.Value + " au " + dtpDateFin.Value + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande d'ajouter une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemandeAjoutAbs_Click(object sender, EventArgs e)
        {
            RemplirListeMotifs();
            grbAbsence.Enabled = true;
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregAbs_Click(object sender, EventArgs e)
        {
            if (dtpDateDebut.Value <= dtpDateFin.Value)
            {
                if (cboMotif.SelectedIndex != -1 && cboMotif.SelectedItem != null)
                {
                    Motif motif = (Motif)cboMotif.SelectedItem;
                    Personnel personnel = (Personnel)dgvPersonnels.SelectedRows[0].DataBoundItem;
                    Absence nouvelleAbsence = new Absence(personnel.Idpersonnel, dtpDateDebut.Value, dtpDateFin.Value, motif);

                    // Vérifie conflit
                    if (AbsenceDejaExistante(personnel, dtpDateDebut.Value, dtpDateFin.Value))
                    {
                        MessageBox.Show("Une absence existe déjà pendant cette période.", "Information");
                        return;
                    }


                    if (enCoursDeModifAbsence && ancienneAbsence != null)
                    {
                        // Confirmation d'enregistrement
                        DialogResult result = MessageBox.Show("Voulez-vous enregistrer ces modifications ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result != DialogResult.Yes)
                        {
                            return; // L'utilisateur a cliqué sur Non et on annule l'enregistrement
                        }

                        controller.UpdateAbsence(ancienneAbsence, nouvelleAbsence);
                    }
                    else
                    {
                        controller.AddAbsence(nouvelleAbsence);
                    }
                    RemplirListeAbsences();
                    EnCoursDeModifAbsence(false);
                    ancienneAbsence = null;
                }
                else
                {
                    MessageBox.Show("Tous les champs doivent être remplis", "Information");
                }
                grbAbsence.Enabled = false;
            }
            else
            {
                MessageBox.Show("La date de fin doit être postérieure à la date de début", "Information");
            }
        }
            


        /// <summary>
        /// Annule la demande d'ajout ou de modification d'une absence
        /// Vide les zones de saisie de l'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulAbs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModifAbsence(false);
                grbAbsence.Enabled = false;
            }
                                  
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'une absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            grbLesAbsences.Enabled = !modif;
            if (modif)
            {
                grbAbsence.Text = "Modifier une absence";
            }
            else
            {
                grbAbsence.Text = "Ajouter une absence";
                dtpDateDebut.Value = DateTime.Now;
                dtpDateFin.Value = DateTime.Now;
            }
        }

        /// <summary>
        /// Quand on change de personnel sélectionné, on désactive les absences
        /// </summary>
        private void dgvPersonnels_SelectionChanged(object sender, EventArgs e)
        {
            // Désactive la zone des absences
            grbLesAbsences.Enabled = false;

            // Efface les absences affichées précédemment
            dgvAbsences.DataSource = null;
            

            // Désactiver le formulaire d'ajout/modif d'absence
            grbAbsence.Enabled = false;
        }

        /// <summary>
        /// Vérifie s'il existe une absence qui chevauche la période saisie
        /// </summary>
        private bool AbsenceDejaExistante(Personnel personnel, DateTime dateDebut, DateTime dateFin)
        {
            List<Absence> absencesExistantes = controller.GetLesAbsences(personnel.Nom, personnel.Prenom);

            foreach (Absence abs in absencesExistantes)
            {
                // Ignorer l'absence qu'on modifie pour le test de chevauchement
                if (enCoursDeModifAbsence && ancienneAbsence != null && abs.Idpersonnel == ancienneAbsence.Idpersonnel && abs.Datedebut == ancienneAbsence.Datedebut && abs.Datefin == ancienneAbsence.Datefin && abs.Motif.Idmotif == ancienneAbsence.Motif.Idmotif)
                {
                    continue;
                }

                // Vérifie le chevauchement
                if (dateDebut <= abs.Datefin && dateFin >= abs.Datedebut)
                {
                    return true;
                }
            }
            return false;
        }

        private void dgvPersonnels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
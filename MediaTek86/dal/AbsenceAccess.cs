using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les absences
    /// </summary>
    public class AbsenceAccess
    {
        ///<summary>
        ///Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        ///<summary>
        ///Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les absences du personnel sélectionné du plus récent au plus ancien
        /// </summary>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences(string nomPersonnel = "", string prenomPersonnel = "")
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "select a.idpersonnel as idpersonnel, a.datedebut as datedebut, a.datefin as datefin, m.idmotif as idmotif, m.libelle as libelle ";
                req += "from absence a join motif m on (a.idmotif = m.idmotif) join personnel p on (a.idpersonnel = p.idpersonnel) ";
                req += $"where p.nom = '{nomPersonnel}' and p.prenom = '{prenomPersonnel}' ";
                req += "order by a.datedebut DESC;";


                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Motif motif = new Motif((int)record[3], (string)record[4]);
                            Absence absence = new Absence((int)record[0], (DateTime)record[1], (DateTime)record[2], motif);
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }

        ///<summary>
        ///Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "delete from absence where idpersonnel = @idpersonnel AND datedebut = @datedebut AND datefin = @datefin AND idmotif = @idmotif;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Idpersonnel);
                parameters.Add("@datedebut", absence.Datedebut);
                parameters.Add("@datefin", absence.Datefin);
                parameters.Add("@idmotif", absence.Motif.Idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        ///<summary>
        ///Demande d'ajout une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence (idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Idpersonnel);
                parameters.Add("@datedebut", absence.Datedebut);
                parameters.Add("@datefin", absence.Datefin);
                parameters.Add("@idmotif", absence.Motif.Idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        ///<summary>
        ///Demande de modification d'une absence (avec date de début modifiable)
        /// </summary>
        /// <param name="ancienneAbsence">objet ancienne absence</param>
        /// <param name="nouvelleAbsence">objet nouvelle absence</param>
        public void UpdateAbsence (Absence ancienneAbsence, Absence nouvelleAbsence)
        {
            if (access.Manager != null)
            {
                string req = "update absence set datedebut = @nouvelleDatedebut, datefin = @Datefin, idmotif = @idmotif ";
                req += "where idpersonnel = @idpersonnel AND datedebut = @ancienneDatedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", ancienneAbsence.Idpersonnel);
                parameters.Add("@ancienneDatedebut", ancienneAbsence.Datedebut);
                parameters.Add("@nouvelleDatedebut", nouvelleAbsence.Datedebut);
                parameters.Add("@datefin", nouvelleAbsence.Datefin); 
                parameters.Add("@idmotif", nouvelleAbsence.Motif.Idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }

        }
    }
}


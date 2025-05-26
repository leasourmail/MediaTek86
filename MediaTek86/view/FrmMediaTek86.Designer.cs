namespace MediaTek86.view
{
    partial class FrmMediaTek86
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbLesPersonnels = new System.Windows.Forms.GroupBox();
            this.btnDemandeAjoutPers = new System.Windows.Forms.Button();
            this.btnDemandeAbsences = new System.Windows.Forms.Button();
            this.btnDemandeSupprPers = new System.Windows.Forms.Button();
            this.btnDemandeModifPers = new System.Windows.Forms.Button();
            this.dgvPersonnels = new System.Windows.Forms.DataGridView();
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAnnulPers = new System.Windows.Forms.Button();
            this.btnEnregPers = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbLesAbsences = new System.Windows.Forms.GroupBox();
            this.btnDemandeAjoutAbs = new System.Windows.Forms.Button();
            this.btnDemandeSupprAbs = new System.Windows.Forms.Button();
            this.btnDemandeModifAbs = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.grbAbsence = new System.Windows.Forms.GroupBox();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.btnAnnulAbs = new System.Windows.Forms.Button();
            this.btnEnregAbs = new System.Windows.Forms.Button();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grbLesPersonnels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).BeginInit();
            this.grbPersonnel.SuspendLayout();
            this.grbLesAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.grbAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLesPersonnels
            // 
            this.grbLesPersonnels.Controls.Add(this.btnDemandeAjoutPers);
            this.grbLesPersonnels.Controls.Add(this.btnDemandeAbsences);
            this.grbLesPersonnels.Controls.Add(this.btnDemandeSupprPers);
            this.grbLesPersonnels.Controls.Add(this.btnDemandeModifPers);
            this.grbLesPersonnels.Controls.Add(this.dgvPersonnels);
            this.grbLesPersonnels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLesPersonnels.Location = new System.Drawing.Point(32, 31);
            this.grbLesPersonnels.Name = "grbLesPersonnels";
            this.grbLesPersonnels.Size = new System.Drawing.Size(1374, 639);
            this.grbLesPersonnels.TabIndex = 0;
            this.grbLesPersonnels.TabStop = false;
            this.grbLesPersonnels.Text = "Les personnels";
            // 
            // btnDemandeAjoutPers
            // 
            this.btnDemandeAjoutPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeAjoutPers.Location = new System.Drawing.Point(33, 564);
            this.btnDemandeAjoutPers.Name = "btnDemandeAjoutPers";
            this.btnDemandeAjoutPers.Size = new System.Drawing.Size(263, 53);
            this.btnDemandeAjoutPers.TabIndex = 4;
            this.btnDemandeAjoutPers.Text = "Ajouter";
            this.btnDemandeAjoutPers.UseVisualStyleBackColor = true;
            this.btnDemandeAjoutPers.Click += new System.EventHandler(this.btnDemandeAjoutPers_Click_1);
            // 
            // btnDemandeAbsences
            // 
            this.btnDemandeAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeAbsences.Location = new System.Drawing.Point(907, 564);
            this.btnDemandeAbsences.Name = "btnDemandeAbsences";
            this.btnDemandeAbsences.Size = new System.Drawing.Size(263, 53);
            this.btnDemandeAbsences.TabIndex = 3;
            this.btnDemandeAbsences.Text = "Absences";
            this.btnDemandeAbsences.UseVisualStyleBackColor = true;
            this.btnDemandeAbsences.Click += new System.EventHandler(this.btnDemandeAbsences_Click);
            // 
            // btnDemandeSupprPers
            // 
            this.btnDemandeSupprPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeSupprPers.Location = new System.Drawing.Point(608, 564);
            this.btnDemandeSupprPers.Name = "btnDemandeSupprPers";
            this.btnDemandeSupprPers.Size = new System.Drawing.Size(263, 53);
            this.btnDemandeSupprPers.TabIndex = 2;
            this.btnDemandeSupprPers.Text = "Supprimer";
            this.btnDemandeSupprPers.UseVisualStyleBackColor = true;
            this.btnDemandeSupprPers.Click += new System.EventHandler(this.btnDemandeSupprPers_Click);
            // 
            // btnDemandeModifPers
            // 
            this.btnDemandeModifPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeModifPers.Location = new System.Drawing.Point(323, 564);
            this.btnDemandeModifPers.Name = "btnDemandeModifPers";
            this.btnDemandeModifPers.Size = new System.Drawing.Size(263, 53);
            this.btnDemandeModifPers.TabIndex = 1;
            this.btnDemandeModifPers.Text = "Modifier";
            this.btnDemandeModifPers.UseVisualStyleBackColor = true;
            this.btnDemandeModifPers.Click += new System.EventHandler(this.btnDemandeModifPers_Click_1);
            // 
            // dgvPersonnels
            // 
            this.dgvPersonnels.AllowUserToAddRows = false;
            this.dgvPersonnels.AllowUserToDeleteRows = false;
            this.dgvPersonnels.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonnels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnels.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonnels.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonnels.Location = new System.Drawing.Point(33, 41);
            this.dgvPersonnels.MultiSelect = false;
            this.dgvPersonnels.Name = "dgvPersonnels";
            this.dgvPersonnels.ReadOnly = true;
            this.dgvPersonnels.RowHeadersVisible = false;
            this.dgvPersonnels.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPersonnels.RowTemplate.Height = 33;
            this.dgvPersonnels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnels.Size = new System.Drawing.Size(1309, 499);
            this.dgvPersonnels.TabIndex = 0;
            this.dgvPersonnels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonnels_CellContentClick);
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnAnnulPers);
            this.grbPersonnel.Controls.Add(this.btnEnregPers);
            this.grbPersonnel.Controls.Add(this.cboService);
            this.grbPersonnel.Controls.Add(this.txtTel);
            this.grbPersonnel.Controls.Add(this.label5);
            this.grbPersonnel.Controls.Add(this.txtMail);
            this.grbPersonnel.Controls.Add(this.label4);
            this.grbPersonnel.Controls.Add(this.label3);
            this.grbPersonnel.Controls.Add(this.txtPrenom);
            this.grbPersonnel.Controls.Add(this.txtNom);
            this.grbPersonnel.Controls.Add(this.label2);
            this.grbPersonnel.Controls.Add(this.label1);
            this.grbPersonnel.Enabled = false;
            this.grbPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPersonnel.Location = new System.Drawing.Point(32, 691);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(1374, 345);
            this.grbPersonnel.TabIndex = 1;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "Ajouter un personnel";
            // 
            // btnAnnulPers
            // 
            this.btnAnnulPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulPers.Location = new System.Drawing.Point(323, 264);
            this.btnAnnulPers.Name = "btnAnnulPers";
            this.btnAnnulPers.Size = new System.Drawing.Size(263, 53);
            this.btnAnnulPers.TabIndex = 11;
            this.btnAnnulPers.Text = "Annuler";
            this.btnAnnulPers.UseVisualStyleBackColor = true;
            this.btnAnnulPers.Click += new System.EventHandler(this.btnAnnulPers_Click_1);
            // 
            // btnEnregPers
            // 
            this.btnEnregPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregPers.Location = new System.Drawing.Point(33, 264);
            this.btnEnregPers.Name = "btnEnregPers";
            this.btnEnregPers.Size = new System.Drawing.Size(263, 53);
            this.btnEnregPers.TabIndex = 10;
            this.btnEnregPers.Text = "Enregistrer";
            this.btnEnregPers.UseVisualStyleBackColor = true;
            this.btnEnregPers.Click += new System.EventHandler(this.btnEnregPers_Click_1);
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(785, 191);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(400, 37);
            this.cboService.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(785, 131);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(400, 35);
            this.txtTel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Service";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(785, 68);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(518, 35);
            this.txtMail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(132, 131);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(518, 35);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(132, 68);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(518, 35);
            this.txtNom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // grbLesAbsences
            // 
            this.grbLesAbsences.Controls.Add(this.btnDemandeAjoutAbs);
            this.grbLesAbsences.Controls.Add(this.btnDemandeSupprAbs);
            this.grbLesAbsences.Controls.Add(this.btnDemandeModifAbs);
            this.grbLesAbsences.Controls.Add(this.dgvAbsences);
            this.grbLesAbsences.Enabled = false;
            this.grbLesAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLesAbsences.Location = new System.Drawing.Point(1446, 57);
            this.grbLesAbsences.Name = "grbLesAbsences";
            this.grbLesAbsences.Size = new System.Drawing.Size(755, 582);
            this.grbLesAbsences.TabIndex = 2;
            this.grbLesAbsences.TabStop = false;
            this.grbLesAbsences.Text = "Les absences";
            // 
            // btnDemandeAjoutAbs
            // 
            this.btnDemandeAjoutAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeAjoutAbs.Location = new System.Drawing.Point(33, 431);
            this.btnDemandeAjoutAbs.Name = "btnDemandeAjoutAbs";
            this.btnDemandeAjoutAbs.Size = new System.Drawing.Size(263, 53);
            this.btnDemandeAjoutAbs.TabIndex = 5;
            this.btnDemandeAjoutAbs.Text = "Ajouter";
            this.btnDemandeAjoutAbs.UseVisualStyleBackColor = true;
            this.btnDemandeAjoutAbs.Click += new System.EventHandler(this.btnDemandeAjoutAbs_Click);
            // 
            // btnDemandeSupprAbs
            // 
            this.btnDemandeSupprAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeSupprAbs.Location = new System.Drawing.Point(33, 502);
            this.btnDemandeSupprAbs.Name = "btnDemandeSupprAbs";
            this.btnDemandeSupprAbs.Size = new System.Drawing.Size(263, 53);
            this.btnDemandeSupprAbs.TabIndex = 2;
            this.btnDemandeSupprAbs.Text = "Supprimer";
            this.btnDemandeSupprAbs.UseVisualStyleBackColor = true;
            this.btnDemandeSupprAbs.Click += new System.EventHandler(this.btnDemandeSupprAbs_Click);
            // 
            // btnDemandeModifAbs
            // 
            this.btnDemandeModifAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeModifAbs.Location = new System.Drawing.Point(323, 431);
            this.btnDemandeModifAbs.Name = "btnDemandeModifAbs";
            this.btnDemandeModifAbs.Size = new System.Drawing.Size(263, 53);
            this.btnDemandeModifAbs.TabIndex = 1;
            this.btnDemandeModifAbs.Text = "Modifier";
            this.btnDemandeModifAbs.UseVisualStyleBackColor = true;
            this.btnDemandeModifAbs.Click += new System.EventHandler(this.btnDemandeModifAbs_Click);
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.AllowUserToAddRows = false;
            this.dgvAbsences.AllowUserToDeleteRows = false;
            this.dgvAbsences.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbsences.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAbsences.Location = new System.Drawing.Point(33, 47);
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.RowHeadersVisible = false;
            this.dgvAbsences.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAbsences.RowTemplate.Height = 33;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(693, 366);
            this.dgvAbsences.TabIndex = 0;
            // 
            // grbAbsence
            // 
            this.grbAbsence.Controls.Add(this.dtpDateFin);
            this.grbAbsence.Controls.Add(this.dtpDateDebut);
            this.grbAbsence.Controls.Add(this.btnAnnulAbs);
            this.grbAbsence.Controls.Add(this.btnEnregAbs);
            this.grbAbsence.Controls.Add(this.cboMotif);
            this.grbAbsence.Controls.Add(this.label6);
            this.grbAbsence.Controls.Add(this.label9);
            this.grbAbsence.Controls.Add(this.label10);
            this.grbAbsence.Enabled = false;
            this.grbAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAbsence.Location = new System.Drawing.Point(1446, 691);
            this.grbAbsence.Name = "grbAbsence";
            this.grbAbsence.Size = new System.Drawing.Size(755, 345);
            this.grbAbsence.TabIndex = 3;
            this.grbAbsence.TabStop = false;
            this.grbAbsence.Text = "Ajouter une absence";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFin.Location = new System.Drawing.Point(182, 134);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(304, 35);
            this.dtpDateFin.TabIndex = 13;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpDateDebut.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateDebut.Location = new System.Drawing.Point(182, 63);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(304, 35);
            this.dtpDateDebut.TabIndex = 12;
            this.dtpDateDebut.Value = new System.DateTime(2025, 5, 20, 17, 39, 0, 0);
            // 
            // btnAnnulAbs
            // 
            this.btnAnnulAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulAbs.Location = new System.Drawing.Point(323, 264);
            this.btnAnnulAbs.Name = "btnAnnulAbs";
            this.btnAnnulAbs.Size = new System.Drawing.Size(263, 53);
            this.btnAnnulAbs.TabIndex = 11;
            this.btnAnnulAbs.Text = "Annuler";
            this.btnAnnulAbs.UseVisualStyleBackColor = true;
            this.btnAnnulAbs.Click += new System.EventHandler(this.btnAnnulAbs_Click);
            // 
            // btnEnregAbs
            // 
            this.btnEnregAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregAbs.Location = new System.Drawing.Point(33, 264);
            this.btnEnregAbs.Name = "btnEnregAbs";
            this.btnEnregAbs.Size = new System.Drawing.Size(263, 53);
            this.btnEnregAbs.TabIndex = 10;
            this.btnEnregAbs.Text = "Enregistrer";
            this.btnEnregAbs.UseVisualStyleBackColor = true;
            this.btnEnregAbs.Click += new System.EventHandler(this.btnEnregAbs_Click);
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(182, 194);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(496, 37);
            this.cboMotif.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Motif";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Date fin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Date début";
            // 
            // FrmMediaTek86
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2470, 1304);
            this.Controls.Add(this.grbAbsence);
            this.Controls.Add(this.grbLesAbsences);
            this.Controls.Add(this.grbPersonnel);
            this.Controls.Add(this.grbLesPersonnels);
            this.Name = "FrmMediaTek86";
            this.Text = "FrmMediaTek86";
            this.grbLesPersonnels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).EndInit();
            this.grbPersonnel.ResumeLayout(false);
            this.grbPersonnel.PerformLayout();
            this.grbLesAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.grbAbsence.ResumeLayout(false);
            this.grbAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLesPersonnels;
        private System.Windows.Forms.DataGridView dgvPersonnels;
        private System.Windows.Forms.Button btnDemandeModifPers;
        private System.Windows.Forms.Button btnDemandeAbsences;
        private System.Windows.Forms.Button btnDemandeSupprPers;
        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnulPers;
        private System.Windows.Forms.Button btnEnregPers;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.GroupBox grbLesAbsences;
        private System.Windows.Forms.Button btnDemandeSupprAbs;
        private System.Windows.Forms.Button btnDemandeModifAbs;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.GroupBox grbAbsence;
        private System.Windows.Forms.Button btnAnnulAbs;
        private System.Windows.Forms.Button btnEnregAbs;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Button btnDemandeAjoutPers;
        private System.Windows.Forms.Button btnDemandeAjoutAbs;
    }
}


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
            this.grbLesPersonnels = new System.Windows.Forms.GroupBox();
            this.dgvPersonnels = new System.Windows.Forms.DataGridView();
            this.btnDemandeModifPers = new System.Windows.Forms.Button();
            this.btnDemandeSupprPers = new System.Windows.Forms.Button();
            this.btnDemandeAbsences = new System.Windows.Forms.Button();
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.btnEnregPers = new System.Windows.Forms.Button();
            this.btnAnnulPers = new System.Windows.Forms.Button();
            this.grbLesAbsences = new System.Windows.Forms.GroupBox();
            this.btnDemandeSupprAbs = new System.Windows.Forms.Button();
            this.btnDemandeModifAbs = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.grbAbsence = new System.Windows.Forms.GroupBox();
            this.btnAnnulAbs = new System.Windows.Forms.Button();
            this.btnEnregAbs = new System.Windows.Forms.Button();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
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
            this.grbLesPersonnels.Controls.Add(this.btnDemandeAbsences);
            this.grbLesPersonnels.Controls.Add(this.btnDemandeSupprPers);
            this.grbLesPersonnels.Controls.Add(this.btnDemandeModifPers);
            this.grbLesPersonnels.Controls.Add(this.dgvPersonnels);
            this.grbLesPersonnels.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLesPersonnels.Location = new System.Drawing.Point(32, 31);
            this.grbLesPersonnels.Name = "grbLesPersonnels";
            this.grbLesPersonnels.Size = new System.Drawing.Size(1408, 689);
            this.grbLesPersonnels.TabIndex = 0;
            this.grbLesPersonnels.TabStop = false;
            this.grbLesPersonnels.Text = "Les personnels";
            this.grbLesPersonnels.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvPersonnels
            // 
            this.dgvPersonnels.AllowUserToAddRows = false;
            this.dgvPersonnels.AllowUserToDeleteRows = false;
            this.dgvPersonnels.AllowUserToResizeRows = false;
            this.dgvPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnels.Location = new System.Drawing.Point(33, 41);
            this.dgvPersonnels.Name = "dgvPersonnels";
            this.dgvPersonnels.RowHeadersWidth = 82;
            this.dgvPersonnels.RowTemplate.Height = 33;
            this.dgvPersonnels.Size = new System.Drawing.Size(1340, 545);
            this.dgvPersonnels.TabIndex = 0;
            // 
            // btnDemandeModifPers
            // 
            this.btnDemandeModifPers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeModifPers.Location = new System.Drawing.Point(33, 609);
            this.btnDemandeModifPers.Name = "btnDemandeModifPers";
            this.btnDemandeModifPers.Size = new System.Drawing.Size(263, 53);
            this.btnDemandeModifPers.TabIndex = 1;
            this.btnDemandeModifPers.Text = "Modifier";
            this.btnDemandeModifPers.UseVisualStyleBackColor = true;
            // 
            // btnDemandeSupprPers
            // 
            this.btnDemandeSupprPers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeSupprPers.Location = new System.Drawing.Point(323, 609);
            this.btnDemandeSupprPers.Name = "btnDemandeSupprPers";
            this.btnDemandeSupprPers.Size = new System.Drawing.Size(263, 53);
            this.btnDemandeSupprPers.TabIndex = 2;
            this.btnDemandeSupprPers.Text = "Supprimer";
            this.btnDemandeSupprPers.UseVisualStyleBackColor = true;
            // 
            // btnDemandeAbsences
            // 
            this.btnDemandeAbsences.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeAbsences.Location = new System.Drawing.Point(618, 609);
            this.btnDemandeAbsences.Name = "btnDemandeAbsences";
            this.btnDemandeAbsences.Size = new System.Drawing.Size(263, 53);
            this.btnDemandeAbsences.TabIndex = 3;
            this.btnDemandeAbsences.Text = "Absences";
            this.btnDemandeAbsences.UseVisualStyleBackColor = true;
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnAnnulPers);
            this.grbPersonnel.Controls.Add(this.btnEnregPers);
            this.grbPersonnel.Controls.Add(this.cboService);
            this.grbPersonnel.Controls.Add(this.textBox2);
            this.grbPersonnel.Controls.Add(this.label5);
            this.grbPersonnel.Controls.Add(this.textBox1);
            this.grbPersonnel.Controls.Add(this.label4);
            this.grbPersonnel.Controls.Add(this.label3);
            this.grbPersonnel.Controls.Add(this.txtPrenom);
            this.grbPersonnel.Controls.Add(this.txtNom);
            this.grbPersonnel.Controls.Add(this.label2);
            this.grbPersonnel.Controls.Add(this.label1);
            this.grbPersonnel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPersonnel.Location = new System.Drawing.Point(32, 753);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(1408, 345);
            this.grbPersonnel.TabIndex = 1;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "Ajouter un personnel";
            this.grbPersonnel.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(150, 68);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(518, 39);
            this.txtNom.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(150, 131);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(518, 39);
            this.txtPrenom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(734, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(855, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(518, 39);
            this.textBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(734, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Service";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(855, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 39);
            this.textBox2.TabIndex = 8;
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(855, 199);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(400, 40);
            this.cboService.TabIndex = 9;
            // 
            // btnEnregPers
            // 
            this.btnEnregPers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregPers.Location = new System.Drawing.Point(33, 264);
            this.btnEnregPers.Name = "btnEnregPers";
            this.btnEnregPers.Size = new System.Drawing.Size(263, 53);
            this.btnEnregPers.TabIndex = 10;
            this.btnEnregPers.Text = "Enregistrer";
            this.btnEnregPers.UseVisualStyleBackColor = true;
            // 
            // btnAnnulPers
            // 
            this.btnAnnulPers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulPers.Location = new System.Drawing.Point(323, 264);
            this.btnAnnulPers.Name = "btnAnnulPers";
            this.btnAnnulPers.Size = new System.Drawing.Size(263, 53);
            this.btnAnnulPers.TabIndex = 11;
            this.btnAnnulPers.Text = "Annuler";
            this.btnAnnulPers.UseVisualStyleBackColor = true;
            // 
            // grbLesAbsences
            // 
            this.grbLesAbsences.Controls.Add(this.btnDemandeSupprAbs);
            this.grbLesAbsences.Controls.Add(this.btnDemandeModifAbs);
            this.grbLesAbsences.Controls.Add(this.dgvAbsences);
            this.grbLesAbsences.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLesAbsences.Location = new System.Drawing.Point(1515, 31);
            this.grbLesAbsences.Name = "grbLesAbsences";
            this.grbLesAbsences.Size = new System.Drawing.Size(910, 689);
            this.grbLesAbsences.TabIndex = 2;
            this.grbLesAbsences.TabStop = false;
            this.grbLesAbsences.Text = "Les absences";
            // 
            // btnDemandeSupprAbs
            // 
            this.btnDemandeSupprAbs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeSupprAbs.Location = new System.Drawing.Point(323, 609);
            this.btnDemandeSupprAbs.Name = "btnDemandeSupprAbs";
            this.btnDemandeSupprAbs.Size = new System.Drawing.Size(263, 53);
            this.btnDemandeSupprAbs.TabIndex = 2;
            this.btnDemandeSupprAbs.Text = "Supprimer";
            this.btnDemandeSupprAbs.UseVisualStyleBackColor = true;
            // 
            // btnDemandeModifAbs
            // 
            this.btnDemandeModifAbs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeModifAbs.Location = new System.Drawing.Point(33, 609);
            this.btnDemandeModifAbs.Name = "btnDemandeModifAbs";
            this.btnDemandeModifAbs.Size = new System.Drawing.Size(263, 53);
            this.btnDemandeModifAbs.TabIndex = 1;
            this.btnDemandeModifAbs.Text = "Modifier";
            this.btnDemandeModifAbs.UseVisualStyleBackColor = true;
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.AllowUserToAddRows = false;
            this.dgvAbsences.AllowUserToDeleteRows = false;
            this.dgvAbsences.AllowUserToResizeRows = false;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(33, 41);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.RowHeadersWidth = 82;
            this.dgvAbsences.RowTemplate.Height = 33;
            this.dgvAbsences.Size = new System.Drawing.Size(848, 545);
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
            this.grbAbsence.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAbsence.Location = new System.Drawing.Point(1515, 772);
            this.grbAbsence.Name = "grbAbsence";
            this.grbAbsence.Size = new System.Drawing.Size(910, 345);
            this.grbAbsence.TabIndex = 3;
            this.grbAbsence.TabStop = false;
            this.grbAbsence.Text = "Ajouter une absence";
            // 
            // btnAnnulAbs
            // 
            this.btnAnnulAbs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulAbs.Location = new System.Drawing.Point(323, 264);
            this.btnAnnulAbs.Name = "btnAnnulAbs";
            this.btnAnnulAbs.Size = new System.Drawing.Size(263, 53);
            this.btnAnnulAbs.TabIndex = 11;
            this.btnAnnulAbs.Text = "Annuler";
            this.btnAnnulAbs.UseVisualStyleBackColor = true;
            // 
            // btnEnregAbs
            // 
            this.btnEnregAbs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregAbs.Location = new System.Drawing.Point(33, 264);
            this.btnEnregAbs.Name = "btnEnregAbs";
            this.btnEnregAbs.Size = new System.Drawing.Size(263, 53);
            this.btnEnregAbs.TabIndex = 10;
            this.btnEnregAbs.Text = "Enregistrer";
            this.btnEnregAbs.UseVisualStyleBackColor = true;
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(182, 194);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(496, 40);
            this.cboMotif.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Motif";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Date fin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Date début";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpDateDebut.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateDebut.Location = new System.Drawing.Point(182, 63);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(304, 39);
            this.dtpDateDebut.TabIndex = 12;
            this.dtpDateDebut.Value = new System.DateTime(2025, 5, 20, 17, 39, 0, 0);
            this.dtpDateDebut.ValueChanged += new System.EventHandler(this.dtpDateDebut_ValueChanged);
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFin.Location = new System.Drawing.Point(182, 134);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(304, 39);
            this.dtpDateFin.TabIndex = 13;
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
            this.Load += new System.EventHandler(this.FrmMediaTek86_Load);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}


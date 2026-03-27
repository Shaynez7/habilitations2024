namespace Habilitations2024.view
{
    partial class FrmHabilitations
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

        #region

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        /// 

        
        private void InitializeComponent()
        {
            this.grbLesDeveloppeurs = new System.Windows.Forms.GroupBox();
            this.dgvDeveloppeurs = new System.Windows.Forms.DataGridView();
            this.btnDemandeModifDev = new System.Windows.Forms.Button();
            this.btnDemandeSupprDev = new System.Windows.Forms.Button();
            this.btnDemandeChangePwd = new System.Windows.Forms.Button();
            this.grbDeveloppeur = new System.Windows.Forms.GroupBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.cboProfil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnregDev = new System.Windows.Forms.Button();
            this.btnAnnulDev = new System.Windows.Forms.Button();
            this.grbPwd = new System.Windows.Forms.GroupBox();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEnregPwd = new System.Windows.Forms.Button();
            this.btnAnnulPwd = new System.Windows.Forms.Button();
            this.grbLesDeveloppeurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeurs)).BeginInit();
            this.grbDeveloppeur.SuspendLayout();
            this.grbPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLesDeveloppeurs
            // 
            this.grbLesDeveloppeurs.Controls.Add(this.btnDemandeChangePwd);
            this.grbLesDeveloppeurs.Controls.Add(this.btnDemandeSupprDev);
            this.grbLesDeveloppeurs.Controls.Add(this.btnDemandeModifDev);
            this.grbLesDeveloppeurs.Controls.Add(this.dgvDeveloppeurs);
            this.grbLesDeveloppeurs.Location = new System.Drawing.Point(12, 12);
            this.grbLesDeveloppeurs.Name = "grbLesDeveloppeurs";
            this.grbLesDeveloppeurs.Size = new System.Drawing.Size(950, 288);
            this.grbLesDeveloppeurs.TabIndex = 0;
            this.grbLesDeveloppeurs.TabStop = false;
            this.grbLesDeveloppeurs.Text = "Les développeurs";
            // 
            // dgvDeveloppeurs
            // 
            this.dgvDeveloppeurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDeveloppeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeveloppeurs.Location = new System.Drawing.Point(6, 21);
            this.dgvDeveloppeurs.MultiSelect = false;
            this.dgvDeveloppeurs.Name = "dgvDeveloppeurs";
            this.dgvDeveloppeurs.ReadOnly = true;
            this.dgvDeveloppeurs.RowHeadersVisible = false;
            this.dgvDeveloppeurs.RowHeadersWidth = 51;
            this.dgvDeveloppeurs.RowTemplate.Height = 24;
            this.dgvDeveloppeurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeveloppeurs.Size = new System.Drawing.Size(929, 229);
            this.dgvDeveloppeurs.TabIndex = 0;
            // 
            // btnDemandeModifDev
            // 
            this.btnDemandeModifDev.Location = new System.Drawing.Point(16, 256);
            this.btnDemandeModifDev.Name = "btnDemandeModifDev";
            this.btnDemandeModifDev.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeModifDev.TabIndex = 1;
            this.btnDemandeModifDev.Text = "Modifier";
            this.btnDemandeModifDev.UseVisualStyleBackColor = true;
            this.btnDemandeModifDev.Click += new System.EventHandler(this.btnDemandeModifDev_Click);
            // 
            // btnDemandeSupprDev
            // 
            this.btnDemandeSupprDev.Location = new System.Drawing.Point(97, 256);
            this.btnDemandeSupprDev.Name = "btnDemandeSupprDev";
            this.btnDemandeSupprDev.Size = new System.Drawing.Size(84, 23);
            this.btnDemandeSupprDev.TabIndex = 2;
            this.btnDemandeSupprDev.Text = "Supprimer";
            this.btnDemandeSupprDev.UseVisualStyleBackColor = true;
            this.btnDemandeSupprDev.Click += new System.EventHandler(this.btnDemandeSupprDev_Click);
            // 
            // btnDemandeChangePwd
            // 
            this.btnDemandeChangePwd.Location = new System.Drawing.Point(187, 256);
            this.btnDemandeChangePwd.Name = "btnDemandeChangePwd";
            this.btnDemandeChangePwd.Size = new System.Drawing.Size(99, 23);
            this.btnDemandeChangePwd.TabIndex = 3;
            this.btnDemandeChangePwd.Text = "Changer pwd";
            this.btnDemandeChangePwd.UseVisualStyleBackColor = true;
            this.btnDemandeChangePwd.Click += new System.EventHandler(this.btnDemandeChangePwd_Click);
            // 
            // grbDeveloppeur
            // 
            this.grbDeveloppeur.Controls.Add(this.btnAnnulDev);
            this.grbDeveloppeur.Controls.Add(this.btnEnregDev);
            this.grbDeveloppeur.Controls.Add(this.label5);
            this.grbDeveloppeur.Controls.Add(this.label4);
            this.grbDeveloppeur.Controls.Add(this.label3);
            this.grbDeveloppeur.Controls.Add(this.label2);
            this.grbDeveloppeur.Controls.Add(this.label1);
            this.grbDeveloppeur.Controls.Add(this.cboProfil);
            this.grbDeveloppeur.Controls.Add(this.txtTel);
            this.grbDeveloppeur.Controls.Add(this.txtMail);
            this.grbDeveloppeur.Controls.Add(this.txtNom);
            this.grbDeveloppeur.Controls.Add(this.txtPrenom);
            this.grbDeveloppeur.Location = new System.Drawing.Point(12, 306);
            this.grbDeveloppeur.Name = "grbDeveloppeur";
            this.grbDeveloppeur.Size = new System.Drawing.Size(950, 202);
            this.grbDeveloppeur.TabIndex = 1;
            this.grbDeveloppeur.TabStop = false;
            this.grbDeveloppeur.Text = "Ajouter un développeur";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(131, 106);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(340, 22);
            this.txtPrenom.TabIndex = 0;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(131, 45);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(340, 22);
            this.txtNom.TabIndex = 1;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(592, 48);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(315, 22);
            this.txtMail.TabIndex = 2;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(592, 103);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(223, 22);
            this.txtTel.TabIndex = 3;
            // 
            // cboProfil
            // 
            this.cboProfil.FormattingEnabled = true;
            this.cboProfil.Location = new System.Drawing.Point(592, 160);
            this.cboProfil.Name = "cboProfil";
            this.cboProfil.Size = new System.Drawing.Size(223, 24);
            this.cboProfil.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Profil";
            // 
            // btnEnregDev
            // 
            this.btnEnregDev.Location = new System.Drawing.Point(16, 161);
            this.btnEnregDev.Name = "btnEnregDev";
            this.btnEnregDev.Size = new System.Drawing.Size(85, 23);
            this.btnEnregDev.TabIndex = 10;
            this.btnEnregDev.Text = "Enregistrer";
            this.btnEnregDev.UseVisualStyleBackColor = true;
            this.btnEnregDev.Click += new System.EventHandler(this.btnEnregDev_Click);
            // 
            // btnAnnulDev
            // 
            this.btnAnnulDev.Location = new System.Drawing.Point(122, 161);
            this.btnAnnulDev.Name = "btnAnnulDev";
            this.btnAnnulDev.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulDev.TabIndex = 11;
            this.btnAnnulDev.Text = "Annuler";
            this.btnAnnulDev.UseVisualStyleBackColor = true;
            this.btnAnnulDev.Click += new System.EventHandler(this.btnAnnulDev_Click);
            // 
            // grbPwd
            // 
            this.grbPwd.Controls.Add(this.btnAnnulPwd);
            this.grbPwd.Controls.Add(this.btnEnregPwd);
            this.grbPwd.Controls.Add(this.label7);
            this.grbPwd.Controls.Add(this.label6);
            this.grbPwd.Controls.Add(this.txtPwd2);
            this.grbPwd.Controls.Add(this.txtPwd1);
            this.grbPwd.Location = new System.Drawing.Point(12, 514);
            this.grbPwd.Name = "grbPwd";
            this.grbPwd.Size = new System.Drawing.Size(950, 157);
            this.grbPwd.TabIndex = 2;
            this.grbPwd.TabStop = false;
            this.grbPwd.Text = "Changer le mot de passe";
            // 
            // txtPwd1
            // 
            this.txtPwd1.Location = new System.Drawing.Point(131, 55);
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.Size = new System.Drawing.Size(340, 22);
            this.txtPwd1.TabIndex = 0;
            this.txtPwd1.UseSystemPasswordChar = true;
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(592, 58);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.Size = new System.Drawing.Size(315, 22);
            this.txtPwd2.TabIndex = 1;
            this.txtPwd2.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "pwd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "encore";
            // 
            // btnEnregPwd
            // 
            this.btnEnregPwd.Location = new System.Drawing.Point(16, 112);
            this.btnEnregPwd.Name = "btnEnregPwd";
            this.btnEnregPwd.Size = new System.Drawing.Size(85, 23);
            this.btnEnregPwd.TabIndex = 4;
            this.btnEnregPwd.Text = "Enregistrer";
            this.btnEnregPwd.UseVisualStyleBackColor = true;
            this.btnEnregPwd.Click += new System.EventHandler(this.btnEnregPwd_Click);
            // 
            // btnAnnulPwd
            // 
            this.btnAnnulPwd.Location = new System.Drawing.Point(122, 112);
            this.btnAnnulPwd.Name = "btnAnnulPwd";
            this.btnAnnulPwd.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulPwd.TabIndex = 5;
            this.btnAnnulPwd.Text = "Annuler";
            this.btnAnnulPwd.UseVisualStyleBackColor = true;
            this.btnAnnulPwd.Click += new System.EventHandler(this.btnAnnulPwd_Click);
            // 
            // FrmHabilitations
            // 
            this.ClientSize = new System.Drawing.Size(974, 683);
            this.Controls.Add(this.grbPwd);
            this.Controls.Add(this.grbDeveloppeur);
            this.Controls.Add(this.grbLesDeveloppeurs);
            this.Name = "FrmHabilitations";
            this.grbLesDeveloppeurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeurs)).EndInit();
            this.grbDeveloppeur.ResumeLayout(false);
            this.grbDeveloppeur.PerformLayout();
            this.grbPwd.ResumeLayout(false);
            this.grbPwd.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.DataGridView dgvDev;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnPwd;
        private System.Windows.Forms.Label lblAjoutDev;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button BtnEnregistrerDev;
        private System.Windows.Forms.Button f;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblEncore;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button BtnEnregistrerMdp;
        private System.Windows.Forms.Button BtnAnnulerMdp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox grbLesDeveloppeurs;
        private System.Windows.Forms.DataGridView dgvDeveloppeurs;
        private System.Windows.Forms.Button btnDemandeChangePwd;
        private System.Windows.Forms.Button btnDemandeSupprDev;
        private System.Windows.Forms.Button btnDemandeModifDev;
        private System.Windows.Forms.GroupBox grbDeveloppeur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProfil;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnnulDev;
        private System.Windows.Forms.Button btnEnregDev;
        private System.Windows.Forms.GroupBox grbPwd;
        private System.Windows.Forms.Button btnAnnulPwd;
        private System.Windows.Forms.Button btnEnregPwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.TextBox txtPwd1;
    }
}


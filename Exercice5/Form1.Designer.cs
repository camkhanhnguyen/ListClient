
namespace Exercice5
{
    partial class frmBeautyShop
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblBesoins = new System.Windows.Forms.Label();
            this.cboBesoins = new System.Windows.Forms.ComboBox();
            this.lblMarques = new System.Windows.Forms.Label();
            this.cboMarques = new System.Windows.Forms.ComboBox();
            this.lblQuantités = new System.Windows.Forms.Label();
            this.nudQuantités = new System.Windows.Forms.NumericUpDown();
            this.lstClients = new System.Windows.Forms.ListBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.rdbSoinVisage = new System.Windows.Forms.RadioButton();
            this.rdbMaquillage = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantités)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(127, 41);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(270, 27);
            this.txtLogin.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(43, 47);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 17);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // lblBesoins
            // 
            this.lblBesoins.AutoSize = true;
            this.lblBesoins.Location = new System.Drawing.Point(43, 102);
            this.lblBesoins.Name = "lblBesoins";
            this.lblBesoins.Size = new System.Drawing.Size(58, 17);
            this.lblBesoins.TabIndex = 2;
            this.lblBesoins.Text = "Besoins";
            // 
            // cboBesoins
            // 
            this.cboBesoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBesoins.FormattingEnabled = true;
            this.cboBesoins.Items.AddRange(new object[] {
            "Soin anti-rides & anti-âge",
            "Soin hydratant & nourrissant",
            "Soin matifiant",
            "Soin anti-imperfections",
            "Soin anti-rougeurs",
            "Soin peaux sensibles",
            "Soin raffermissant & liftant",
            "Soin anti tache",
            "Soin éclat & anti-Fatigue"});
            this.cboBesoins.Location = new System.Drawing.Point(127, 96);
            this.cboBesoins.Name = "cboBesoins";
            this.cboBesoins.Size = new System.Drawing.Size(270, 28);
            this.cboBesoins.TabIndex = 5;
            // 
            // lblMarques
            // 
            this.lblMarques.AutoSize = true;
            this.lblMarques.Location = new System.Drawing.Point(43, 156);
            this.lblMarques.Name = "lblMarques";
            this.lblMarques.Size = new System.Drawing.Size(63, 17);
            this.lblMarques.TabIndex = 6;
            this.lblMarques.Text = "Marques";
            // 
            // cboMarques
            // 
            this.cboMarques.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarques.FormattingEnabled = true;
            this.cboMarques.Items.AddRange(new object[] {
            "DIOR",
            "GUERLAIN",
            "CHANEL",
            "TOO FACED",
            "LANCÔME",
            "YVES SAINT LAURENT",
            "CLARINS",
            "BENEFIT COSMETICS",
            "NARS"});
            this.cboMarques.Location = new System.Drawing.Point(127, 150);
            this.cboMarques.Name = "cboMarques";
            this.cboMarques.Size = new System.Drawing.Size(270, 28);
            this.cboMarques.TabIndex = 7;
            // 
            // lblQuantités
            // 
            this.lblQuantités.AutoSize = true;
            this.lblQuantités.Location = new System.Drawing.Point(43, 202);
            this.lblQuantités.Name = "lblQuantités";
            this.lblQuantités.Size = new System.Drawing.Size(75, 17);
            this.lblQuantités.TabIndex = 8;
            this.lblQuantités.Text = "Quantié(s)";
            // 
            // nudQuantités
            // 
            this.nudQuantités.Location = new System.Drawing.Point(127, 200);
            this.nudQuantités.Name = "nudQuantités";
            this.nudQuantités.Size = new System.Drawing.Size(70, 22);
            this.nudQuantités.TabIndex = 9;
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.ItemHeight = 16;
            this.lstClients.Location = new System.Drawing.Point(46, 251);
            this.lstClients.Name = "lstClients";
            this.lstClients.ScrollAlwaysVisible = true;
            this.lstClients.Size = new System.Drawing.Size(505, 180);
            this.lstClients.TabIndex = 10;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(447, 148);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(104, 25);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // rdbSoinVisage
            // 
            this.rdbSoinVisage.AutoSize = true;
            this.rdbSoinVisage.Location = new System.Drawing.Point(447, 45);
            this.rdbSoinVisage.Name = "rdbSoinVisage";
            this.rdbSoinVisage.Size = new System.Drawing.Size(104, 21);
            this.rdbSoinVisage.TabIndex = 12;
            this.rdbSoinVisage.TabStop = true;
            this.rdbSoinVisage.Text = "Soin Visage";
            this.rdbSoinVisage.UseVisualStyleBackColor = true;
            this.rdbSoinVisage.CheckedChanged += new System.EventHandler(this.rdbSoinVisage_CheckedChanged);
            // 
            // rdbMaquillage
            // 
            this.rdbMaquillage.AutoSize = true;
            this.rdbMaquillage.Location = new System.Drawing.Point(447, 98);
            this.rdbMaquillage.Name = "rdbMaquillage";
            this.rdbMaquillage.Size = new System.Drawing.Size(97, 21);
            this.rdbMaquillage.TabIndex = 13;
            this.rdbMaquillage.TabStop = true;
            this.rdbMaquillage.Text = "Maquillage";
            this.rdbMaquillage.UseVisualStyleBackColor = true;
            this.rdbMaquillage.CheckedChanged += new System.EventHandler(this.rdbMaquillage_CheckedChanged);
            // 
            // frmBeautyShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.rdbMaquillage);
            this.Controls.Add(this.rdbSoinVisage);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lstClients);
            this.Controls.Add(this.nudQuantités);
            this.Controls.Add(this.lblQuantités);
            this.Controls.Add(this.cboMarques);
            this.Controls.Add(this.lblMarques);
            this.Controls.Add(this.cboBesoins);
            this.Controls.Add(this.lblBesoins);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Name = "frmBeautyShop";
            this.Text = "Beauty Shop";
            this.Load += new System.EventHandler(this.frmBeautyShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantités)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblBesoins;
        private System.Windows.Forms.ComboBox cboBesoins;
        private System.Windows.Forms.Label lblMarques;
        private System.Windows.Forms.ComboBox cboMarques;
        private System.Windows.Forms.Label lblQuantités;
        private System.Windows.Forms.NumericUpDown nudQuantités;
        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.RadioButton rdbSoinVisage;
        private System.Windows.Forms.RadioButton rdbMaquillage;
    }
}


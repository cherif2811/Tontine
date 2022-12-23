namespace suivibouteilles.FrmConnexion
{
    partial class BaseDonnee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseDonnee));
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.gpAutentification = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cbDataBase = new System.Windows.Forms.ComboBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.rdAuthMsSql = new System.Windows.Forms.RadioButton();
            this.rdAuthWindows = new System.Windows.Forms.RadioButton();
            this.lblServeur = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtTest = new DevExpress.XtraEditors.SimpleButton();
            this.Btconnecter = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.gpAutentification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(481, 7);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(42, 21);
            this.txtPort.TabIndex = 18;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(261, 6);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(179, 21);
            this.txtServerName.TabIndex = 20;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPort.Location = new System.Drawing.Point(446, 9);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(37, 13);
            this.lblPort.TabIndex = 17;
            this.lblPort.Text = "Port : ";
            // 
            // gpAutentification
            // 
            this.gpAutentification.Controls.Add(this.txtPass);
            this.gpAutentification.Controls.Add(this.lblData);
            this.gpAutentification.Controls.Add(this.txtUser);
            this.gpAutentification.Controls.Add(this.cbDataBase);
            this.gpAutentification.Controls.Add(this.lblPass);
            this.gpAutentification.Controls.Add(this.lblUser);
            this.gpAutentification.Controls.Add(this.rdAuthMsSql);
            this.gpAutentification.Controls.Add(this.rdAuthWindows);
            this.gpAutentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gpAutentification.Location = new System.Drawing.Point(206, 33);
            this.gpAutentification.Name = "gpAutentification";
            this.gpAutentification.Size = new System.Drawing.Size(328, 174);
            this.gpAutentification.TabIndex = 19;
            this.gpAutentification.TabStop = false;
            this.gpAutentification.Text = "Authentication ";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(139, 107);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(183, 20);
            this.txtPass.TabIndex = 13;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblData.Location = new System.Drawing.Point(21, 136);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(63, 13);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "Data Base :";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(140, 73);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(182, 20);
            this.txtUser.TabIndex = 12;
            // 
            // cbDataBase
            // 
            this.cbDataBase.FormattingEnabled = true;
            this.cbDataBase.Location = new System.Drawing.Point(104, 133);
            this.cbDataBase.Name = "cbDataBase";
            this.cbDataBase.Size = new System.Drawing.Size(218, 21);
            this.cbDataBase.TabIndex = 10;
            this.cbDataBase.DropDown += new System.EventHandler(this.cbDataBase_DropDown);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPass.Location = new System.Drawing.Point(21, 110);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(78, 13);
            this.lblPass.TabIndex = 11;
            this.lblPass.Text = "Mot de Passe :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUser.Location = new System.Drawing.Point(21, 80);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(90, 13);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "Nom d\'utilisateur :";
            // 
            // rdAuthMsSql
            // 
            this.rdAuthMsSql.AutoSize = true;
            this.rdAuthMsSql.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdAuthMsSql.Location = new System.Drawing.Point(155, 35);
            this.rdAuthMsSql.Name = "rdAuthMsSql";
            this.rdAuthMsSql.Size = new System.Drawing.Size(163, 17);
            this.rdAuthMsSql.TabIndex = 1;
            this.rdAuthMsSql.Text = "Authentication  Ms Sql server";
            this.rdAuthMsSql.UseVisualStyleBackColor = true;
            this.rdAuthMsSql.CheckedChanged += new System.EventHandler(this.rdAuthMsSql_CheckedChanged);
            // 
            // rdAuthWindows
            // 
            this.rdAuthWindows.AutoSize = true;
            this.rdAuthWindows.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdAuthWindows.Location = new System.Drawing.Point(6, 35);
            this.rdAuthWindows.Name = "rdAuthWindows";
            this.rdAuthWindows.Size = new System.Drawing.Size(143, 17);
            this.rdAuthWindows.TabIndex = 0;
            this.rdAuthWindows.Text = "Authentication  Windows";
            this.rdAuthWindows.UseVisualStyleBackColor = true;
            this.rdAuthWindows.CheckedChanged += new System.EventHandler(this.rdAuthWindows_CheckedChanged);
            // 
            // lblServeur
            // 
            this.lblServeur.AutoSize = true;
            this.lblServeur.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblServeur.Location = new System.Drawing.Point(203, 9);
            this.lblServeur.Name = "lblServeur";
            this.lblServeur.Size = new System.Drawing.Size(55, 13);
            this.lblServeur.TabIndex = 16;
            this.lblServeur.Text = "Serveur : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(195, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "label1";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(105, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "label1";
            this.label10.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(62, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "label1";
            this.label4.Visible = false;
            // 
            // BtTest
            // 
            this.BtTest.Location = new System.Drawing.Point(360, 226);
            this.BtTest.Name = "BtTest";
            this.BtTest.Size = new System.Drawing.Size(89, 23);
            this.BtTest.TabIndex = 25;
            this.BtTest.Text = "Tester";
            this.BtTest.ToolTip = "Tester la connection";
            this.BtTest.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.BtTest.Click += new System.EventHandler(this.BtTest_Click);
            // 
            // Btconnecter
            // 
            this.Btconnecter.Location = new System.Drawing.Point(455, 226);
            this.Btconnecter.Name = "Btconnecter";
            this.Btconnecter.Size = new System.Drawing.Size(75, 23);
            this.Btconnecter.TabIndex = 26;
            this.Btconnecter.Text = "Connecter";
            this.Btconnecter.ToolTip = "Connecter à la base de donnée";
            this.Btconnecter.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.Btconnecter.Click += new System.EventHandler(this.Btconnecter_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::suivibouteilles.Properties.Resources.image_sql;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(188, 204);
            this.pictureEdit1.TabIndex = 14;
            // 
            // BaseDonnee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 261);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.Btconnecter);
            this.Controls.Add(this.BtTest);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.gpAutentification);
            this.Controls.Add(this.lblServeur);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("BaseDonnee.IconOptions.Icon")));
            this.IconOptions.Image = global::suivibouteilles.Properties.Resources.icon5;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseDonnee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Base de Données";
            this.Load += new System.EventHandler(this.BaseDonnee_Load);
            this.gpAutentification.ResumeLayout(false);
            this.gpAutentification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.GroupBox gpAutentification;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox cbDataBase;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.RadioButton rdAuthMsSql;
        private System.Windows.Forms.RadioButton rdAuthWindows;
        private System.Windows.Forms.Label lblServeur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton BtTest;
        private DevExpress.XtraEditors.SimpleButton Btconnecter;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        public System.Windows.Forms.TextBox txtServerName;
    }
}
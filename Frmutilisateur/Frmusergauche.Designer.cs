namespace suivibouteilles.Frmutilisateur
{
    partial class Frmusergauche
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmusergauche));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btDel = new DevExpress.XtraEditors.SimpleButton();
            this.btupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.griduserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new suivibouteilles.Dataset.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coliduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPwdName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrenomLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidprofil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbolBlackList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangeBase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconnexion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchangeannee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrequete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidprofil1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLibprofil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.griduserTableAdapter = new suivibouteilles.Dataset.DataSet1TableAdapters.GriduserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griduserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btDel);
            this.panelControl2.Controls.Add(this.btupdate);
            this.panelControl2.Controls.Add(this.btAjouter);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 274);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(338, 56);
            this.panelControl2.TabIndex = 2;
            // 
            // btDel
            // 
            this.btDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btDel.ImageOptions.Image")));
            this.btDel.Location = new System.Drawing.Point(236, 17);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 2;
            this.btDel.Text = "Supprimer";
            // 
            // btupdate
            // 
            this.btupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btupdate.ImageOptions.Image")));
            this.btupdate.Location = new System.Drawing.Point(138, 17);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 1;
            this.btupdate.Text = "Modifier";
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btAjouter
            // 
            this.btAjouter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btAjouter.ImageOptions.Image")));
            this.btAjouter.Location = new System.Drawing.Point(17, 17);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(75, 23);
            this.btAjouter.TabIndex = 0;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.griduserBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(334, 270);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // griduserBindingSource
            // 
            this.griduserBindingSource.DataMember = "Griduser";
            this.griduserBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coliduser,
            this.colUserName,
            this.colPwdName,
            this.colNomLogin,
            this.colPrenomLogin,
            this.colidprofil,
            this.colbolBlackList,
            this.colEmail,
            this.colChangeBase,
            this.colconnexion,
            this.colchangeannee,
            this.colrequete,
            this.colidprofil1,
            this.colLibprofil});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // coliduser
            // 
            this.coliduser.FieldName = "iduser";
            this.coliduser.Name = "coliduser";
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            // 
            // colPwdName
            // 
            this.colPwdName.FieldName = "PwdName";
            this.colPwdName.Name = "colPwdName";
            this.colPwdName.Visible = true;
            this.colPwdName.VisibleIndex = 1;
            // 
            // colNomLogin
            // 
            this.colNomLogin.FieldName = "NomLogin";
            this.colNomLogin.Name = "colNomLogin";
            this.colNomLogin.Visible = true;
            this.colNomLogin.VisibleIndex = 2;
            // 
            // colPrenomLogin
            // 
            this.colPrenomLogin.FieldName = "PrenomLogin";
            this.colPrenomLogin.Name = "colPrenomLogin";
            this.colPrenomLogin.Visible = true;
            this.colPrenomLogin.VisibleIndex = 3;
            // 
            // colidprofil
            // 
            this.colidprofil.FieldName = "idprofil";
            this.colidprofil.Name = "colidprofil";
            // 
            // colbolBlackList
            // 
            this.colbolBlackList.FieldName = "bolBlackList";
            this.colbolBlackList.Name = "colbolBlackList";
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // colChangeBase
            // 
            this.colChangeBase.FieldName = "ChangeBase";
            this.colChangeBase.Name = "colChangeBase";
            // 
            // colconnexion
            // 
            this.colconnexion.FieldName = "connexion";
            this.colconnexion.Name = "colconnexion";
            // 
            // colchangeannee
            // 
            this.colchangeannee.FieldName = "changeannee";
            this.colchangeannee.Name = "colchangeannee";
            // 
            // colrequete
            // 
            this.colrequete.FieldName = "requete";
            this.colrequete.Name = "colrequete";
            // 
            // colidprofil1
            // 
            this.colidprofil1.FieldName = "idprofil1";
            this.colidprofil1.Name = "colidprofil1";
            // 
            // colLibprofil
            // 
            this.colLibprofil.FieldName = "Libprofil";
            this.colLibprofil.Name = "colLibprofil";
            this.colLibprofil.Visible = true;
            this.colLibprofil.VisibleIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(338, 274);
            this.panelControl1.TabIndex = 4;
            // 
            // griduserTableAdapter
            // 
            this.griduserTableAdapter.ClearBeforeFill = true;
            // 
            // Frmusergauche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "Frmusergauche";
            this.Size = new System.Drawing.Size(338, 330);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griduserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btDel;
        private DevExpress.XtraEditors.SimpleButton btupdate;
        private DevExpress.XtraEditors.SimpleButton btAjouter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource griduserBindingSource;
        private Dataset.DataSet1 dataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn coliduser;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPwdName;
        private DevExpress.XtraGrid.Columns.GridColumn colNomLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colPrenomLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colidprofil;
        private DevExpress.XtraGrid.Columns.GridColumn colbolBlackList;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colChangeBase;
        private DevExpress.XtraGrid.Columns.GridColumn colconnexion;
        private DevExpress.XtraGrid.Columns.GridColumn colchangeannee;
        private DevExpress.XtraGrid.Columns.GridColumn colrequete;
        private DevExpress.XtraGrid.Columns.GridColumn colidprofil1;
        private DevExpress.XtraGrid.Columns.GridColumn colLibprofil;
        private Dataset.DataSet1TableAdapters.GriduserTableAdapter griduserTableAdapter;
    }
}

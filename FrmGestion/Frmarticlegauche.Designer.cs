namespace suivibouteilles.FrmGestion
{
    partial class Frmarticlegauche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmarticlegauche));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtidarticle = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Btupdate = new DevExpress.XtraEditors.SimpleButton();
            this.Btok = new DevExpress.XtraEditors.SimpleButton();
            this.BTDel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tarticleGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new suivibouteilles.Dataset.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodeArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesignation1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodepark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collibelle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapacite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesignation2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeCat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesiCat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodesous = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesiSousCat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmise = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprixachat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtstock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprixvente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrenomLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tarticleGridTableAdapter = new suivibouteilles.Dataset.DataSet1TableAdapters.TarticleGridTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtidarticle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarticleGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtidarticle);
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.Btupdate);
            this.panelControl2.Controls.Add(this.Btok);
            this.panelControl2.Controls.Add(this.BTDel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 341);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(412, 52);
            this.panelControl2.TabIndex = 3;
            // 
            // txtidarticle
            // 
            this.txtidarticle.Enabled = false;
            this.txtidarticle.Location = new System.Drawing.Point(358, 16);
            this.txtidarticle.Name = "txtidarticle";
            this.txtidarticle.Size = new System.Drawing.Size(36, 20);
            this.txtidarticle.TabIndex = 19;
            this.txtidarticle.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(275, 14);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(77, 24);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "&Liste";
            this.simpleButton1.ToolTipTitle = "Liste des Fournisseurs";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Btupdate
            // 
            this.Btupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btupdate.ImageOptions.Image")));
            this.Btupdate.Location = new System.Drawing.Point(109, 14);
            this.Btupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btupdate.Name = "Btupdate";
            this.Btupdate.Size = new System.Drawing.Size(64, 24);
            this.Btupdate.TabIndex = 10;
            this.Btupdate.Text = "&Modifier";
            this.Btupdate.Click += new System.EventHandler(this.Btupdate_Click);
            // 
            // Btok
            // 
            this.Btok.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btok.ImageOptions.Image")));
            this.Btok.Location = new System.Drawing.Point(26, 14);
            this.Btok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btok.Name = "Btok";
            this.Btok.Size = new System.Drawing.Size(64, 24);
            this.Btok.TabIndex = 9;
            this.Btok.Text = "&Ajouter";
            this.Btok.Click += new System.EventHandler(this.Btok_Click);
            // 
            // BTDel
            // 
            this.BTDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDel.ImageOptions.Image")));
            this.BTDel.Location = new System.Drawing.Point(192, 14);
            this.BTDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTDel.Name = "BTDel";
            this.BTDel.Size = new System.Drawing.Size(77, 24);
            this.BTDel.TabIndex = 11;
            this.BTDel.Text = "&Supprimer";
            this.BTDel.Click += new System.EventHandler(this.BTDel_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(412, 341);
            this.panelControl1.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tarticleGridBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(408, 337);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tarticleGridBindingSource
            // 
            this.tarticleGridBindingSource.DataMember = "TarticleGrid";
            this.tarticleGridBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodeArt,
            this.colDesignation1,
            this.colcodepark,
            this.collibelle,
            this.colNumero,
            this.colCapacite,
            this.colDesignation2,
            this.colCodeCat,
            this.colDesiCat,
            this.colCodesous,
            this.colDesiSousCat,
            this.colmise,
            this.colprixachat,
            this.colQtstock,
            this.colprixvente,
            this.coliduser,
            this.colUserName,
            this.colNomLogin,
            this.colPrenomLogin});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colCodeArt
            // 
            this.colCodeArt.FieldName = "CodeArt";
            this.colCodeArt.Name = "colCodeArt";
            this.colCodeArt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CodeArt", "Nbre: {0}")});
            this.colCodeArt.Visible = true;
            this.colCodeArt.VisibleIndex = 0;
            // 
            // colDesignation1
            // 
            this.colDesignation1.FieldName = "Designation1";
            this.colDesignation1.Name = "colDesignation1";
            this.colDesignation1.Visible = true;
            this.colDesignation1.VisibleIndex = 1;
            // 
            // colcodepark
            // 
            this.colcodepark.FieldName = "codepark";
            this.colcodepark.Name = "colcodepark";
            this.colcodepark.Visible = true;
            this.colcodepark.VisibleIndex = 2;
            // 
            // collibelle
            // 
            this.collibelle.FieldName = "libelle";
            this.collibelle.Name = "collibelle";
            this.collibelle.Visible = true;
            this.collibelle.VisibleIndex = 3;
            // 
            // colNumero
            // 
            this.colNumero.FieldName = "Numero";
            this.colNumero.Name = "colNumero";
            // 
            // colCapacite
            // 
            this.colCapacite.FieldName = "Capacite";
            this.colCapacite.Name = "colCapacite";
            // 
            // colDesignation2
            // 
            this.colDesignation2.FieldName = "Designation2";
            this.colDesignation2.Name = "colDesignation2";
            // 
            // colCodeCat
            // 
            this.colCodeCat.FieldName = "CodeCat";
            this.colCodeCat.Name = "colCodeCat";
            // 
            // colDesiCat
            // 
            this.colDesiCat.FieldName = "DesiCat";
            this.colDesiCat.Name = "colDesiCat";
            this.colDesiCat.Visible = true;
            this.colDesiCat.VisibleIndex = 4;
            // 
            // colCodesous
            // 
            this.colCodesous.FieldName = "Codesous";
            this.colCodesous.Name = "colCodesous";
            // 
            // colDesiSousCat
            // 
            this.colDesiSousCat.FieldName = "DesiSousCat";
            this.colDesiSousCat.Name = "colDesiSousCat";
            this.colDesiSousCat.Visible = true;
            this.colDesiSousCat.VisibleIndex = 5;
            // 
            // colmise
            // 
            this.colmise.FieldName = "mise";
            this.colmise.Name = "colmise";
            this.colmise.Visible = true;
            this.colmise.VisibleIndex = 9;
            // 
            // colprixachat
            // 
            this.colprixachat.FieldName = "prixachat";
            this.colprixachat.Name = "colprixachat";
            this.colprixachat.Visible = true;
            this.colprixachat.VisibleIndex = 10;
            // 
            // colQtstock
            // 
            this.colQtstock.FieldName = "Qtstock";
            this.colQtstock.Name = "colQtstock";
            this.colQtstock.Visible = true;
            this.colQtstock.VisibleIndex = 6;
            // 
            // colprixvente
            // 
            this.colprixvente.FieldName = "prixvente";
            this.colprixvente.Name = "colprixvente";
            this.colprixvente.Visible = true;
            this.colprixvente.VisibleIndex = 12;
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
            this.colUserName.VisibleIndex = 7;
            // 
            // colNomLogin
            // 
            this.colNomLogin.FieldName = "NomLogin";
            this.colNomLogin.Name = "colNomLogin";
            this.colNomLogin.Visible = true;
            this.colNomLogin.VisibleIndex = 8;
            // 
            // colPrenomLogin
            // 
            this.colPrenomLogin.FieldName = "PrenomLogin";
            this.colPrenomLogin.Name = "colPrenomLogin";
            this.colPrenomLogin.Visible = true;
            this.colPrenomLogin.VisibleIndex = 11;
            // 
            // tarticleGridTableAdapter
            // 
            this.tarticleGridTableAdapter.ClearBeforeFill = true;
            // 
            // Frmarticlegauche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "Frmarticlegauche";
            this.Size = new System.Drawing.Size(412, 393);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtidarticle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarticleGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton Btupdate;
        private DevExpress.XtraEditors.SimpleButton Btok;
        private DevExpress.XtraEditors.SimpleButton BTDel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tarticleGridBindingSource;
        private Dataset.DataSet1 dataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeArt;
        private DevExpress.XtraGrid.Columns.GridColumn colDesignation1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesignation2;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeCat;
        private DevExpress.XtraGrid.Columns.GridColumn colDesiCat;
        private DevExpress.XtraGrid.Columns.GridColumn colCodesous;
        private DevExpress.XtraGrid.Columns.GridColumn colDesiSousCat;
        private DevExpress.XtraGrid.Columns.GridColumn coliduser;
        private DevExpress.XtraGrid.Columns.GridColumn colQtstock;
        private Dataset.DataSet1TableAdapters.TarticleGridTableAdapter tarticleGridTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colNomLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colPrenomLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colCapacite;
        private DevExpress.XtraEditors.TextEdit txtidarticle;
        private DevExpress.XtraGrid.Columns.GridColumn colmise;
        private DevExpress.XtraGrid.Columns.GridColumn colprixachat;
        private DevExpress.XtraGrid.Columns.GridColumn colprixvente;
        private DevExpress.XtraGrid.Columns.GridColumn colcodepark;
        private DevExpress.XtraGrid.Columns.GridColumn collibelle;
    }
}

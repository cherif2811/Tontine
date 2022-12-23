namespace suivibouteilles.FrmGestion
{
    partial class Frmcollecteurgauche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcollecteurgauche));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtidclt = new DevExpress.XtraEditors.TextEdit();
            this.btnliste = new DevExpress.XtraEditors.SimpleButton();
            this.Btupdate = new DevExpress.XtraEditors.SimpleButton();
            this.Btok = new DevExpress.XtraEditors.SimpleButton();
            this.BTDel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tcollecteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new suivibouteilles.Dataset.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprenom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsexe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatenaissance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltel1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltel2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprenomp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladressep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltel1p = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltel2p = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDtCreation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDtModification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tcollecteurTableAdapter = new suivibouteilles.Dataset.DataSet1TableAdapters.TcollecteurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtidclt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcollecteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtidclt);
            this.panelControl2.Controls.Add(this.btnliste);
            this.panelControl2.Controls.Add(this.Btupdate);
            this.panelControl2.Controls.Add(this.Btok);
            this.panelControl2.Controls.Add(this.BTDel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 303);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(410, 52);
            this.panelControl2.TabIndex = 2;
            // 
            // txtidclt
            // 
            this.txtidclt.Enabled = false;
            this.txtidclt.Location = new System.Drawing.Point(360, 11);
            this.txtidclt.Name = "txtidclt";
            this.txtidclt.Size = new System.Drawing.Size(36, 20);
            this.txtidclt.TabIndex = 14;
            this.txtidclt.Visible = false;
            // 
            // btnliste
            // 
            this.btnliste.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnliste.ImageOptions.Image")));
            this.btnliste.Location = new System.Drawing.Point(275, 14);
            this.btnliste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnliste.Name = "btnliste";
            this.btnliste.Size = new System.Drawing.Size(77, 24);
            this.btnliste.TabIndex = 13;
            this.btnliste.Text = "&Liste";
            this.btnliste.ToolTipTitle = "Liste des Fournisseurs";
            this.btnliste.Click += new System.EventHandler(this.btnliste_Click);
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
            this.panelControl1.Size = new System.Drawing.Size(410, 303);
            this.panelControl1.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tcollecteurBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(406, 299);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tcollecteurBindingSource
            // 
            this.tcollecteurBindingSource.DataMember = "Tcollecteur";
            this.tcollecteurBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcode,
            this.colnom,
            this.colprenom,
            this.colsexe,
            this.coldatenaissance,
            this.coladresse,
            this.coltel1,
            this.coltel2,
            this.colnomp,
            this.colprenomp,
            this.coladressep,
            this.coltel1p,
            this.coltel2p,
            this.coliduser,
            this.colDtCreation,
            this.colDtModification});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colcode
            // 
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "code", "Nbre : {0}")});
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 0;
            // 
            // colnom
            // 
            this.colnom.FieldName = "nom";
            this.colnom.Name = "colnom";
            this.colnom.Visible = true;
            this.colnom.VisibleIndex = 1;
            // 
            // colprenom
            // 
            this.colprenom.FieldName = "prenom";
            this.colprenom.Name = "colprenom";
            this.colprenom.Visible = true;
            this.colprenom.VisibleIndex = 2;
            // 
            // colsexe
            // 
            this.colsexe.FieldName = "sexe";
            this.colsexe.Name = "colsexe";
            this.colsexe.Visible = true;
            this.colsexe.VisibleIndex = 3;
            // 
            // coldatenaissance
            // 
            this.coldatenaissance.FieldName = "datenaissance";
            this.coldatenaissance.Name = "coldatenaissance";
            this.coldatenaissance.Visible = true;
            this.coldatenaissance.VisibleIndex = 4;
            // 
            // coladresse
            // 
            this.coladresse.FieldName = "adresse";
            this.coladresse.Name = "coladresse";
            this.coladresse.Visible = true;
            this.coladresse.VisibleIndex = 5;
            // 
            // coltel1
            // 
            this.coltel1.FieldName = "tel1";
            this.coltel1.Name = "coltel1";
            this.coltel1.Visible = true;
            this.coltel1.VisibleIndex = 6;
            // 
            // coltel2
            // 
            this.coltel2.FieldName = "tel2";
            this.coltel2.Name = "coltel2";
            this.coltel2.Visible = true;
            this.coltel2.VisibleIndex = 7;
            // 
            // colnomp
            // 
            this.colnomp.FieldName = "nomp";
            this.colnomp.Name = "colnomp";
            this.colnomp.Visible = true;
            this.colnomp.VisibleIndex = 8;
            // 
            // colprenomp
            // 
            this.colprenomp.FieldName = "prenomp";
            this.colprenomp.Name = "colprenomp";
            this.colprenomp.Visible = true;
            this.colprenomp.VisibleIndex = 9;
            // 
            // coladressep
            // 
            this.coladressep.FieldName = "adressep";
            this.coladressep.Name = "coladressep";
            this.coladressep.Visible = true;
            this.coladressep.VisibleIndex = 10;
            // 
            // coltel1p
            // 
            this.coltel1p.FieldName = "tel1p";
            this.coltel1p.Name = "coltel1p";
            this.coltel1p.Visible = true;
            this.coltel1p.VisibleIndex = 11;
            // 
            // coltel2p
            // 
            this.coltel2p.FieldName = "tel2p";
            this.coltel2p.Name = "coltel2p";
            this.coltel2p.Visible = true;
            this.coltel2p.VisibleIndex = 12;
            // 
            // coliduser
            // 
            this.coliduser.FieldName = "iduser";
            this.coliduser.Name = "coliduser";
            this.coliduser.Visible = true;
            this.coliduser.VisibleIndex = 13;
            // 
            // colDtCreation
            // 
            this.colDtCreation.FieldName = "DtCreation";
            this.colDtCreation.Name = "colDtCreation";
            // 
            // colDtModification
            // 
            this.colDtModification.FieldName = "DtModification";
            this.colDtModification.Name = "colDtModification";
            // 
            // tcollecteurTableAdapter
            // 
            this.tcollecteurTableAdapter.ClearBeforeFill = true;
            // 
            // Frmcollecteurgauche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "Frmcollecteurgauche";
            this.Size = new System.Drawing.Size(410, 355);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtidclt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcollecteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnliste;
        private DevExpress.XtraEditors.SimpleButton Btupdate;
        private DevExpress.XtraEditors.SimpleButton Btok;
        private DevExpress.XtraEditors.SimpleButton BTDel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtidclt;
        private System.Windows.Forms.BindingSource tcollecteurBindingSource;
        private Dataset.DataSet1 dataSet1;
        private Dataset.DataSet1TableAdapters.TcollecteurTableAdapter tcollecteurTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colnom;
        private DevExpress.XtraGrid.Columns.GridColumn colprenom;
        private DevExpress.XtraGrid.Columns.GridColumn colsexe;
        private DevExpress.XtraGrid.Columns.GridColumn coldatenaissance;
        private DevExpress.XtraGrid.Columns.GridColumn coladresse;
        private DevExpress.XtraGrid.Columns.GridColumn coltel1;
        private DevExpress.XtraGrid.Columns.GridColumn coltel2;
        private DevExpress.XtraGrid.Columns.GridColumn colnomp;
        private DevExpress.XtraGrid.Columns.GridColumn colprenomp;
        private DevExpress.XtraGrid.Columns.GridColumn coladressep;
        private DevExpress.XtraGrid.Columns.GridColumn coltel1p;
        private DevExpress.XtraGrid.Columns.GridColumn coltel2p;
        private DevExpress.XtraGrid.Columns.GridColumn coliduser;
        private DevExpress.XtraGrid.Columns.GridColumn colDtCreation;
        private DevExpress.XtraGrid.Columns.GridColumn colDtModification;
    }
}


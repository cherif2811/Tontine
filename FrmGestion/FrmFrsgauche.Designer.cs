namespace suivibouteilles.FrmGestion
{
    partial class FrmFrsgauche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFrsgauche));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtidfrs = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Btupdate = new DevExpress.XtraEditors.SimpleButton();
            this.Btok = new DevExpress.XtraEditors.SimpleButton();
            this.BTDel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tfournisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new suivibouteilles.Dataset.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodefrs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomfrs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVille = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelephone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelephone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelecopie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiteWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDtCreation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDtModification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfournisseurTableAdapter = new suivibouteilles.Dataset.DataSet1TableAdapters.TfournisseurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtidfrs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfournisseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtidfrs);
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.Btupdate);
            this.panelControl2.Controls.Add(this.Btok);
            this.panelControl2.Controls.Add(this.BTDel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 349);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(455, 49);
            this.panelControl2.TabIndex = 1;
            // 
            // txtidfrs
            // 
            this.txtidfrs.Enabled = false;
            this.txtidfrs.Location = new System.Drawing.Point(391, 9);
            this.txtidfrs.Name = "txtidfrs";
            this.txtidfrs.Size = new System.Drawing.Size(36, 20);
            this.txtidfrs.TabIndex = 18;
            this.txtidfrs.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(291, 12);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(77, 24);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "&Liste";
            this.simpleButton1.ToolTipTitle = "Liste des Fournisseurs";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Btupdate
            // 
            this.Btupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btupdate.ImageOptions.Image")));
            this.Btupdate.Location = new System.Drawing.Point(125, 12);
            this.Btupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btupdate.Name = "Btupdate";
            this.Btupdate.Size = new System.Drawing.Size(64, 24);
            this.Btupdate.TabIndex = 15;
            this.Btupdate.Text = "&Modifier";
            this.Btupdate.Click += new System.EventHandler(this.Btupdate_Click);
            // 
            // Btok
            // 
            this.Btok.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btok.ImageOptions.Image")));
            this.Btok.Location = new System.Drawing.Point(42, 12);
            this.Btok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btok.Name = "Btok";
            this.Btok.Size = new System.Drawing.Size(64, 24);
            this.Btok.TabIndex = 14;
            this.Btok.Text = "&Ajouter";
            this.Btok.Click += new System.EventHandler(this.Btok_Click);
            // 
            // BTDel
            // 
            this.BTDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDel.ImageOptions.Image")));
            this.BTDel.Location = new System.Drawing.Point(208, 12);
            this.BTDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTDel.Name = "BTDel";
            this.BTDel.Size = new System.Drawing.Size(77, 24);
            this.BTDel.TabIndex = 16;
            this.BTDel.Text = "&Supprimer";
            this.BTDel.Click += new System.EventHandler(this.BTDel_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(455, 349);
            this.panelControl1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tfournisseurBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(451, 345);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tfournisseurBindingSource
            // 
            this.tfournisseurBindingSource.DataMember = "Tfournisseur";
            this.tfournisseurBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodefrs,
            this.colNomfrs,
            this.colAdresse,
            this.colVille,
            this.colNif,
            this.colTelephone1,
            this.colTelephone2,
            this.colTelecopie,
            this.colSiteWeb,
            this.colObservation,
            this.colDtCreation,
            this.colDtModification,
            this.coliduser});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colCodefrs
            // 
            this.colCodefrs.FieldName = "Codefrs";
            this.colCodefrs.Name = "colCodefrs";
            this.colCodefrs.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Codefrs", "Nbre : {0}")});
            this.colCodefrs.Visible = true;
            this.colCodefrs.VisibleIndex = 0;
            // 
            // colNomfrs
            // 
            this.colNomfrs.FieldName = "Nomfrs";
            this.colNomfrs.Name = "colNomfrs";
            this.colNomfrs.Visible = true;
            this.colNomfrs.VisibleIndex = 1;
            // 
            // colAdresse
            // 
            this.colAdresse.FieldName = "Adresse";
            this.colAdresse.Name = "colAdresse";
            this.colAdresse.Visible = true;
            this.colAdresse.VisibleIndex = 2;
            // 
            // colVille
            // 
            this.colVille.FieldName = "Ville";
            this.colVille.Name = "colVille";
            this.colVille.Visible = true;
            this.colVille.VisibleIndex = 3;
            // 
            // colNif
            // 
            this.colNif.FieldName = "Nif";
            this.colNif.Name = "colNif";
            this.colNif.Visible = true;
            this.colNif.VisibleIndex = 4;
            // 
            // colTelephone1
            // 
            this.colTelephone1.FieldName = "Telephone1";
            this.colTelephone1.Name = "colTelephone1";
            this.colTelephone1.Visible = true;
            this.colTelephone1.VisibleIndex = 5;
            // 
            // colTelephone2
            // 
            this.colTelephone2.FieldName = "Telephone2";
            this.colTelephone2.Name = "colTelephone2";
            this.colTelephone2.Visible = true;
            this.colTelephone2.VisibleIndex = 6;
            // 
            // colTelecopie
            // 
            this.colTelecopie.FieldName = "Telecopie";
            this.colTelecopie.Name = "colTelecopie";
            this.colTelecopie.Visible = true;
            this.colTelecopie.VisibleIndex = 7;
            // 
            // colSiteWeb
            // 
            this.colSiteWeb.FieldName = "SiteWeb";
            this.colSiteWeb.Name = "colSiteWeb";
            this.colSiteWeb.Visible = true;
            this.colSiteWeb.VisibleIndex = 8;
            // 
            // colObservation
            // 
            this.colObservation.FieldName = "Observation";
            this.colObservation.Name = "colObservation";
            this.colObservation.Visible = true;
            this.colObservation.VisibleIndex = 9;
            // 
            // colDtCreation
            // 
            this.colDtCreation.FieldName = "DtCreation";
            this.colDtCreation.Name = "colDtCreation";
            this.colDtCreation.Visible = true;
            this.colDtCreation.VisibleIndex = 10;
            // 
            // colDtModification
            // 
            this.colDtModification.FieldName = "DtModification";
            this.colDtModification.Name = "colDtModification";
            this.colDtModification.Visible = true;
            this.colDtModification.VisibleIndex = 11;
            // 
            // coliduser
            // 
            this.coliduser.FieldName = "iduser";
            this.coliduser.Name = "coliduser";
            this.coliduser.Visible = true;
            this.coliduser.VisibleIndex = 12;
            // 
            // tfournisseurTableAdapter
            // 
            this.tfournisseurTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFrsgauche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmFrsgauche";
            this.Size = new System.Drawing.Size(455, 398);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtidfrs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfournisseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton Btupdate;
        private DevExpress.XtraEditors.SimpleButton Btok;
        private DevExpress.XtraEditors.SimpleButton BTDel;
        private System.Windows.Forms.BindingSource tfournisseurBindingSource;
        private Dataset.DataSet1 dataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodefrs;
        private DevExpress.XtraGrid.Columns.GridColumn colNomfrs;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresse;
        private DevExpress.XtraGrid.Columns.GridColumn colVille;
        private DevExpress.XtraGrid.Columns.GridColumn colNif;
        private DevExpress.XtraGrid.Columns.GridColumn colTelephone1;
        private DevExpress.XtraGrid.Columns.GridColumn colTelephone2;
        private DevExpress.XtraGrid.Columns.GridColumn colTelecopie;
        private DevExpress.XtraGrid.Columns.GridColumn colSiteWeb;
        private DevExpress.XtraGrid.Columns.GridColumn colObservation;
        private DevExpress.XtraGrid.Columns.GridColumn colDtCreation;
        private DevExpress.XtraGrid.Columns.GridColumn colDtModification;
        private DevExpress.XtraGrid.Columns.GridColumn coliduser;
        private Dataset.DataSet1TableAdapters.TfournisseurTableAdapter tfournisseurTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtidfrs;
    }
}

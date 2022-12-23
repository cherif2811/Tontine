namespace suivibouteilles.FrmGestion
{
    partial class Frmcltgauche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcltgauche));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtidclt = new DevExpress.XtraEditors.TextEdit();
            this.btnliste = new DevExpress.XtraEditors.SimpleButton();
            this.Btupdate = new DevExpress.XtraEditors.SimpleButton();
            this.Btok = new DevExpress.XtraEditors.SimpleButton();
            this.BTDel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tgridclientcollecteurzoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new suivibouteilles.Dataset.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnomclt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprenomclient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsexeclient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladresseclient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltel1client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltel2client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodecol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidzone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collibelle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprenomcollecteur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladressecollecteur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltel1collecteur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltel2collecteur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomcollecteur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodeclt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltypeclt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfonction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tgridclient_collecteur_zoneTableAdapter = new suivibouteilles.Dataset.DataSet1TableAdapters.Tgridclient_collecteur_zoneTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtidclt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgridclientcollecteurzoneBindingSource)).BeginInit();
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
            this.panelControl2.Location = new System.Drawing.Point(0, 229);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(481, 52);
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
            this.btnliste.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.panelControl1.Size = new System.Drawing.Size(481, 229);
            this.panelControl1.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tgridclientcollecteurzoneBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(477, 225);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tgridclientcollecteurzoneBindingSource
            // 
            this.tgridclientcollecteurzoneBindingSource.DataMember = "Tgridclient_collecteur_zone";
            this.tgridclientcollecteurzoneBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.EnforceConstraints = false;
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnomclt,
            this.colprenomclient,
            this.colsexeclient,
            this.coladresseclient,
            this.coltel1client,
            this.coltel2client,
            this.colcodecol,
            this.colidzone,
            this.collibelle,
            this.colprenomcollecteur,
            this.coladressecollecteur,
            this.coltel1collecteur,
            this.coltel2collecteur,
            this.colnomcollecteur,
            this.colcodeclt,
            this.coltypeclt,
            this.colfonction});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colnomclt
            // 
            this.colnomclt.FieldName = "nomclt";
            this.colnomclt.Name = "colnomclt";
            this.colnomclt.Visible = true;
            this.colnomclt.VisibleIndex = 1;
            // 
            // colprenomclient
            // 
            this.colprenomclient.FieldName = "prenomclient";
            this.colprenomclient.Name = "colprenomclient";
            this.colprenomclient.Visible = true;
            this.colprenomclient.VisibleIndex = 2;
            // 
            // colsexeclient
            // 
            this.colsexeclient.FieldName = "sexeclient";
            this.colsexeclient.Name = "colsexeclient";
            this.colsexeclient.Visible = true;
            this.colsexeclient.VisibleIndex = 3;
            // 
            // coladresseclient
            // 
            this.coladresseclient.FieldName = "adresseclient";
            this.coladresseclient.Name = "coladresseclient";
            this.coladresseclient.Visible = true;
            this.coladresseclient.VisibleIndex = 4;
            // 
            // coltel1client
            // 
            this.coltel1client.FieldName = "tel1client";
            this.coltel1client.Name = "coltel1client";
            this.coltel1client.Visible = true;
            this.coltel1client.VisibleIndex = 5;
            // 
            // coltel2client
            // 
            this.coltel2client.FieldName = "tel2client";
            this.coltel2client.Name = "coltel2client";
            this.coltel2client.Visible = true;
            this.coltel2client.VisibleIndex = 6;
            // 
            // colcodecol
            // 
            this.colcodecol.FieldName = "codecol";
            this.colcodecol.Name = "colcodecol";
            this.colcodecol.Visible = true;
            this.colcodecol.VisibleIndex = 7;
            // 
            // colidzone
            // 
            this.colidzone.FieldName = "idzone";
            this.colidzone.Name = "colidzone";
            this.colidzone.Visible = true;
            this.colidzone.VisibleIndex = 8;
            // 
            // collibelle
            // 
            this.collibelle.FieldName = "libelle";
            this.collibelle.Name = "collibelle";
            this.collibelle.Visible = true;
            this.collibelle.VisibleIndex = 9;
            // 
            // colprenomcollecteur
            // 
            this.colprenomcollecteur.FieldName = "prenomcollecteur";
            this.colprenomcollecteur.Name = "colprenomcollecteur";
            this.colprenomcollecteur.Visible = true;
            this.colprenomcollecteur.VisibleIndex = 10;
            // 
            // coladressecollecteur
            // 
            this.coladressecollecteur.FieldName = "adressecollecteur";
            this.coladressecollecteur.Name = "coladressecollecteur";
            this.coladressecollecteur.Visible = true;
            this.coladressecollecteur.VisibleIndex = 11;
            // 
            // coltel1collecteur
            // 
            this.coltel1collecteur.FieldName = "tel1collecteur";
            this.coltel1collecteur.Name = "coltel1collecteur";
            this.coltel1collecteur.Visible = true;
            this.coltel1collecteur.VisibleIndex = 12;
            // 
            // coltel2collecteur
            // 
            this.coltel2collecteur.FieldName = "tel2collecteur";
            this.coltel2collecteur.Name = "coltel2collecteur";
            this.coltel2collecteur.Visible = true;
            this.coltel2collecteur.VisibleIndex = 13;
            // 
            // colnomcollecteur
            // 
            this.colnomcollecteur.FieldName = "nomcollecteur";
            this.colnomcollecteur.Name = "colnomcollecteur";
            this.colnomcollecteur.Visible = true;
            this.colnomcollecteur.VisibleIndex = 14;
            // 
            // colcodeclt
            // 
            this.colcodeclt.FieldName = "codeclt";
            this.colcodeclt.Name = "colcodeclt";
            this.colcodeclt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "codeclt", "Nbre : {0}")});
            this.colcodeclt.Visible = true;
            this.colcodeclt.VisibleIndex = 0;
            // 
            // coltypeclt
            // 
            this.coltypeclt.FieldName = "typeclt";
            this.coltypeclt.Name = "coltypeclt";
            // 
            // colfonction
            // 
            this.colfonction.FieldName = "fonction";
            this.colfonction.Name = "colfonction";
            this.colfonction.Visible = true;
            this.colfonction.VisibleIndex = 15;
            // 
            // tgridclient_collecteur_zoneTableAdapter
            // 
            this.tgridclient_collecteur_zoneTableAdapter.ClearBeforeFill = true;
            // 
            // Frmcltgauche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "Frmcltgauche";
            this.Size = new System.Drawing.Size(481, 281);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtidclt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgridclientcollecteurzoneBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource tgridclientcollecteurzoneBindingSource;
        private Dataset.DataSet1 dataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colnomclt;
        private DevExpress.XtraGrid.Columns.GridColumn colprenomclient;
        private DevExpress.XtraGrid.Columns.GridColumn colsexeclient;
        private DevExpress.XtraGrid.Columns.GridColumn coladresseclient;
        private DevExpress.XtraGrid.Columns.GridColumn coltel1client;
        private DevExpress.XtraGrid.Columns.GridColumn coltel2client;
        private DevExpress.XtraGrid.Columns.GridColumn colcodecol;
        private DevExpress.XtraGrid.Columns.GridColumn colidzone;
        private DevExpress.XtraGrid.Columns.GridColumn collibelle;
        private DevExpress.XtraGrid.Columns.GridColumn colprenomcollecteur;
        private DevExpress.XtraGrid.Columns.GridColumn coladressecollecteur;
        private DevExpress.XtraGrid.Columns.GridColumn coltel1collecteur;
        private DevExpress.XtraGrid.Columns.GridColumn coltel2collecteur;
        private DevExpress.XtraGrid.Columns.GridColumn colnomcollecteur;
        private Dataset.DataSet1TableAdapters.Tgridclient_collecteur_zoneTableAdapter tgridclient_collecteur_zoneTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coltypeclt;
        private DevExpress.XtraGrid.Columns.GridColumn colfonction;
        private DevExpress.XtraGrid.Columns.GridColumn colcodeclt;
    }
}

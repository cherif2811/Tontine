namespace suivibouteilles.FrmOperations
{
    partial class Frmprets_gauche
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
            DevExpress.Utils.Drawing.StubGlyphOptions stubGlyphOptions2 = new DevExpress.Utils.Drawing.StubGlyphOptions();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmprets_gauche));
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tmpclientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new suivibouteilles.Dataset.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodeclt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomclt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprenom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfonction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsexe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltel1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltel2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colindexe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDtCreation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDtModification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtcodecl = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Btupdate = new DevExpress.XtraEditors.SimpleButton();
            this.Btok = new DevExpress.XtraEditors.SimpleButton();
            this.BTDel = new DevExpress.XtraEditors.SimpleButton();
            this.tmpclientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodeclt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomclt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprenomclient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.tmp_clientTableAdapter = new suivibouteilles.Dataset.DataSet1TableAdapters.tmp_clientTableAdapter();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmpclientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodecl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmpclientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn2
            // 
            stubGlyphOptions2.ColorMode = DevExpress.Utils.Drawing.GlyphColorMode.Green;
            stubGlyphOptions2.Type = DevExpress.Utils.Drawing.GlyphBackgroundType.Ellipse;
            this.behaviorManager1.SetBehaviors(this.gridColumn2, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(typeof(DevExpress.XtraGrid.Views.Grid.BehaviorSource.StubGlyphBehaviorSourceForGridColumn), stubGlyphOptions2, new System.Drawing.Size(16, 16))))});
            this.gridColumn2.Caption = "Présent";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl1);
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(515, 494);
            this.panelControl3.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(511, 438);
            this.panelControl1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tmpclientBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(507, 434);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tmpclientBindingSource1
            // 
            this.tmpclientBindingSource1.DataMember = "tmp_client";
            this.tmpclientBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodeclt1,
            this.colnomclt1,
            this.colprenom,
            this.colfonction,
            this.colsexe,
            this.coladresse,
            this.coltel1,
            this.coltel2,
            this.coliduser,
            this.colindexe,
            this.gridColumn2,
            this.colDtCreation,
            this.colDtModification});
            gridFormatRule2.Column = this.gridColumn2;
            gridFormatRule2.Name = "Format0";
            gridFormatRule2.Rule = null;
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colcodeclt1
            // 
            this.colcodeclt1.FieldName = "codeclt";
            this.colcodeclt1.Name = "colcodeclt1";
            this.colcodeclt1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "codeclt", "{0}")});
            this.colcodeclt1.Visible = true;
            this.colcodeclt1.VisibleIndex = 1;
            // 
            // colnomclt1
            // 
            this.colnomclt1.FieldName = "nomclt";
            this.colnomclt1.Name = "colnomclt1";
            this.colnomclt1.Visible = true;
            this.colnomclt1.VisibleIndex = 2;
            // 
            // colprenom
            // 
            this.colprenom.FieldName = "prenom";
            this.colprenom.Name = "colprenom";
            this.colprenom.Visible = true;
            this.colprenom.VisibleIndex = 3;
            // 
            // colfonction
            // 
            this.colfonction.FieldName = "fonction";
            this.colfonction.Name = "colfonction";
            this.colfonction.Visible = true;
            this.colfonction.VisibleIndex = 4;
            // 
            // colsexe
            // 
            this.colsexe.FieldName = "sexe";
            this.colsexe.Name = "colsexe";
            this.colsexe.Visible = true;
            this.colsexe.VisibleIndex = 5;
            // 
            // coladresse
            // 
            this.coladresse.FieldName = "adresse";
            this.coladresse.Name = "coladresse";
            this.coladresse.Visible = true;
            this.coladresse.VisibleIndex = 6;
            // 
            // coltel1
            // 
            this.coltel1.FieldName = "tel1";
            this.coltel1.Name = "coltel1";
            this.coltel1.Visible = true;
            this.coltel1.VisibleIndex = 7;
            // 
            // coltel2
            // 
            this.coltel2.FieldName = "tel2";
            this.coltel2.Name = "coltel2";
            this.coltel2.Visible = true;
            this.coltel2.VisibleIndex = 8;
            // 
            // coliduser
            // 
            this.coliduser.FieldName = "iduser";
            this.coliduser.Name = "coliduser";
            this.coliduser.Visible = true;
            this.coliduser.VisibleIndex = 9;
            // 
            // colindexe
            // 
            this.colindexe.FieldName = "indexe";
            this.colindexe.Name = "colindexe";
            this.colindexe.Visible = true;
            this.colindexe.VisibleIndex = 10;
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.textEdit1);
            this.panelControl2.Controls.Add(this.txtcodecl);
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.Btupdate);
            this.panelControl2.Controls.Add(this.Btok);
            this.panelControl2.Controls.Add(this.BTDel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 440);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(511, 52);
            this.panelControl2.TabIndex = 4;
            // 
            // txtcodecl
            // 
            this.txtcodecl.Enabled = false;
            this.txtcodecl.Location = new System.Drawing.Point(374, 16);
            this.txtcodecl.Name = "txtcodecl";
            this.txtcodecl.Size = new System.Drawing.Size(36, 20);
            this.txtcodecl.TabIndex = 19;
            this.txtcodecl.Visible = false;
            this.txtcodecl.EditValueChanged += new System.EventHandler(this.txtcodecl_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(291, 14);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(77, 24);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "&Liste";
            this.simpleButton1.ToolTipTitle = "Liste des Fournisseurs";
            this.simpleButton1.Visible = false;
            // 
            // Btupdate
            // 
            this.Btupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btupdate.ImageOptions.Image")));
            this.Btupdate.Location = new System.Drawing.Point(131, 14);
            this.Btupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btupdate.Name = "Btupdate";
            this.Btupdate.Size = new System.Drawing.Size(64, 24);
            this.Btupdate.TabIndex = 10;
            this.Btupdate.Text = "&Modifier";
            this.Btupdate.Visible = false;
            this.Btupdate.Click += new System.EventHandler(this.Btupdate_Click);
            // 
            // Btok
            // 
            this.Btok.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btok.ImageOptions.Image")));
            this.Btok.Location = new System.Drawing.Point(26, 14);
            this.Btok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btok.Name = "Btok";
            this.Btok.Size = new System.Drawing.Size(77, 24);
            this.Btok.TabIndex = 9;
            this.Btok.Text = "&Saisie Op";
            this.Btok.ToolTip = "Saisie tontine";
            this.Btok.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.Btok.Click += new System.EventHandler(this.Btok_Click);
            // 
            // BTDel
            // 
            this.BTDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDel.ImageOptions.Image")));
            this.BTDel.Location = new System.Drawing.Point(208, 14);
            this.BTDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTDel.Name = "BTDel";
            this.BTDel.Size = new System.Drawing.Size(77, 24);
            this.BTDel.TabIndex = 11;
            this.BTDel.Text = "&Supprimer";
            this.BTDel.Visible = false;
            // 
            // tmpclientBindingSource
            // 
            this.tmpclientBindingSource.DataMember = "tmp_client";
            this.tmpclientBindingSource.DataSource = this.dataSet1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Présent";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "codeclt", "Nombre : {0}")});
            // 
            // colcodeclt
            // 
            this.colcodeclt.FieldName = "codeclt";
            this.colcodeclt.Name = "colcodeclt";
            this.colcodeclt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "codeclt", "Nombre : {0}")});
            // 
            // colnomclt
            // 
            this.colnomclt.FieldName = "nomclt";
            this.colnomclt.Name = "colnomclt";
            // 
            // colprenomclient
            // 
            this.colprenomclient.FieldName = "prenomclient";
            this.colprenomclient.Name = "colprenomclient";
            // 
            // tmp_clientTableAdapter
            // 
            this.tmp_clientTableAdapter.ClearBeforeFill = true;
            // 
            // textEdit1
            // 
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(439, 18);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(36, 20);
            this.textEdit1.TabIndex = 20;
            this.textEdit1.Visible = false;
            // 
            // Frmprets_gauche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Name = "Frmprets_gauche";
            this.Size = new System.Drawing.Size(515, 494);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmpclientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtcodecl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmpclientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtcodecl;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton Btupdate;
        private DevExpress.XtraEditors.SimpleButton Btok;
        private DevExpress.XtraEditors.SimpleButton BTDel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodeclt;
        private DevExpress.XtraGrid.Columns.GridColumn colnomclt;
        private DevExpress.XtraGrid.Columns.GridColumn colprenomclient;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tmpclientBindingSource;
        private Dataset.DataSet1 dataSet1;
       // private Dataset.DataSet1TableAdapters.tmp_clientTableAdapter tmp_clientTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colcodeclt1;
        private DevExpress.XtraGrid.Columns.GridColumn colnomclt1;
        private DevExpress.XtraGrid.Columns.GridColumn colprenom;
        private DevExpress.XtraGrid.Columns.GridColumn colfonction;
        private DevExpress.XtraGrid.Columns.GridColumn colsexe;
        private DevExpress.XtraGrid.Columns.GridColumn coladresse;
        private DevExpress.XtraGrid.Columns.GridColumn coltel1;
        private DevExpress.XtraGrid.Columns.GridColumn coltel2;
        private DevExpress.XtraGrid.Columns.GridColumn coliduser;
        private DevExpress.XtraGrid.Columns.GridColumn colindexe;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn colDtCreation;
        private DevExpress.XtraGrid.Columns.GridColumn colDtModification;
        private System.Windows.Forms.BindingSource tmpclientBindingSource1;
        private Dataset.DataSet1TableAdapters.tmp_clientTableAdapter tmp_clientTableAdapter;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}



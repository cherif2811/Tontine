namespace suivibouteilles.FrmFiltre
{
    partial class Frmfiltrefrsbe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmfiltrefrsbe));
            this.cmbfrs = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tfournisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new suivibouteilles.Dataset.DataSet1();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbfrs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfournisseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbfrs
            // 
            this.cmbfrs.Location = new System.Drawing.Point(78, 25);
            this.cmbfrs.Name = "cmbfrs";
            this.cmbfrs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbfrs.Properties.DataSource = this.tfournisseurBindingSource;
            this.cmbfrs.Properties.DisplayMember = "Nomfrs";
            this.cmbfrs.Properties.NullText = "";
            this.cmbfrs.Properties.PopupSizeable = false;
            this.cmbfrs.Properties.PopupView = this.gridLookUpEdit1View;
            this.cmbfrs.Properties.ValueMember = "Codefrs";
            this.cmbfrs.Size = new System.Drawing.Size(290, 20);
            this.cmbfrs.TabIndex = 50;
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
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.Click += new System.EventHandler(this.gridLookUpEdit1View_Click);
            // 
            // colCodefrs
            // 
            this.colCodefrs.FieldName = "Codefrs";
            this.colCodefrs.Name = "colCodefrs";
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
            // 
            // colVille
            // 
            this.colVille.FieldName = "Ville";
            this.colVille.Name = "colVille";
            this.colVille.Visible = true;
            this.colVille.VisibleIndex = 2;
            // 
            // colNif
            // 
            this.colNif.FieldName = "Nif";
            this.colNif.Name = "colNif";
            this.colNif.Visible = true;
            this.colNif.VisibleIndex = 3;
            // 
            // colTelephone1
            // 
            this.colTelephone1.FieldName = "Telephone1";
            this.colTelephone1.Name = "colTelephone1";
            this.colTelephone1.Visible = true;
            this.colTelephone1.VisibleIndex = 4;
            // 
            // colTelephone2
            // 
            this.colTelephone2.FieldName = "Telephone2";
            this.colTelephone2.Name = "colTelephone2";
            this.colTelephone2.Visible = true;
            this.colTelephone2.VisibleIndex = 5;
            // 
            // colTelecopie
            // 
            this.colTelecopie.FieldName = "Telecopie";
            this.colTelecopie.Name = "colTelecopie";
            // 
            // colSiteWeb
            // 
            this.colSiteWeb.FieldName = "SiteWeb";
            this.colSiteWeb.Name = "colSiteWeb";
            // 
            // colObservation
            // 
            this.colObservation.FieldName = "Observation";
            this.colObservation.Name = "colObservation";
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
            // coliduser
            // 
            this.coliduser.FieldName = "iduser";
            this.coliduser.Name = "coliduser";
            // 
            // tfournisseurTableAdapter
            // 
            this.tfournisseurTableAdapter.ClearBeforeFill = true;
            // 
            // textEdit1
            // 
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(268, 77);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 51;
            this.textEdit1.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(142, 80);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(95, 23);
            this.simpleButton1.TabIndex = 52;
            this.simpleButton1.Text = "Valider Filtre";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 53;
            this.labelControl1.Text = "Fournisseur :";
            // 
            // Frmfiltrefrsbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 115);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.cmbfrs);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Frmfiltrefrsbe.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmfiltrefrsbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frmfiltrefrsbe";
            this.Load += new System.EventHandler(this.Frmfiltrefrsbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbfrs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfournisseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit cmbfrs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private Dataset.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tfournisseurBindingSource;
        private Dataset.DataSet1TableAdapters.TfournisseurTableAdapter tfournisseurTableAdapter;
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
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
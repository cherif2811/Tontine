namespace suivibouteilles.FrmFiltre
{
    partial class Frmfiltreretour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmfiltreretour));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.cmbfrs = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tclientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new suivibouteilles.Dataset.DataSet1();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodeclt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomclt = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.tclientTableAdapter = new suivibouteilles.Dataset.DataSet1TableAdapters.TclientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbfrs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tclientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 61;
            this.labelControl1.Text = "Client :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(143, 81);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(86, 23);
            this.simpleButton1.TabIndex = 60;
            this.simpleButton1.Text = "Valider Filtre";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(266, 84);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 59;
            this.textEdit1.Visible = false;
            // 
            // cmbfrs
            // 
            this.cmbfrs.Location = new System.Drawing.Point(48, 28);
            this.cmbfrs.Name = "cmbfrs";
            this.cmbfrs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbfrs.Properties.DataSource = this.tclientBindingSource;
            this.cmbfrs.Properties.DisplayMember = "Nomclt";
            this.cmbfrs.Properties.NullText = "";
            this.cmbfrs.Properties.PopupSizeable = false;
            this.cmbfrs.Properties.PopupView = this.gridLookUpEdit1View;
            this.cmbfrs.Properties.ValueMember = "Codeclt";
            this.cmbfrs.Size = new System.Drawing.Size(325, 20);
            this.cmbfrs.TabIndex = 58;
            // 
            // tclientBindingSource
            // 
            this.tclientBindingSource.DataMember = "Tclient";
            this.tclientBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodeclt,
            this.colNomclt,
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
            // colCodeclt
            // 
            this.colCodeclt.FieldName = "Codeclt";
            this.colCodeclt.Name = "colCodeclt";
            this.colCodeclt.Visible = true;
            this.colCodeclt.VisibleIndex = 4;
            // 
            // colNomclt
            // 
            this.colNomclt.FieldName = "Nomclt";
            this.colNomclt.Name = "colNomclt";
            this.colNomclt.Visible = true;
            this.colNomclt.VisibleIndex = 0;
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
            // 
            // colNif
            // 
            this.colNif.FieldName = "Nif";
            this.colNif.Name = "colNif";
            this.colNif.Visible = true;
            this.colNif.VisibleIndex = 1;
            // 
            // colTelephone1
            // 
            this.colTelephone1.FieldName = "Telephone1";
            this.colTelephone1.Name = "colTelephone1";
            this.colTelephone1.Visible = true;
            this.colTelephone1.VisibleIndex = 2;
            // 
            // colTelephone2
            // 
            this.colTelephone2.FieldName = "Telephone2";
            this.colTelephone2.Name = "colTelephone2";
            this.colTelephone2.Visible = true;
            this.colTelephone2.VisibleIndex = 3;
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
            // tclientTableAdapter
            // 
            this.tclientTableAdapter.ClearBeforeFill = true;
            // 
            // Frmfiltreretour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 133);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.cmbfrs);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Frmfiltreretour.IconOptions.Icon")));
            this.IconOptions.Image = global::suivibouteilles.Properties.Resources.icon5;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmfiltreretour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frmfiltreretour";
            this.Load += new System.EventHandler(this.Frmfiltreretour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbfrs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tclientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.GridLookUpEdit cmbfrs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeclt;
        private DevExpress.XtraGrid.Columns.GridColumn colNomclt;
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
        private Dataset.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tclientBindingSource;
        private Dataset.DataSet1TableAdapters.TclientTableAdapter tclientTableAdapter;
    }
}
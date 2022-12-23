namespace suivibouteilles.Frmrapports
{
    partial class Frmrapportclt
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btprint = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tclientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dateEdit2);
            this.panelControl1.Controls.Add(this.dateEdit1);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(338, 329);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btprint);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 282);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(334, 45);
            this.panelControl3.TabIndex = 1;
            // 
            // btprint
            // 
            this.btprint.Location = new System.Drawing.Point(121, 10);
            this.btprint.Name = "btprint";
            this.btprint.Size = new System.Drawing.Size(75, 23);
            this.btprint.TabIndex = 2;
            this.btprint.Text = "Imprimer";
            this.btprint.Click += new System.EventHandler(this.btprint_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.comboBoxEdit1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(334, 59);
            this.panelControl2.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Client :";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(57, 19);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.DataSource = this.tclientBindingSource;
            this.comboBoxEdit1.Properties.DisplayMember = "Nomclt";
            this.comboBoxEdit1.Properties.NullText = "";
            this.comboBoxEdit1.Properties.PopupSizeable = false;
            this.comboBoxEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.comboBoxEdit1.Properties.ValueMember = "Codeclt";
            this.comboBoxEdit1.Size = new System.Drawing.Size(270, 20);
            this.comboBoxEdit1.TabIndex = 2;
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
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(177, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 51;
            this.labelControl2.Text = "Au :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 13);
            this.labelControl3.TabIndex = 50;
            this.labelControl3.Text = "Du :";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(212, 79);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(114, 20);
            this.dateEdit2.TabIndex = 49;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(39, 79);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(113, 20);
            this.dateEdit1.TabIndex = 48;
            // 
            // Frmrapportclt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "Frmrapportclt";
            this.Size = new System.Drawing.Size(338, 329);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tclientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btprint;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource tclientBindingSource;
        private Dataset.DataSet1 dataSet1;
        private Dataset.DataSet1TableAdapters.TclientTableAdapter tclientTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit comboBoxEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
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
        private DevExpress.XtraGrid.Columns.GridColumn colCodeclt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
    }
}

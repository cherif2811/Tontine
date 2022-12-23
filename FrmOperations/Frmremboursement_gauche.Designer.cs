namespace suivibouteilles.FrmOperations
{
    partial class Frmremboursement_gauche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmremboursement_gauche));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Btupdate = new DevExpress.XtraEditors.SimpleButton();
            this.BTDel = new DevExpress.XtraEditors.SimpleButton();
            this.txtidarticle = new DevExpress.XtraEditors.TextEdit();
            this.Btok = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
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
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDtCreation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDtModification = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtidarticle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
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
            this.panelControl2.Location = new System.Drawing.Point(0, 402);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(459, 52);
            this.panelControl2.TabIndex = 5;
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
            this.Btupdate.Location = new System.Drawing.Point(138, 14);
            this.Btupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btupdate.Name = "Btupdate";
            this.Btupdate.Size = new System.Drawing.Size(64, 24);
            this.Btupdate.TabIndex = 10;
            this.Btupdate.Text = "&Modifier";
            this.Btupdate.Visible = false;
            // 
            // BTDel
            // 
            this.BTDel.Location = new System.Drawing.Point(208, 14);
            this.BTDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTDel.Name = "BTDel";
            this.BTDel.Size = new System.Drawing.Size(77, 24);
            this.BTDel.TabIndex = 11;
            this.BTDel.Text = "&Supprimer";
            this.BTDel.Visible = false;
            // 
            // txtidarticle
            // 
            this.txtidarticle.Enabled = false;
            this.txtidarticle.Location = new System.Drawing.Point(374, 16);
            this.txtidarticle.Name = "txtidarticle";
            this.txtidarticle.Size = new System.Drawing.Size(36, 20);
            this.txtidarticle.TabIndex = 19;
            this.txtidarticle.Visible = false;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(459, 402);
            this.panelControl1.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(455, 398);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            gridFormatRule1.Column = this.gridColumn2;
            gridFormatRule1.Name = "Format0";
            gridFormatRule1.Rule = null;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Présent";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
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
            // Frmremboursement_gauche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "Frmremboursement_gauche";
            this.Size = new System.Drawing.Size(459, 454);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtidarticle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtidarticle;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton Btupdate;
        private DevExpress.XtraEditors.SimpleButton Btok;
        private DevExpress.XtraEditors.SimpleButton BTDel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colDtCreation;
        private DevExpress.XtraGrid.Columns.GridColumn colDtModification;
    }
}

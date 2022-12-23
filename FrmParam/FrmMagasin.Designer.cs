namespace suivibouteilles.FrmParam
{
    partial class FrmMagasin
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tmagasinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new suivibouteilles.Dataset.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidmag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collibelle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.BtUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtSaveParametre = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tmagasinTableAdapter = new suivibouteilles.Dataset.DataSet1TableAdapters.TmagasinTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmagasinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tmagasinBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(465, 226);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tmagasinBindingSource
            // 
            this.tmagasinBindingSource.DataMember = "Tmagasin";
            this.tmagasinBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidmag,
            this.collibelle});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colidmag
            // 
            this.colidmag.FieldName = "idmag";
            this.colidmag.Name = "colidmag";
            this.colidmag.Visible = true;
            this.colidmag.VisibleIndex = 0;
            // 
            // collibelle
            // 
            this.collibelle.FieldName = "libelle";
            this.collibelle.Name = "collibelle";
            this.collibelle.Visible = true;
            this.collibelle.VisibleIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.BtUpdate);
            this.panelControl4.Controls.Add(this.BtSaveParametre);
            this.panelControl4.Controls.Add(this.labelControl2);
            this.panelControl4.Controls.Add(this.textEdit2);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(469, 56);
            this.panelControl4.TabIndex = 5;
            // 
            // BtUpdate
            // 
            this.BtUpdate.Location = new System.Drawing.Point(378, 21);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(65, 23);
            this.BtUpdate.TabIndex = 5;
            this.BtUpdate.Text = "Ok";
            this.BtUpdate.Visible = false;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // BtSaveParametre
            // 
            this.BtSaveParametre.Location = new System.Drawing.Point(378, 21);
            this.BtSaveParametre.Name = "BtSaveParametre";
            this.BtSaveParametre.Size = new System.Drawing.Size(65, 23);
            this.BtSaveParametre.TabIndex = 4;
            this.BtSaveParametre.Text = "Ok";
            this.BtSaveParametre.Click += new System.EventHandler(this.BtSaveParametre_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Libellé";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(54, 23);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(298, 20);
            this.textEdit2.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 56);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(469, 230);
            this.panelControl1.TabIndex = 6;
            // 
            // tmagasinTableAdapter
            // 
            this.tmagasinTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl4);
            this.Name = "FrmMagasin";
            this.Size = new System.Drawing.Size(469, 286);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmagasinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton BtUpdate;
        private DevExpress.XtraEditors.SimpleButton BtSaveParametre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource tmagasinBindingSource;
        private Dataset.DataSet1 dataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colidmag;
        private DevExpress.XtraGrid.Columns.GridColumn collibelle;
        private Dataset.DataSet1TableAdapters.TmagasinTableAdapter tmagasinTableAdapter;
    }
}

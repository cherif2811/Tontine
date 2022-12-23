namespace suivibouteilles.FrmParam
{
    partial class Frmcategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcategorie));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btdelete = new DevExpress.XtraEditors.SimpleButton();
            this.btupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tcategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new suivibouteilles.Dataset.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodeCat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesiCat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tcategorieTableAdapter = new suivibouteilles.Dataset.DataSet1TableAdapters.TcategorieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcategorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btdelete);
            this.panelControl1.Controls.Add(this.btupdate);
            this.panelControl1.Controls.Add(this.btOk);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(804, 62);
            this.panelControl1.TabIndex = 2;
            // 
            // btdelete
            // 
            this.btdelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.ImageOptions.Image")));
            this.btdelete.Location = new System.Drawing.Point(679, 20);
            this.btdelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 26);
            this.btdelete.TabIndex = 7;
            this.btdelete.Text = "&Supprimer";
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btupdate
            // 
            this.btupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btupdate.ImageOptions.Image")));
            this.btupdate.Location = new System.Drawing.Point(605, 20);
            this.btupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(68, 26);
            this.btupdate.TabIndex = 6;
            this.btupdate.Text = "&Valider";
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btOk
            // 
            this.btOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btOk.ImageOptions.Image")));
            this.btOk.Location = new System.Drawing.Point(531, 20);
            this.btOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(68, 26);
            this.btOk.TabIndex = 5;
            this.btOk.Text = "&Ajouter";
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(100, 22);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(267, 24);
            this.textEdit1.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 26);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 17);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Categorie :";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tcategorieBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 62);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(804, 348);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tcategorieBindingSource
            // 
            this.tcategorieBindingSource.DataMember = "Tcategorie";
            this.tcategorieBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodeCat,
            this.colDesiCat});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colCodeCat
            // 
            this.colCodeCat.Caption = "Code";
            this.colCodeCat.FieldName = "CodeCat";
            this.colCodeCat.Name = "colCodeCat";
            this.colCodeCat.Visible = true;
            this.colCodeCat.VisibleIndex = 0;
            // 
            // colDesiCat
            // 
            this.colDesiCat.Caption = "Categorie";
            this.colDesiCat.FieldName = "DesiCat";
            this.colDesiCat.Name = "colDesiCat";
            this.colDesiCat.Visible = true;
            this.colDesiCat.VisibleIndex = 1;
            // 
            // tcategorieTableAdapter
            // 
            this.tcategorieTableAdapter.ClearBeforeFill = true;
            // 
            // Frmcategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Frmcategorie";
            this.Size = new System.Drawing.Size(804, 410);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcategorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btdelete;
        private DevExpress.XtraEditors.SimpleButton btupdate;
        private DevExpress.XtraEditors.SimpleButton btOk;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tcategorieBindingSource;
        private Dataset.DataSet1 dataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeCat;
        private DevExpress.XtraGrid.Columns.GridColumn colDesiCat;
        private Dataset.DataSet1TableAdapters.TcategorieTableAdapter tcategorieTableAdapter;
    }
}

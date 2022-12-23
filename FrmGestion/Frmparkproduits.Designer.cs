namespace suivibouteilles.FrmGestion
{
    partial class Frmparkproduits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmparkproduits));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtmise = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btdelete = new DevExpress.XtraEditors.SimpleButton();
            this.btupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataSet1 = new suivibouteilles.Dataset.DataSet1();
            this.tmiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tmiseTableAdapter = new suivibouteilles.Dataset.DataSet1TableAdapters.TmiseTableAdapter();
            this.colmise = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmise.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmiseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtmise);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btdelete);
            this.panelControl1.Controls.Add(this.btupdate);
            this.panelControl1.Controls.Add(this.btOk);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(913, 62);
            this.panelControl1.TabIndex = 3;
            // 
            // txtmise
            // 
            this.txtmise.Location = new System.Drawing.Point(101, 19);
            this.txtmise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmise.Name = "txtmise";
            this.txtmise.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmise.Properties.Appearance.Options.UseFont = true;
            this.txtmise.Size = new System.Drawing.Size(228, 24);
            this.txtmise.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(36, 22);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 17);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Mise :";
            // 
            // btdelete
            // 
            this.btdelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.ImageOptions.Image")));
            this.btdelete.Location = new System.Drawing.Point(771, 22);
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
            this.btupdate.Location = new System.Drawing.Point(688, 23);
            this.btupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(68, 26);
            this.btupdate.TabIndex = 6;
            this.btupdate.Text = "&Modifier";
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btOk
            // 
            this.btOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btOk.ImageOptions.Image")));
            this.btOk.Location = new System.Drawing.Point(614, 23);
            this.btOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(68, 26);
            this.btOk.TabIndex = 5;
            this.btOk.Text = "&Ajouter";
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tmiseBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 62);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(913, 232);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmise,
            this.colid});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tmiseBindingSource
            // 
            this.tmiseBindingSource.DataMember = "Tmise";
            this.tmiseBindingSource.DataSource = this.dataSet1;
            // 
            // tmiseTableAdapter
            // 
            this.tmiseTableAdapter.ClearBeforeFill = true;
            // 
            // colmise
            // 
            this.colmise.FieldName = "mise";
            this.colmise.Name = "colmise";
            this.colmise.Visible = true;
            this.colmise.VisibleIndex = 1;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // Frmparkproduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Frmparkproduits";
            this.Size = new System.Drawing.Size(913, 294);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmise.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmiseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtmise;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btdelete;
        private DevExpress.XtraEditors.SimpleButton btupdate;
        private DevExpress.XtraEditors.SimpleButton btOk;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tmiseBindingSource;
        private Dataset.DataSet1 dataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colmise;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private Dataset.DataSet1TableAdapters.TmiseTableAdapter tmiseTableAdapter;
    }
}

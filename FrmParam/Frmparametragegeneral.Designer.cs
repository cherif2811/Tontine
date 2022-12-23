namespace suivibouteilles.FrmParam
{
    partial class Frmparametragegeneral
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
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.BtUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtSaveParametre = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataSet1 = new suivibouteilles.Dataset.DataSet1();
            this.tparamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tparamTableAdapter = new suivibouteilles.Dataset.DataSet1TableAdapters.TparamTableAdapter();
            this.colNumParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLibParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValeur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidusers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatecreat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatemodif = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tparamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.BtUpdate);
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Controls.Add(this.BtSaveParametre);
            this.panelControl4.Controls.Add(this.labelControl2);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Controls.Add(this.textEdit3);
            this.panelControl4.Controls.Add(this.textEdit2);
            this.panelControl4.Controls.Add(this.textEdit1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(0, 206);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(478, 68);
            this.panelControl4.TabIndex = 2;
            // 
            // BtUpdate
            // 
            this.BtUpdate.Location = new System.Drawing.Point(381, 27);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(65, 23);
            this.BtUpdate.TabIndex = 5;
            this.BtUpdate.Text = "Ok";
            this.BtUpdate.Visible = false;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(289, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Valeur";
            // 
            // BtSaveParametre
            // 
            this.BtSaveParametre.Location = new System.Drawing.Point(381, 27);
            this.BtSaveParametre.Name = "BtSaveParametre";
            this.BtSaveParametre.Size = new System.Drawing.Size(65, 23);
            this.BtSaveParametre.TabIndex = 4;
            this.BtSaveParametre.Text = "Ok";
            this.BtSaveParametre.Click += new System.EventHandler(this.BtSaveParametre_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(120, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Libellé";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "NumParam";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(267, 30);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(98, 20);
            this.textEdit3.TabIndex = 3;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(86, 30);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(175, 20);
            this.textEdit2.TabIndex = 2;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(5, 30);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(63, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tparamBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(478, 206);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumParam,
            this.colLibParam,
            this.colValeur,
            this.colidusers,
            this.colusers,
            this.colDatecreat,
            this.colDatemodif});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tparamBindingSource
            // 
            this.tparamBindingSource.DataMember = "Tparam";
            this.tparamBindingSource.DataSource = this.dataSet1;
            // 
            // tparamTableAdapter
            // 
            this.tparamTableAdapter.ClearBeforeFill = true;
            // 
            // colNumParam
            // 
            this.colNumParam.FieldName = "NumParam";
            this.colNumParam.Name = "colNumParam";
            this.colNumParam.Visible = true;
            this.colNumParam.VisibleIndex = 0;
            // 
            // colLibParam
            // 
            this.colLibParam.FieldName = "LibParam";
            this.colLibParam.Name = "colLibParam";
            this.colLibParam.Visible = true;
            this.colLibParam.VisibleIndex = 1;
            // 
            // colValeur
            // 
            this.colValeur.FieldName = "Valeur";
            this.colValeur.Name = "colValeur";
            this.colValeur.Visible = true;
            this.colValeur.VisibleIndex = 2;
            // 
            // colidusers
            // 
            this.colidusers.FieldName = "idusers";
            this.colidusers.Name = "colidusers";
            // 
            // colusers
            // 
            this.colusers.FieldName = "users";
            this.colusers.Name = "colusers";
            // 
            // colDatecreat
            // 
            this.colDatecreat.FieldName = "Datecreat";
            this.colDatecreat.Name = "colDatecreat";
            // 
            // colDatemodif
            // 
            this.colDatemodif.FieldName = "Datemodif";
            this.colDatemodif.Name = "colDatemodif";
            // 
            // Frmparametragegeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl4);
            this.Name = "Frmparametragegeneral";
            this.Size = new System.Drawing.Size(478, 274);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tparamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton BtUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtSaveParametre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tparamBindingSource;
        private Dataset.DataSet1 dataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumParam;
        private DevExpress.XtraGrid.Columns.GridColumn colLibParam;
        private DevExpress.XtraGrid.Columns.GridColumn colValeur;
        private DevExpress.XtraGrid.Columns.GridColumn colidusers;
        private DevExpress.XtraGrid.Columns.GridColumn colusers;
        private DevExpress.XtraGrid.Columns.GridColumn colDatecreat;
        private DevExpress.XtraGrid.Columns.GridColumn colDatemodif;
        private Dataset.DataSet1TableAdapters.TparamTableAdapter tparamTableAdapter;
        //private suivibouteilles.DataTableAdapters.TparamTableAdapter tparamTableAdapter;
    }
}

namespace suivibouteilles.FrmEdition
{
    partial class Frmbenefice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbenefice));
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txtcodepark = new DevExpress.XtraEditors.TextEdit();
            this.cmbparkproduit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.btimprimer = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodepark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbparkproduit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btimprimer);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 202);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(341, 47);
            this.panelControl3.TabIndex = 5;
            // 
            // txtcodepark
            // 
            this.txtcodepark.Location = new System.Drawing.Point(64, 150);
            this.txtcodepark.Name = "txtcodepark";
            this.txtcodepark.Size = new System.Drawing.Size(81, 20);
            this.txtcodepark.TabIndex = 42;
            this.txtcodepark.Visible = false;
            // 
            // cmbparkproduit
            // 
            this.cmbparkproduit.Location = new System.Drawing.Point(104, 23);
            this.cmbparkproduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbparkproduit.Name = "cmbparkproduit";
            this.cmbparkproduit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbparkproduit.Properties.Appearance.Options.UseFont = true;
            this.cmbparkproduit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbparkproduit.Size = new System.Drawing.Size(188, 24);
            this.cmbparkproduit.TabIndex = 41;
            this.cmbparkproduit.SelectedIndexChanged += new System.EventHandler(this.cmbparkproduit_SelectedIndexChanged);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(206, 86);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(100, 20);
            this.dateEdit2.TabIndex = 7;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(62, 86);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 6;
            // 
            // btimprimer
            // 
            this.btimprimer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btimprimer.ImageOptions.Image")));
            this.btimprimer.Location = new System.Drawing.Point(5, 13);
            this.btimprimer.Name = "btimprimer";
            this.btimprimer.Size = new System.Drawing.Size(75, 23);
            this.btimprimer.TabIndex = 0;
            this.btimprimer.Text = "Imprimer";
            this.btimprimer.Click += new System.EventHandler(this.btimprimer_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(56, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Articles :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 13);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "Du :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(180, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 46;
            this.labelControl2.Text = "Au :";
            // 
            // Frmbenefice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtcodepark);
            this.Controls.Add(this.cmbparkproduit);
            this.Controls.Add(this.dateEdit2);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.panelControl3);
            this.Name = "Frmbenefice";
            this.Size = new System.Drawing.Size(341, 249);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtcodepark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbparkproduit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btimprimer;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbparkproduit;
        private DevExpress.XtraEditors.TextEdit txtcodepark;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}

namespace suivibouteilles.FrmEdition
{
    partial class Frmliste_parc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmliste_parc));
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btimprimer = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtidmise = new DevExpress.XtraEditors.TextEdit();
            this.cmbparkproduit = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtidmise.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbparkproduit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btimprimer);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 225);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(270, 47);
            this.panelControl3.TabIndex = 4;
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
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 19);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Filtre / mises :";
            // 
            // txtidmise
            // 
            this.txtidmise.Enabled = false;
            this.txtidmise.Location = new System.Drawing.Point(142, 81);
            this.txtidmise.Name = "txtidmise";
            this.txtidmise.Size = new System.Drawing.Size(67, 20);
            this.txtidmise.TabIndex = 7;
            this.txtidmise.Visible = false;
            // 
            // cmbparkproduit
            // 
            this.cmbparkproduit.Location = new System.Drawing.Point(117, 31);
            this.cmbparkproduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbparkproduit.Name = "cmbparkproduit";
            this.cmbparkproduit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbparkproduit.Properties.Appearance.Options.UseFont = true;
            this.cmbparkproduit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbparkproduit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbparkproduit.Size = new System.Drawing.Size(133, 24);
            this.cmbparkproduit.TabIndex = 41;
            this.cmbparkproduit.SelectedIndexChanged += new System.EventHandler(this.cmbparkproduit_SelectedIndexChanged);
            // 
            // Frmliste_parc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbparkproduit);
            this.Controls.Add(this.txtidmise);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl3);
            this.Name = "Frmliste_parc";
            this.Size = new System.Drawing.Size(270, 272);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtidmise.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbparkproduit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btimprimer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtidmise;
        private DevExpress.XtraEditors.ComboBoxEdit cmbparkproduit;
    }
}

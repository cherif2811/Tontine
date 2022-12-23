namespace suivibouteilles.FrmEdition
{
    partial class Frm_etat_de_stocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_etat_de_stocks));
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btimprimer = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btimprimer);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 336);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(350, 47);
            this.panelControl3.TabIndex = 5;
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
            // Frm_etat_de_stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Name = "Frm_etat_de_stocks";
            this.Size = new System.Drawing.Size(350, 383);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btimprimer;
    }
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class xtralistefournisseur : DevExpress.XtraReports.UI.XtraReport
    {
        public xtralistefournisseur()
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tfournisseurTableAdapter1.Fill(dataSetEtat1.Tfournisseur);
        }

    }
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class liste_collecteur : DevExpress.XtraReports.UI.XtraReport
    {
        public liste_collecteur()
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tcollecteurTableAdapter1.Fill(dataSetEtat1.Tcollecteur);
          
        }

    }
}

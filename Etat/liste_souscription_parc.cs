using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class liste_souscription_parc : DevExpress.XtraReports.UI.XtraReport
    {
        public liste_souscription_parc()
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_liste_souscription_parcTableAdapter1.Fill(dataSetEtat1.tmp_liste_souscription_parc);
        }

    }
}

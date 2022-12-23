using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class liste_tontine_par_zone : DevExpress.XtraReports.UI.XtraReport
    {
        public liste_tontine_par_zone(string codeclt, DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_liste_cotisation_tontine_zoneTableAdapter1.Fill(dataSetEtat1.tmp_liste_cotisation_tontine_zone,codeclt, Convert.ToDateTime(date1), Convert.ToDateTime(date2));
        }

    }
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class Situation_tontine_par_collecteur : DevExpress.XtraReports.UI.XtraReport
    {
        public Situation_tontine_par_collecteur(string  codecol, DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.tmp_liste_cotisation_tontine_collecteurTableAdapter1.Fill(dataSetEtat1.tmp_liste_cotisation_tontine_collecteur,codecol, Convert.ToDateTime(date1), Convert.ToDateTime(date2));
        }

    }
}

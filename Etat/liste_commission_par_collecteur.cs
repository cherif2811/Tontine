using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class liste_commission_par_collecteur : DevExpress.XtraReports.UI.XtraReport
    {
        public liste_commission_par_collecteur(int codecol,DateTime date1,DateTime date2)
        {
            InitializeComponent();
            this.tmp_grid_commission_par_collecteurTableAdapter1.Fill(dataSetEtat1.tmp_grid_commission_par_collecteur, codecol, date1, date2);

        }

    }
}

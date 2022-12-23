using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class liste_des_ventes_tontine_simple : DevExpress.XtraReports.UI.XtraReport
    {
        public liste_des_ventes_tontine_simple(DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_liste_vente_tontine_simpleTableAdapter1.Fill(dataSetEtat1.tmp_liste_vente_tontine_simple, Convert.ToDateTime(date1), Convert.ToDateTime(date2));
        }

    }
}

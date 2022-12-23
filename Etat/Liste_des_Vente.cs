using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class Liste_des_Vente : DevExpress.XtraReports.UI.XtraReport
    {
        public Liste_des_Vente(DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_liste_vente_tontineTableAdapter1.Fill(dataSetEtat1.tmp_liste_vente_tontine, Convert.ToDateTime(date1), Convert.ToDateTime(date2));
        }

    }
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class listing_commission_toute : DevExpress.XtraReports.UI.XtraReport
    {
        public listing_commission_toute(DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.tmp_liste_commission_touteTableAdapter1.Fill(dataSetEtat1.tmp_liste_commission_toute, Convert.ToDateTime(date1), Convert.ToDateTime(date2));
        }

    }
}

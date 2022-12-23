using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class Situation_des_cotisation_des_parcs : DevExpress.XtraReports.UI.XtraReport
    {
        public Situation_des_cotisation_des_parcs(DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.tmp_situation_tontine_touteTableAdapter1.Fill(dataSetEtat1.tmp_situation_tontine_toute, Convert.ToDateTime(date1), Convert.ToDateTime(date2));
        }

    }
}

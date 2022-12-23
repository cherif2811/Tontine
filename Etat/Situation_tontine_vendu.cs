using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class Situation_tontine_vendu : DevExpress.XtraReports.UI.XtraReport
    {
        public Situation_tontine_vendu(DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.tmp_situation_tontine_venduTableAdapter1.Fill(dataSetEtat1.tmp_situation_tontine_vendu, Convert.ToDateTime(date1), Convert.ToDateTime(date2));

        }

    }
}

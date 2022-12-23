using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class xtracompteclient : DevExpress.XtraReports.UI.XtraReport
    {
        public xtracompteclient(int codeclt,DateTime date1,DateTime date2)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_recapclientarticlesTableAdapter1.Fill(dataSetEtat1.tmp_recapclientarticles, codeclt, date1, date2);
            this.tmp_compteclientqteretourTableAdapter.Fill(dataSetEtat1.tmp_compteclientqteretour, codeclt, date1, date2);
            //this.tmp_compteclientTableAdapter.Fill(dataSetEtat1.tmp_compteclient, codeclt, date1, date2);
            // this.tmp_compteclientqtelivreeTableAdapter.Fill(dataSetEtat1.tmp_compteclientqtelivree, codeclt);
        }

    }
}

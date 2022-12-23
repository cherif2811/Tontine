using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class xtraJournalRetourClient : DevExpress.XtraReports.UI.XtraReport
    {
        public xtraJournalRetourClient(int Codeclt,DateTime date1,DateTime date2)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_journalclientRetourClientTableAdapter1.Fill(dataSetEtat1.tmp_journalclientRetourClient, Codeclt, date1, date2);
        }

    }
}

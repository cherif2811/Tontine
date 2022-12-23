using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class xtraJournalBonSortieClient : DevExpress.XtraReports.UI.XtraReport
    {
        public xtraJournalBonSortieClient(int Codeclt, DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_journalclientbonsortieClientTableAdapter1.Fill(dataSetEtat1.tmp_journalclientbonsortieClient,Codeclt,date1,date2);
        }

    }
}

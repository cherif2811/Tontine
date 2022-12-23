using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class xtraJournalBonSortie : DevExpress.XtraReports.UI.XtraReport
    {
        public xtraJournalBonSortie(DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_journalclientbonsortieTableAdapter1.Fill(dataSetEtat1.tmp_journalclientbonsortie, date1, date2);
        }

    }
}

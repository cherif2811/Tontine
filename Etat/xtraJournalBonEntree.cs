using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class xtraJournalBonEntree : DevExpress.XtraReports.UI.XtraReport
    {
        public xtraJournalBonEntree(DateTime date1,DateTime date2)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_journalfournisseurdesbonentreeTableAdapter1.Fill(dataSetEtat1.tmp_journalfournisseurdesbonentree, date1, date2);
        }

    }
}

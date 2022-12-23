using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class xtraJournalBonEntreeFrs : DevExpress.XtraReports.UI.XtraReport
    {
        public xtraJournalBonEntreeFrs(int codefrs, DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_journalfournisseurdesbonentreeFournisseurTableAdapter1.Fill(dataSetEtat1.tmp_journalfournisseurdesbonentreeFournisseur, codefrs, date1, date2);
        }

    }
}

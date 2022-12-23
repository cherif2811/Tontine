using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class liste_benefice : DevExpress.XtraReports.UI.XtraReport
    {
        public liste_benefice(DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_beneficeTableAdapter1.Fill(dataSetEtat1.tmp_benefice,date1,date2);
        }

    }
}

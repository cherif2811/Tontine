using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class xtraBonEntree : DevExpress.XtraReports.UI.XtraReport
    {
        public xtraBonEntree(int Codefrs,string Numfact)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmpListeBonEntreeTableAdapter.Fill(dataSetEtat1.tmpListeBonEntree, Codefrs, Numfact);
        }

    }
}

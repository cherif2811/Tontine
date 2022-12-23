using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class Situation_tontine_solde_zero : DevExpress.XtraReports.UI.XtraReport
    {
        public Situation_tontine_solde_zero()
        {
            InitializeComponent();
            this.tmp_solde_tontineTableAdapter1.Fill(dataSetEtat1.tmp_solde_tontine);

        }

    }
}

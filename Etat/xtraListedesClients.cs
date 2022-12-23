using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class xtraListedesClients : DevExpress.XtraReports.UI.XtraReport
    {
        public xtraListedesClients()
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tclientTableAdapter1.Fill(dataSetEtat1.Tclient);
        }

    }
}

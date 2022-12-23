using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class xtrBonSortie : DevExpress.XtraReports.UI.XtraReport
    {
        public xtrBonSortie(int Codefrs, string Numfact)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmpListeBonSortieTableAdapter1.Fill(dataSetEtat1.tmpListeBonSortie, Codefrs,Numfact);
            this.tmpListeBonSortieClientsTableAdapter1.Fill(dataSetEtat1.tmpListeBonSortieClients, Codefrs, Numfact);
        }

    }
}

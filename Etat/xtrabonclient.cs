using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class xtrabonclient : DevExpress.XtraReports.UI.XtraReport
    {
        public xtrabonclient(int Codeclt,string Numfact)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_cumulqtelivreeclientTableAdapter1.Fill(dataSetEtat1.tmp_cumulqtelivreeclient, Codeclt, Numfact);
            this.tmp_cumulqteretourclientTableAdapter.Fill(dataSetEtat1.tmp_cumulqteretourclient, Codeclt, Numfact);
            this.tmp_infoclientcumullivreretourTableAdapter1.Fill(dataSetEtat1.tmp_infoclientcumullivreretour, Codeclt, Numfact);
            this.tmp_recaplivreeTableAdapter.Fill(dataSetEtat1.tmp_recaplivree, Codeclt, Numfact);
            this.tmp_recapretourTableAdapter.Fill(dataSetEtat1.tmp_recapretour, Codeclt, Numfact);
            // this.tmp_sommecumullivreretourTableAdapter1.Fill(dataSetEtat1.tmp_sommecumullivreretour, Codeclt, Numfact);
            // this.tmp_cumulqtelivreeclientTableAdapter1.Fill(dataSetEtat1.tmp_cumulqtelivreeclientCodeclt, Codeclt, Numfact);
        }

    }
}

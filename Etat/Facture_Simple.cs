using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class Facture_Simple : DevExpress.XtraReports.UI.XtraReport
    {
        public Facture_Simple(string _codeclt, string _numfact)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_facture_SimpleTableAdapter1.Fill(dataSetEtat1.tmp_facture_Simple,_codeclt,_numfact);
        }

    }
}

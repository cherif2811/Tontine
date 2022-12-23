using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class Facture_tontine : DevExpress.XtraReports.UI.XtraReport
    {
        public Facture_tontine(string _codeclt,string _numfact)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_facture_tontineTableAdapter1.Fill(dataSetEtat1.tmp_facture_tontine,_codeclt,_numfact);


                }

    }
}

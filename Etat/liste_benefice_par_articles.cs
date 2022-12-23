using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class liste_benefice_par_articles : DevExpress.XtraReports.UI.XtraReport
    {
        public liste_benefice_par_articles(DateTime date1, DateTime date2,string _codearticle)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_benefice_par_articleTableAdapter1.Fill(dataSetEtat1.tmp_benefice_par_article, date1, date2,_codearticle);

        }

    }
}

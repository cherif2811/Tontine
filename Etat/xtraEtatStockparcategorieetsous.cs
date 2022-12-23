using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class xtraEtatStockparcategorieetsous : DevExpress.XtraReports.UI.XtraReport
    {
        public xtraEtatStockparcategorieetsous(int CodeCat,int Codesous)
        {
            InitializeComponent();
            this.tsocieteTableAdapter1.Fill(dataSetEtat1.Tsociete);
            this.tmp_etatstockcateetsouscategTableAdapter1.Fill(dataSetEtat1.tmp_etatstockcateetsouscateg, CodeCat, Codesous);
        }

    }
}

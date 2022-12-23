using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class liste_souscription_client_par_pack : DevExpress.XtraReports.UI.XtraReport
    {
        public liste_souscription_client_par_pack(int codepack)
        {
            InitializeComponent();
            this.tmp_liste_souscription_client_par_packTableAdapter1.Fill(dataSetEtat1.tmp_liste_souscription_client_par_pack, codepack);
        }

    }
}

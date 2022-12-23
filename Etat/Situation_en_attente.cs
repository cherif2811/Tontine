using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace suivibouteilles.Etat
{
    public partial class Situation_en_attente : DevExpress.XtraReports.UI.XtraReport
    {
        public Situation_en_attente(DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.tmp_situation_tontine_enattenteTableAdapter1.Fill(dataSetEtat1.tmp_situation_tontine_enattente, Convert.ToDateTime(date1), Convert.ToDateTime(date2));
        }

    }
}

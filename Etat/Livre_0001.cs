using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace suivibouteilles.Etat
{
    public partial class Livre_0001 : DevExpress.XtraReports.UI.XtraReport
    {
        FrmEdition.Frm_livre_operations menu;
        public Livre_0001(FrmEdition.Frm_livre_operations en)
        {
            InitializeComponent();
            menu = en;
            this.tmp_livre_depot01TableAdapter.Fill(dataSetEtat1.tmp_livre_depot01, menu.cmbannee.Text);
            this.tmp_livre_retraitTableAdapter.Fill(dataSetEtat1.tmp_livre_retrait, menu.cmbannee.Text);
            this.tmp_client_pretTableAdapter.Fill(dataSetEtat1.tmp_client_pret, menu.cmbannee.Text);
            this.total_solde_operationsTableAdapter1.Fill(dataSetEtat1.Total_solde_operations, menu.cmbannee.Text);
        }

    }
}

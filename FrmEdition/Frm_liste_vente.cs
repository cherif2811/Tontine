using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace suivibouteilles.FrmEdition
{
    public partial class Frm_liste_vente : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMenu.Menu menu;
        public Frm_liste_vente(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
        }

        private void btimprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dateEdit1.Text))
            {
                XtraMessageBox.Show("veuillez choisir une date", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dateEdit1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dateEdit2.Text))
            {
                XtraMessageBox.Show("veuillez choisir une date", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dateEdit1.Focus();
                return;
            }
            if (cmbtypeclt.Text == "Tontine")
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.Liste_des_Vente etat = new Etat.Liste_des_Vente(Convert.ToDateTime(dateEdit1.Text), Convert.ToDateTime(dateEdit2.Text));
                menu.AddTabControldroit(frm, "Liste des vente de tontine" + ""+ " Du: " + dateEdit1.Text + " Au: " +dateEdit2.Text, "icons8_Grid.ico");
                //etat.Parameters["date1"].Value = dateEdit1.Text;
                //etat.Parameters["date2"].Value = dateEdit2.Text;
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
            if (cmbtypeclt.Text == "Simple")
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.liste_des_ventes_simple etat = new Etat.liste_des_ventes_simple(Convert.ToDateTime(dateEdit1.Text), Convert.ToDateTime(dateEdit2.Text));
                menu.AddTabControldroit(frm, "Liste des ventes simple" + "" + " Du: " + dateEdit1.Text + " Au: " + dateEdit2.Text, "icons8_Grid.ico");
                //etat.Parameters["date1"].Value = dateEdit1.Text;
                //etat.Parameters["date2"].Value = dateEdit2.Text;
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
            if (cmbtypeclt.Text == "Tous")
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.liste_des_ventes_tontine_simple etat = new Etat.liste_des_ventes_tontine_simple(Convert.ToDateTime(dateEdit1.Text), Convert.ToDateTime(dateEdit2.Text));
                menu.AddTabControldroit(frm, "Liste des ventes" + "" + " Du: " + dateEdit1.Text + " Au: " + dateEdit2.Text, "icons8_Grid.ico");
                //etat.Parameters["date1"].Value = dateEdit1.Text;
                //etat.Parameters["date2"].Value = dateEdit2.Text;
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
        }

        private void cmbtypeclt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Frmliste_cotisation_fin : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMenu.Menu menu;
        public Frmliste_cotisation_fin(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
        }

        private void btimprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbtypeclt.Text))
            {
                XtraMessageBox.Show("veuillez choisir une option de filtre", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbtypeclt.Focus();
                return;
            }

                if (string.IsNullOrEmpty(dateEdit1.Text))
            {
                XtraMessageBox.Show("veuillez choisir une date", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dateEdit1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dateEdit2.Text))
            {
                XtraMessageBox.Show("veuillez choisir une date", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dateEdit2.Focus();
                return;
            }
            if (cmbtypeclt.Text == "Toute")
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.Situation_des_cotisation_des_parcs etat = new Etat.Situation_des_cotisation_des_parcs(Convert.ToDateTime(dateEdit1.Text), Convert.ToDateTime(dateEdit2.Text));
                menu.AddTabControldroit(frm, "Situation des pack en operation" + "" + " Du: " + dateEdit1.Text + " Au: " + dateEdit2.Text, "icons8_Grid.ico");
                etat.Parameters["date1"].Value = dateEdit1.Text;
                etat.Parameters["date2"].Value = dateEdit2.Text;
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
            if (cmbtypeclt.Text == "En attente")
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.Situation_en_attente etat = new Etat.Situation_en_attente(Convert.ToDateTime(dateEdit1.Text), Convert.ToDateTime(dateEdit2.Text));
                menu.AddTabControldroit(frm, "Situation des pack En attente" + "" + " Du: " + dateEdit1.Text + " Au: " + dateEdit2.Text, "icons8_Grid.ico");
                etat.Parameters["date1"].Value = dateEdit1.Text;
                etat.Parameters["date2"].Value = dateEdit2.Text;
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
            if (cmbtypeclt.Text == "Vendu")
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.Situation_tontine_vendu etat = new Etat.Situation_tontine_vendu(Convert.ToDateTime(dateEdit1.Text), Convert.ToDateTime(dateEdit2.Text));
                menu.AddTabControldroit(frm, "Situation des pack Vendues" + "" + " Du: " + dateEdit1.Text + " Au: " + dateEdit2.Text, "icons8_Grid.ico");
                etat.Parameters["date1"].Value = dateEdit1.Text;
                etat.Parameters["date2"].Value = dateEdit2.Text;
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
            //if (cmbtypeclt.Text == "Solder")
            //{
            //    this.Cursor = Cursors.WaitCursor;
            //    FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
            //    Etat.Situation_tontine_solde_zero etat = new Etat.Situation_tontine_solde_zero(Convert.ToDateTime(dateEdit1.Text), Convert.ToDateTime(dateEdit2.Text));
            //    menu.AddTabControldroit(frm, "Situation tontine solder" + "" + " Du: " + dateEdit1.Text + " Au: " + dateEdit2.Text, "icons8_Grid.ico");
            //    etat.Parameters["date1"].Value = dateEdit1.Text;
            //    etat.Parameters["date2"].Value = dateEdit2.Text;
            //    frm.Dock = DockStyle.Fill;
            //    frm.documentViewer1.DocumentSource = etat;
            //    etat.CreateDocument();
            //    this.Cursor = Cursors.Default;
            //}
        }

        private void cmbtypeclt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }


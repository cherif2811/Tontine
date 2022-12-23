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
using suivibouteilles.Classes;

namespace suivibouteilles.Frmrapports
{
    public partial class FrmJournalBonSortie : DevExpress.XtraEditors.XtraUserControl
    {
        int _idrecherche, i = 0;
        FrmMenu.Menu me;
        public string _nomclt;
        public FrmJournalBonSortie(FrmMenu.Menu en)
        {
            InitializeComponent();
            me = en;
        }
        private void Verification_client()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT  COUNT(Codeclt) as ligne FROM TMvmtSortie WHERE Codeclt='" + txtcodeclt.Text + "' AND Dates BETWEEN'" + dateEdit1.EditValue + "'AND '" + dateEdit2.EditValue + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    _idrecherche = connexion.dr.GetInt32(0);
                }
                connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btprint_Click(object sender, EventArgs e)
        {
            if (dateEdit1.Text.Equals(""))
            {
                XtraMessageBox.Show("veuillez choisir une date", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dateEdit1.Focus();
                return;
            }
            if (dateEdit2.Text.Equals(""))
            {
                XtraMessageBox.Show("veuillez choisir une date", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dateEdit2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtcodeclt.Text))
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.xtraJournalBonSortie etat = new Etat.xtraJournalBonSortie(Convert.ToDateTime(dateEdit1.Text), Convert.ToDateTime(dateEdit2.Text));
                me.AddTabControldroit(frm, "Journal des Bons Sorties ", "icons8_Grid.ico");
                etat.Parameters["date1"].Value = dateEdit1.Text.Substring(0, 10);
                etat.Parameters["date2"].Value = dateEdit2.Text.Substring(0, 10);
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
            else
            {
                Verification_client();
                if (_idrecherche > i)
                {
                    this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.xtraJournalBonSortieClient etat = new Etat.xtraJournalBonSortieClient(Convert.ToInt32(txtcodeclt.Text), Convert.ToDateTime(dateEdit1.Text), Convert.ToDateTime(dateEdit2.Text));
                me.AddTabControldroit(frm, "Journal des Bons Sorties " + _nomclt + "" + dateEdit1.Text.Substring(0, 10) + " AU " + dateEdit2.Text.Substring(0, 10) + "", "icons8_Grid.ico");
                etat.Parameters["date1"].Value = dateEdit1.Text.Substring(0, 10);
                etat.Parameters["date2"].Value = dateEdit2.Text.Substring(0, 10);
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
                else
                {
                    XtraMessageBox.Show("Le Client :" + _nomclt + " n'a effectué aucune opération entre les dates selectionnée" + " ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmFiltre.FrmFiltreclt frm = new FrmFiltre.FrmFiltreclt(this);
            frm.ShowDialog();
        }
    }
    }


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
    public partial class Frmrapportclt : DevExpress.XtraEditors.XtraUserControl
    {
        int _Codeclt, _idrecherche, i = 0;
        string _nomclient;
        FrmMenu.Menu me;
        public Frmrapportclt(FrmMenu.Menu en)
        {

            InitializeComponent();
            me = en;
            this.tclientTableAdapter.Fill(dataSet1.Tclient);
        }

        private void comboBoxEdit1_Properties_Click(object sender, EventArgs e)
        {

        }

        private void gridLookUpEdit1View_Click(object sender, EventArgs e)
        {
            if (gridLookUpEdit1View.SelectedRowsCount == 1)
            {
                _Codeclt = Convert.ToInt32(gridLookUpEdit1View.GetFocusedRowCellValue("Codeclt").ToString());
                _nomclient = gridLookUpEdit1View.GetFocusedRowCellValue("Nomclt").ToString();

            }
        }
        private void Verification_client()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT count(Codeclt) as ligne From TMvmtSortie WHERE Codeclt='" + _Codeclt + "'");
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
            else
            {
                Verification_client();
                if (_idrecherche > i)
                {
                    this.Cursor = Cursors.WaitCursor;
                    FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                    Etat.xtracompteclient etat = new Etat.xtracompteclient(_Codeclt, Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit2.EditValue));
                    me.AddTabControldroit(frm, "Compte Client " + _Codeclt + "" + _nomclient + "Du " + dateEdit1.EditValue + " Au " + dateEdit2.EditValue + "", "icons8_Grid.ico");
                    etat.Parameters["date1"].Value = dateEdit1.Text.Substring(0, 10);
                    etat.Parameters["date2"].Value = dateEdit2.Text.Substring(0, 10);
                    frm.Dock = DockStyle.Fill;
                    frm.documentViewer1.DocumentSource = etat;
                    etat.CreateDocument();
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    XtraMessageBox.Show("Le client selectionner n'affectué aucune opération :" + " ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    // cmbclasse.Focus();
                    return;
                }
            }
        }
    }
}

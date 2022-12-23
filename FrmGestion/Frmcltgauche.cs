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
using DevExpress.XtraTab;
using suivibouteilles.FrmMenu;
using suivibouteilles.Classes;

namespace suivibouteilles.FrmGestion
{
    public partial class Frmcltgauche : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMenu.Menu menu;
        public int _iduser, _idreche, _idreche2, i = 0;
        string _Nomclt, _Codeclt;
        public Frmcltgauche(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
     
            //btn ajouter
            if (menu._btnajoutclient == "True")
            {
                Btok.Enabled = true;
            }
            if (menu._btnajoutclient == "False")
            {
                Btok.Enabled = false;
            }
            //btn update
            if (menu._btnupdateclient == "True")
            {
                Btupdate.Enabled = true;
            }
            if (menu._btnupdateclient == "False")
            {
                Btupdate.Enabled = false;
            }
            //btn Delete
            if (menu._btndeletclient == "True")
            {
                BTDel.Enabled = true;
            }
            if (menu._btndeletclient == "False")
            {
                BTDel.Enabled = false;
            }
            //btn print
            if (menu._btnlisteclient == "True")
            {
                btnliste.Enabled = true;
            }
            if (menu._btnlisteclient == "False")
            {
                btnliste.Enabled = false;
            }
            _iduser = Convert.ToInt32(menu._iduser);
            Displaygrid();
        }
        public void Displaygrid()
        {
            this.tgridclient_collecteur_zoneTableAdapter.Fill(dataSet1.Tgridclient_collecteur_zone);
        }
        //selection 1ere ligne
        private void selectionpermiereligne()
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                _Codeclt = gridView1.GetFocusedRowCellValue("codeclt").ToString();
                txtidclt.Text = _Codeclt.ToString();
                _Nomclt = gridView1.GetFocusedRowCellValue("nomclt").ToString();
                Verification_client();
                Verification_client_affectation();
            }
        }
        //fonction selectionne
        private void selection()
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                FrmGestion.Frmcltdrt frmpa = new FrmGestion.Frmcltdrt(this);
                XtraTabPage xtraTabPage = new XtraTabPage();
                menu.AddTabControldroit(frmpa, "Modifier" + _Codeclt + " " + _Nomclt + ""+ gridView1.GetFocusedRowCellValue("prenomclient").ToString() + "", "icons8_Grid.ico");
                frmpa.txtcode.EditValue =gridView1.GetFocusedRowCellValue("codeclt").ToString();
                frmpa.txtnom.EditValue = gridView1.GetFocusedRowCellValue("nomclt").ToString();
                frmpa.txtprenom.EditValue = gridView1.GetFocusedRowCellValue("prenomclient").ToString();
                frmpa.cmbsexe.Text = gridView1.GetFocusedRowCellValue("sexeclient").ToString();
                frmpa.txtadresse.EditValue = gridView1.GetFocusedRowCellValue("adresseclient").ToString();
                frmpa.txttel1.EditValue = gridView1.GetFocusedRowCellValue("tel1client").ToString();
                frmpa.txttel2.EditValue = gridView1.GetFocusedRowCellValue("tel2client").ToString();
                frmpa.txtfonction.Text = gridView1.GetFocusedRowCellValue("fonction").ToString();
                frmpa.btupdate.Visible = true;
                frmpa.Btok.Visible = false;
                frmpa.Dock = DockStyle.Fill;
                this.Cursor = Cursors.Default;
                
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            selectionpermiereligne();
        }

        private void Btupdate_Click(object sender, EventArgs e)
        {
            selection();
        }
        private void Verification_client()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT Count(Codeclt) AS Roun From Tvente WHERE Codeclt='" + txtidclt.Text + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    _idreche = connexion.dr.GetInt32(0);
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        private void Verification_client_affectation()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT Count(Codeclt) AS Roun From Taffectationpark WHERE Codeclt='" + txtidclt.Text + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    _idreche2 = connexion.dr.GetInt32(0);
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
            Etat.xtraListedesClients etat = new Etat.xtraListedesClients();
            menu.AddTabControldroit(frm, "Liste des cclients  ", "icons8_Grid.ico");
            frm.Dock = DockStyle.Fill;
            frm.documentViewer1.DocumentSource = etat;
            etat.CreateDocument();
            this.Cursor = Cursors.Default;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            selection();
        }

        private void deleteclient()
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous supprimer  " + _Nomclt + " ", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtidclt.Text))
                {
                    XtraMessageBox.Show("Veuillez selectionner une ligne ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //textEdit1.Focus();
                    return;
                }
                try
                {
                    ClassConnexion connexion = new ClassConnexion();
                    connexion.connecter();
                    connexion.cmd.Connection = connexion.con;
                    connexion.cmd.CommandText = ("DELETE Tclient WHERE Codeclt='" + _Codeclt + "'");
                    connexion.connecter();
                    connexion.cmd.ExecuteNonQuery();
                    Displaygrid();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BTDel_Click(object sender, EventArgs e)
        {
            if (_idreche > i || _idreche2 > i)
            {
                XtraMessageBox.Show("Impossible de supprimer le client " + _Nomclt + " car elle est déja utilser ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
               deleteclient();
            }
        }

        private void Btok_Click(object sender, EventArgs e)
        {
            FrmGestion.Frmcltdrt frmpa = new FrmGestion.Frmcltdrt(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            menu.AddTabControldroit(frmpa, "Ajouter un nouveau Client", "");
            frmpa.Dock = DockStyle.Fill;
            frmpa.btupdate.Visible = false;
            frmpa.Btok.Visible = true;
            this.Cursor = Cursors.Default;
        }
    }
}

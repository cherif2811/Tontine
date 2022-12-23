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
using suivibouteilles.Classes;

namespace suivibouteilles.FrmGestion
{
    public partial class Frmcollecteurgauche : DevExpress.XtraEditors.XtraUserControl
    { public int _iduser;
        int _idreche, i = 0;
        string _nom, _prenom, _code;
        FrmMenu.Menu menu;
        public Frmcollecteurgauche(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
            _iduser = menu._iduser;
            Displaygrid();
        }
        private void Verification_collecteur()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT Count(codecol) AS Roun From Tclient WHERE codecol='" + txtidclt.EditValue + "'");
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
        public void Displaygrid()
        {
            this.tcollecteurTableAdapter.Fill(dataSet1.Tcollecteur);
        }

        private void Btok_Click(object sender, EventArgs e)
        {
            FrmGestion.Frmcollecteurdroit frmpa = new FrmGestion.Frmcollecteurdroit(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            menu.AddTabControldroit(frmpa, "Ajouter un nouveau Collecteur", "");
            frmpa.Dock = DockStyle.Fill;
            frmpa.btupdate.Enabled = false;
            frmpa.btupdate.Visible = false;
            this.Cursor = Cursors.Default;
        }
        //fonction selectionne
        private void selection()
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                FrmGestion.Frmcollecteurdroit frmpa = new FrmGestion.Frmcollecteurdroit(this);
                XtraTabPage xtraTabPage = new XtraTabPage();
                menu.AddTabControldroit(frmpa, "Modifier" + _code + " " + _nom + " " + _prenom + " ", "icons8_Grid.ico");
                frmpa.txtcode.EditValue = gridView1.GetFocusedRowCellValue("code").ToString();
                frmpa.txtnom.EditValue = gridView1.GetFocusedRowCellValue("nom").ToString();
                frmpa.txtprenom.EditValue = gridView1.GetFocusedRowCellValue("prenom").ToString();
                frmpa.cmbsexe.Text = gridView1.GetFocusedRowCellValue("sexe").ToString();
                frmpa.txtadresse.EditValue = gridView1.GetFocusedRowCellValue("adresse").ToString();
                frmpa. dateEdit1.EditValue = gridView1.GetFocusedRowCellValue("datenaissance");
                frmpa.txttel1.EditValue = gridView1.GetFocusedRowCellValue("tel1").ToString();
                frmpa.txttel2.EditValue = gridView1.GetFocusedRowCellValue("tel2").ToString();
                frmpa.txtnomp.EditValue = gridView1.GetFocusedRowCellValue("nomp").ToString();
                frmpa.txtprenomp.EditValue = gridView1.GetFocusedRowCellValue("prenomp").ToString();
                frmpa.txtadressep.EditValue = gridView1.GetFocusedRowCellValue("adressep").ToString();
                frmpa.txttel1p.EditValue = gridView1.GetFocusedRowCellValue("tel1p").ToString();
                frmpa.txttel2p.EditValue = gridView1.GetFocusedRowCellValue("tel2p").ToString();
                //frmpa.txtsiteweb.EditValue = gridView1.GetFocusedRowCellValue("SiteWeb").ToString();
                frmpa.Btok.Enabled = false;
                frmpa.Dock = DockStyle.Fill;
                this.Cursor = Cursors.Default;

            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            selectionpermiereligne();
        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
            Etat.liste_collecteur etat = new Etat.liste_collecteur();
            menu.AddTabControldroit(frm, "Liste des collecteurs  ", "icons8_Grid.ico");
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
            DialogResult result = XtraMessageBox.Show("Voulez vous supprimer  " + _nom +  _prenom  + " ", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
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
                    connexion.cmd.CommandText = ("DELETE Tcollecteur WHERE code='" + txtidclt.EditValue + "'");
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

            if (_idreche > i)
            {
                XtraMessageBox.Show("Impossible le collecteur " + _nom  +  _prenom+" car elle est déja utilser dans d'autres opérations ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                deleteclient();
            }
        }

        //selection 1ere ligne
        private void selectionpermiereligne()
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                _code = gridView1.GetFocusedRowCellValue("code").ToString();
                txtidclt.Text = _code;
                _nom = gridView1.GetFocusedRowCellValue("nom").ToString();
                _prenom = gridView1.GetFocusedRowCellValue("prenom").ToString();
                Verification_collecteur();
            }
        }
        private void Btupdate_Click(object sender, EventArgs e)
        {
            selection();
        }
    }
}

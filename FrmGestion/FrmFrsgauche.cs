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
    public partial class FrmFrsgauche : DevExpress.XtraEditors.XtraUserControl
    {
        public int _iduser, _Codefrs, _idreche, i = 0;
        string _Nomfrs;
        FrmMenu.Menu menu;

        public FrmFrsgauche(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
            //btn ajouter
            if (menu._btnajoutefrs == "True")
            {
                Btok.Enabled = true;
            }
            if (menu._btnajoutefrs == "False")
            {
                Btok.Enabled = false;
            }
            //btn update
            if (menu._btnupdatefrs == "True")
            {
                Btupdate.Enabled = true;
            }
            if (menu._btnupdatefrs == "False")
            {
                Btupdate.Enabled = false;
            }
            //btn Delete
            if (menu._btndeletefrs == "True")
            {
                BTDel.Enabled = true;
            }
            if (menu._btndeletefrs == "False")
            {
                BTDel.Enabled = false;
            }
            //btn print
            if (menu._btnlistefrs == "True")
            {
                simpleButton1.Enabled = true;
            }
            if (menu._btnlistefrs == "False")
            {
                simpleButton1.Enabled = false;
            }
            _iduser = menu._iduser;
            Displaygrid();
        }
        //selection 1ere ligne
        private void selectionpermiereligne()
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                _Codefrs = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Codefrs").ToString());
                _Nomfrs = gridView1.GetFocusedRowCellValue("Nomfrs").ToString();
                txtidfrs.Text = _Codefrs.ToString();
                Verification_fournisseur();
            }
        }
        //fonction selectionne
        private void selection()
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                FrmGestion.FrmFrsdroite frmpa = new FrmGestion.FrmFrsdroite(this);
                XtraTabPage xtraTabPage = new XtraTabPage();
                menu.AddTabControldroit(frmpa, "Modifier" + _Codefrs + " " + _Nomfrs + "", "icons8_Grid.ico");
                frmpa._Codefrs= Convert.ToInt32(gridView1.GetFocusedRowCellValue("Codefrs").ToString());
                frmpa.txtnom.EditValue = gridView1.GetFocusedRowCellValue("Nomfrs").ToString();
                frmpa.txtadresse.EditValue = gridView1.GetFocusedRowCellValue("Adresse").ToString();
                frmpa.txtville.EditValue = gridView1.GetFocusedRowCellValue("Ville").ToString();
                frmpa.txtNif.EditValue = gridView1.GetFocusedRowCellValue("Nif").ToString();
                frmpa.txttel1.EditValue = gridView1.GetFocusedRowCellValue("Telephone1").ToString();
                frmpa.txttel2.EditValue = gridView1.GetFocusedRowCellValue("Telephone2").ToString();
                frmpa.txtsiteweb.EditValue = gridView1.GetFocusedRowCellValue("SiteWeb").ToString();
                frmpa.Btok.Enabled = false;
                frmpa.Dock = DockStyle.Fill;
                this.Cursor = Cursors.Default;

            }
        }

        public void Displaygrid()
        {
            this.tfournisseurTableAdapter.Fill(dataSet1.Tfournisseur);
        }

        private void Btupdate_Click(object sender, EventArgs e)
        {
            selection();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            selectionpermiereligne();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
            Etat.xtralistefournisseur etat = new Etat.xtralistefournisseur();
            menu.AddTabControldroit(frm, "Liste des Fournisseur  ", "icons8_Grid.ico");
            frm.Dock = DockStyle.Fill;
            frm.documentViewer1.DocumentSource = etat;
            etat.CreateDocument();
            this.Cursor = Cursors.Default;
        }
        private void Verification_fournisseur()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT Count(Codefrs) AS Roun From Tbonentree WHERE Codefrs='" + txtidfrs.Text + "'");
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            selection();
        }

        private void deletefrs()
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous supprimer  " + _Nomfrs + " ", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtidfrs.Text))
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
                    connexion.cmd.CommandText = ("DELETE Tfournisseur WHERE Codefrs='" + txtidfrs.Text + "'");
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
                XtraMessageBox.Show("Impossible de supprimer le client " + _Nomfrs + " car elle est déja utilser ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                deletefrs();
            }
        }

        private void Btok_Click(object sender, EventArgs e)
        {
            FrmGestion.FrmFrsdroite frmpa = new FrmGestion.FrmFrsdroite(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            menu.AddTabControldroit(frmpa, "Ajouter un nouveau Fournisseur", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }
    }
}

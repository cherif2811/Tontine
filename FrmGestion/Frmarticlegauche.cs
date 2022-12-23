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
    public partial class Frmarticlegauche : DevExpress.XtraEditors.XtraUserControl
    {
        public int _iduser, _idreche, i = 0;
        string _Codeart, _designation;
        FrmMenu.Menu menu;
        public Frmarticlegauche(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
            //btn ajouter
            if (menu._btnajoutarticle == "True")
            {
                Btok.Enabled = true;
            }
            if (menu._btnajoutarticle == "False")
            {
                Btok.Enabled = false;
            }
            //btn update
            if (menu._btnupdatearticle == "True")
            {
                Btupdate.Enabled = true;
            }
            if (menu._btnupdatearticle == "False")
            {
                Btupdate.Enabled = false;
            }
            //btn Delete
            if (menu._btndeletearticle == "True")
            {
                BTDel.Enabled = true;
            }
            if (menu._btndeletearticle == "False")
            {
                BTDel.Enabled = false;
            }
            //btn print
            if (menu._btnlistearticle == "True")
            {
                simpleButton1.Enabled = true;
            }
            if (menu._btnlistearticle == "False")
            {
                simpleButton1.Enabled = false;
            }
            _iduser = Convert.ToInt32(menu._iduser);
            Displaygrid();
        }
        //selection 1ere ligne
        private void selectionpermiereligne()
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                _Codeart = gridView1.GetFocusedRowCellValue("CodeArt").ToString();
                txtidarticle.Text = _Codeart.ToString();
                _designation = gridView1.GetFocusedRowCellValue("Designation1").ToString();
                Verification_article();
            }
        }
        //fonction selectionne
        private void selection()
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                FrmGestion.Frmarticledrt frmpa = new FrmGestion.Frmarticledrt(this);
                XtraTabPage xtraTabPage = new XtraTabPage();
                menu.AddTabControldroit(frmpa, "Modifier" + _Codeart + " " + _designation + "", "icons8_Grid.ico");
                frmpa.txtcodeart.EditValue = gridView1.GetFocusedRowCellValue("CodeArt").ToString();
                frmpa.txtdesignation.EditValue = gridView1.GetFocusedRowCellValue("Designation1").ToString();
                frmpa.txtprixachat.EditValue = gridView1.GetFocusedRowCellValue("prixachat").ToString();
                frmpa.txtprixvente.EditValue = gridView1.GetFocusedRowCellValue("prixvente").ToString();
                frmpa.txtdescription.EditValue = gridView1.GetFocusedRowCellValue("Designation2").ToString();
                frmpa.cmbcategorie.EditValue = gridView1.GetFocusedRowCellValue("DesiCat").ToString();
                frmpa.cmbsouscategorie.EditValue = gridView1.GetFocusedRowCellValue("DesiSousCat").ToString();
                frmpa.txtcodepark.EditValue = gridView1.GetFocusedRowCellValue("codepark").ToString();
                frmpa.txtmise.EditValue = gridView1.GetFocusedRowCellValue("mise").ToString();
                frmpa.cmbparkproduit.EditValue = gridView1.GetFocusedRowCellValue("libelle").ToString();
                frmpa._Display_stock_article();
                frmpa.txtcodeart.Enabled = false;
                frmpa.Btok.Visible = false;
                frmpa.Btupdate.Visible = true;
                frmpa.Dock = DockStyle.Fill;
                this.Cursor = Cursors.Default;

            }
        }
        public void Displaygrid()
        {
            this.tarticleGridTableAdapter.Fill(dataSet1.TarticleGrid);
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            selectionpermiereligne();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            selection();
        }

        private void Btupdate_Click(object sender, EventArgs e)
        {
            selection();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
            Etat.xtraListearticles etat = new Etat.xtraListearticles();
            menu.AddTabControldroit(frm, "Liste des articles  ", "icons8_Grid.ico");
            frm.Dock = DockStyle.Fill;
            frm.documentViewer1.DocumentSource = etat;
            etat.CreateDocument();
            this.Cursor = Cursors.Default;
        }
        private void deletearticle()
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous supprimer  " + _designation + " ", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtidarticle.Text))
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
                    connexion.cmd.CommandText = ("DELETE Tarticle WHERE CodeArt='" + txtidarticle.Text + "'");
                    connexion.connecter();
                    connexion.cmd.ExecuteNonQuery();
                    Displaygrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void Verification_article()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT Count(CodeArt) AS Roun From Tbonentreeligne WHERE CodeArt='" + txtidarticle.Text + "'");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void BTDel_Click(object sender, EventArgs e)
        {
            if (_idreche > i)
            {
                XtraMessageBox.Show("Impossible de supprimer l'article " + _designation + " car elle est déja utilser ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                deletearticle();
            }
        }

        private void Btok_Click(object sender, EventArgs e)
        {
            FrmGestion.Frmarticledrt frmpa = new FrmGestion.Frmarticledrt(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            menu.AddTabControldroit(frmpa, "Ajouter un nouveau Article", "");
            frmpa.Dock = DockStyle.Fill;
            frmpa.Btupdate.Visible = false;
            this.Cursor = Cursors.Default;
        }
    }
}

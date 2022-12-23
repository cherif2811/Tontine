using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suivibouteilles.FrmOperations
{
    public partial class Frmdepotgauche : DevExpress.XtraEditors.XtraUserControl
    {public int _iduser;
        public string _codeclient;
        FrmMenu.Menu menu;
        public Frmdepotgauche(FrmMenu.Menu en)
        {
            InitializeComponent();
          
            menu = en;
            _iduser = menu._iduser;
            this.tmp_clientTableAdapter.Fill(dataSet1.tmp_client);
        }

        private void Btok_Click(object sender, EventArgs e)
        {
            FrmOperations.Frmdepot_droit frmpa = new FrmOperations.Frmdepot_droit(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            menu.AddTabControldroit(frmpa, "Nouveau dépot", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }
        //fonction selectionne
        private void selection()
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                FrmOperations.Frmdepot_droit frmpa = new FrmOperations.Frmdepot_droit(this);
                XtraTabPage xtraTabPage = new XtraTabPage();
                menu.AddTabControldroit(frmpa, "Saisie dépot" + gridView1.GetFocusedRowCellValue("codeclt").ToString() + " " + gridView1.GetFocusedRowCellValue("nomclt").ToString() +"" + gridView1.GetFocusedRowCellValue("prenom").ToString() + "", "icons8_Grid.ico");
                frmpa.txtcode.EditValue = gridView1.GetFocusedRowCellValue("codeclt").ToString();
                frmpa.txtnom.EditValue = gridView1.GetFocusedRowCellValue("nomclt").ToString();
                frmpa.txtprenom.EditValue = gridView1.GetFocusedRowCellValue("prenom").ToString();
                frmpa.txttel1.EditValue = gridView1.GetFocusedRowCellValue("tel1").ToString();
                frmpa.txttel2.EditValue = gridView1.GetFocusedRowCellValue("tel2").ToString();
                frmpa.txtadresse.EditValue = gridView1.GetFocusedRowCellValue("adresse").ToString();
                // frmpa.btupdate.Visible = false;
                //  frmpa.Btok.Visible = true;
                frmpa.Dock = DockStyle.Fill;
                this.Cursor = Cursors.Default;

            }
        }
        //selection 1ere ligne
        private void selectionpermiereligne()
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                _codeclient = gridView1.GetFocusedRowCellValue("codeclt").ToString();

            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void Btok_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_codeclient))
            {
                XtraMessageBox.Show("Veuillez selectionner un client ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                selection();
            }
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            selectionpermiereligne();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            selection();
        }
    }
}

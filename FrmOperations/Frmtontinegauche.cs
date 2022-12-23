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

namespace suivibouteilles.FrmOperations
{
    public partial class Frmtontinegauche : DevExpress.XtraEditors.XtraUserControl
    {public int _iduser;
        public string _codeclient;
        FrmMenu.Menu menumm;
        public Frmtontinegauche(FrmMenu.Menu en)
        {
            InitializeComponent();
            menumm = en;
            _iduser = menumm._iduser;
            this.tmp_clientTableAdapter.Fill(dataSet1.tmp_client);
        }

        //fonction selectionne
        private void selection()
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                FrmOperations.Frmtontinedroit frmpa = new FrmOperations.Frmtontinedroit(this);
                XtraTabPage xtraTabPage = new XtraTabPage();
                menumm.AddTabControldroit(frmpa, "Saisie tontine" + gridView1.GetFocusedRowCellValue("codeclt").ToString() + " " + gridView1.GetFocusedRowCellValue("nomclt").ToString() + "", "icons8_Grid.ico");
                frmpa.txtcode.EditValue = gridView1.GetFocusedRowCellValue("codeclt").ToString();
                frmpa.txtnom.EditValue = gridView1.GetFocusedRowCellValue("nomclt").ToString();
                frmpa.txtprenom.EditValue = gridView1.GetFocusedRowCellValue("prenomclient").ToString();
              //  frmpa.cmbsexe.Text = gridView1.GetFocusedRowCellValue("sexeclient").ToString();
              //  frmpa.txtadresse.EditValue = gridView1.GetFocusedRowCellValue("adresseclient").ToString();
                frmpa.txttel1.EditValue = gridView1.GetFocusedRowCellValue("tel1client").ToString();
                frmpa.txttel2.EditValue = gridView1.GetFocusedRowCellValue("tel2client").ToString();
                frmpa.txtcodecoll.EditValue = gridView1.GetFocusedRowCellValue("codecol").ToString();
                frmpa.nomcoll.EditValue = gridView1.GetFocusedRowCellValue("nomcollecteur").ToString();
                frmpa.prenomcoll.EditValue = gridView1.GetFocusedRowCellValue("prenomcollecteur").ToString();
                frmpa.tel1coll.EditValue = gridView1.GetFocusedRowCellValue("tel1collecteur").ToString();
                frmpa.tel2coll.EditValue = gridView1.GetFocusedRowCellValue("tel2collecteur").ToString();
               // frmpa.txtidzone.EditValue = gridView1.GetFocusedRowCellValue("idzone").ToString();
                frmpa.txtzone.EditValue = gridView1.GetFocusedRowCellValue("libelle").ToString();
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
        private void Btok_Click(object sender, EventArgs e)
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

        private void gridView1_Click(object sender, EventArgs e)
        {
            selectionpermiereligne();
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
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
    }
}

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

namespace suivibouteilles.Frmutilisateur
{
    public partial class Frmusergauche : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMenu.Menu menu;
        public Frmusergauche(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
            DisplayUser();
        }
        public void DisplayUser()
        {
            this.griduserTableAdapter.Fill(dataSet1.Griduser);
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Frmutilisateur.Frmuser frm = new Frmutilisateur.Frmuser(this);
            menu.AddTabControldroit(frm, "Nouvel utilisateur ", "icons8_Grid.ico");
            frm.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
            frm.btupdate.Visible = false;
        }
        // fonction transfert value vers textbox 
        private void selectionligne()
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                Frmutilisateur.Frmuser frm = new Frmutilisateur.Frmuser(this);
                XtraTabPage xtraTabPage = new XtraTabPage();
                menu.AddTabControldroit(frm, "Fiche :" + gridView1.GetFocusedRowCellValue("UserName").ToString() + "", "icons8_Grid.ico");
                frm._iduser = Convert.ToInt32(gridView1.GetFocusedRowCellValue("iduser").ToString());
                frm.cmbprofil.Text = gridView1.GetFocusedRowCellValue("Libprofil").ToString();
                frm._idprofil = Convert.ToInt32(gridView1.GetFocusedRowCellValue("idprofil").ToString());
                frm.Txtlogin.Text = gridView1.GetFocusedRowCellValue("UserName").ToString();
                frm.TxtNom.Text = gridView1.GetFocusedRowCellValue("NomLogin").ToString();
                frm.txtPrenom.Text = gridView1.GetFocusedRowCellValue("PrenomLogin").ToString();
                frm.TxtPassword.Text = gridView1.GetFocusedRowCellValue("PwdName").ToString();
                frm.txtmail.Text = gridView1.GetFocusedRowCellValue("Email").ToString();
                frm.Dock = DockStyle.Fill;
                this.Cursor = Cursors.Default;
                frm.btokutilisateur.Visible = false;

            }
        }
        private void btupdate_Click(object sender, EventArgs e)
        {
            selectionligne();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            selectionligne();
        }
    }
}

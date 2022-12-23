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


namespace suivibouteilles.Frmrapports
{
    public partial class FrmEtatstock : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMenu.Menu me;
        public string _DesiCat, _DesiSousCat;
        public FrmEtatstock(FrmMenu.Menu en)
        {
           InitializeComponent();
            me = en;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodecategorie.Text) || (string.IsNullOrEmpty(txtsouscategorie.Text)))
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.xtraEtatStock etat = new Etat.xtraEtatStock();
                me.AddTabControldroit(frm, "Etat de stock ", "icons8_Grid.ico");
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
              else
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.xtraEtatStockparcategorieetsous etat = new Etat.xtraEtatStockparcategorieetsous(Convert.ToInt16( txtcodecategorie.EditValue),Convert.ToInt16( txtsouscategorie.EditValue));
                me.AddTabControldroit(frm, "Etat de stock Par Catégorie"+_DesiCat+" et Sous Categorie "+_DesiSousCat+"", "icons8_Grid.ico");
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmFiltre.Frmfiltreetatstock frm = new FrmFiltre.Frmfiltreetatstock(this);
            frm.ShowDialog();
        }
    }
}

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

namespace suivibouteilles.FrmParam
{
    public partial class FrmClassification : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMenu.Menu menu;
        public FrmClassification(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            FrmParam.Frmcategorie frmpa = new FrmParam.Frmcategorie();
            XtraTabPage xtraTabPage = new XtraTabPage();
            menu.AddTabControldroit(frmpa, "Catégorie", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmParam.Frmsouscategorie frmpa = new FrmParam.Frmsouscategorie();
            XtraTabPage xtraTabPage = new XtraTabPage();
            menu.AddTabControldroit(frmpa, "Sous Catégorie", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }
    }
}

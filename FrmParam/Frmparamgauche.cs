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
    public partial class Frmparamgauche : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMenu.Menu menu;
        public Frmparamgauche(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
        }

        private void btsparmgeneramgena_Click(object sender, EventArgs e)
        {
            FrmParam.Frmparametragegeneral frmpa = new FrmParam.Frmparametragegeneral();
            XtraTabPage xtraTabPage = new XtraTabPage();
            menu.AddTabControldroit(frmpa, "Paramètrage général", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmParam.FrmMagasin frmpa = new FrmParam.FrmMagasin();
            XtraTabPage xtraTabPage = new XtraTabPage();
            menu.AddTabControldroit(frmpa, "Magasin", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FrmParam.FrmClassification frmpa = new FrmParam.FrmClassification(menu);
            XtraTabPage xtraTabPage = new XtraTabPage();
            menu.AddTabControlgauche(frmpa, "Classification", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FrmParam.Frmzones frmpa = new FrmParam.Frmzones();
            XtraTabPage xtraTabPage = new XtraTabPage();
            menu.AddTabControldroit(frmpa, "Zones", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }
    }
}

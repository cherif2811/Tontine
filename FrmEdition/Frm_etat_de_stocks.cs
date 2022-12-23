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

namespace suivibouteilles.FrmEdition
{
    public partial class Frm_etat_de_stocks : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMenu.Menu menu;
        public Frm_etat_de_stocks(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
        }

        private void btimprimer_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
            Etat.liste_souscription_parc etat = new Etat.liste_souscription_parc();
            menu.AddTabControldroit(frm, "Liste de souscription des parcs" + "", "icons8_Grid.ico");
            //etat.Parameters["date1"].Value = dateEdit1.Text;
            //etat.Parameters["date2"].Value = dateEdit2.Text;
            frm.Dock = DockStyle.Fill;
            frm.documentViewer1.DocumentSource = etat;
            etat.CreateDocument();
            this.Cursor = Cursors.Default;
        }
    }
}

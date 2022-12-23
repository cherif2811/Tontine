using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace suivibouteilles.FrmFiltre
{
    public partial class Frmfiltreretour : DevExpress.XtraEditors.XtraForm
    {
        Frmrapports.FrmJournalRetour frmmere;
        public Frmfiltreretour(Frmrapports.FrmJournalRetour frmenf)
        {
            InitializeComponent();
            frmmere = frmenf;
        }

        private void Frmfiltreretour_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Tclient'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tclientTableAdapter.Fill(this.dataSet1.Tclient);

        }

        private void gridLookUpEdit1View_Click(object sender, EventArgs e)
        {

            if (gridLookUpEdit1View.SelectedRowsCount == 1)
            {
                textEdit1.Text = gridLookUpEdit1View.GetFocusedRowCellValue("Codeclt").ToString();
                frmmere._nomclt = gridLookUpEdit1View.GetFocusedRowCellValue("Nomclt").ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmmere.txtcodeclt.Text = textEdit1.Text;
            this.Close();
        }
    }
}
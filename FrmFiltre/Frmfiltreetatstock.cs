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
    public partial class Frmfiltreetatstock : DevExpress.XtraEditors.XtraForm
    {
       public int _codecategorie,_codesouscat;
        Frmrapports.FrmEtatstock frmmere;
        public Frmfiltreetatstock(Frmrapports.FrmEtatstock frmenf)
        {
            InitializeComponent();
            frmmere = frmenf;
        }

        private void gridLookUpEdit1View_Click(object sender, EventArgs e)
        {
            if (gridLookUpEdit1View.SelectedRowsCount == 1)
            {
              _codecategorie =Convert.ToInt16( gridLookUpEdit1View.GetFocusedRowCellValue("CodeCat").ToString());
                textEdit1.Text = _codecategorie.ToString();
                frmmere._DesiCat = gridLookUpEdit1View.GetFocusedRowCellValue("DesiCat").ToString();
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            _codesouscat = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Codesous").ToString());
            textEdit2.Text =_codesouscat.ToString();
            frmmere._DesiSousCat = gridView1.GetFocusedRowCellValue("DesiSousCat").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmmere.txtcodecategorie.Text = _codecategorie.ToString();
            frmmere.txtsouscategorie.Text = _codesouscat.ToString();
            this.Close();
        }

        private void Frmfiltreetatstock_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Tsouscat'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tsouscatTableAdapter.Fill(this.dataSet1.Tsouscat);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Tcategorie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tcategorieTableAdapter.Fill(this.dataSet1.Tcategorie);

        }
    }
}
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
    public partial class Frmfiltrefrsbe : DevExpress.XtraEditors.XtraForm
    {
        Frmrapports.FrmJournalBonEntree frmmere;
        public Frmfiltrefrsbe(Frmrapports.FrmJournalBonEntree frmenf)
        {
            InitializeComponent();
            frmmere = frmenf;
        }
        private void Frmfiltrefrsbe_Load(object sender, EventArgs e)
        {
            this.tfournisseurTableAdapter.Fill(this.dataSet1.Tfournisseur);
        }
        private void gridLookUpEdit1View_Click(object sender, EventArgs e)
        {
            if (gridLookUpEdit1View.SelectedRowsCount == 1)
            {
                textEdit1.Text = gridLookUpEdit1View.GetFocusedRowCellValue("Codefrs").ToString();
                frmmere._frs= gridLookUpEdit1View.GetFocusedRowCellValue("Nomfrs").ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
                frmmere.txtcodefrs.Text = textEdit1.Text;
               // frmmere.btfiltrebe.BackColor = Color.Red;
                this.Close();
            }
               
        }
    }

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
using suivibouteilles.Classes;

namespace suivibouteilles.Frmrequetes
{
    public partial class Frmrequete : DevExpress.XtraEditors.XtraUserControl
    {
        public Frmrequete()
        {
            InitializeComponent();
        }

        private void BtExcute_Click(object sender, EventArgs e)
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (memoEdit1.Text.ToString());
            connexion.da.SelectCommand = connexion.cmd;
            connexion.da.Fill(connexion.dt);
            Gridrequeteur.DataSource = connexion.dt;
            connexion.dt.AcceptChanges();
            connexion.dt.Dispose();
        }
    }
}

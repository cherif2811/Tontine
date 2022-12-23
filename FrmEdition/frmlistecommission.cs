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

namespace suivibouteilles.FrmEdition
{
    public partial class frmlistecommission : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMenu.Menu menu;
        public frmlistecommission(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
            Display_Collecteur();
        }

        private void btimprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dateEdit1.Text))
            {
                XtraMessageBox.Show("veuillez choisir une date", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dateEdit1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dateEdit2.Text))
            {
                XtraMessageBox.Show("veuillez choisir une date", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dateEdit1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbcommission.Text))
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.listing_commission_toute etat = new Etat.listing_commission_toute(Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit2.EditValue));
                menu.AddTabControldroit(frm, "Listing des commissions tous les collecteurs" + ""+" Du: " + dateEdit1.Text + " Au: " + dateEdit2.Text, "icons8_Grid.ico");
                etat.Parameters["date1"].Value = dateEdit1.Text;
                etat.Parameters["date2"].Value = dateEdit2.Text;
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.liste_commission_par_collecteur etat = new Etat.liste_commission_par_collecteur(Convert.ToInt32( txtcoll.Text), Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit2.EditValue));
                menu.AddTabControldroit(frm, "Listing des commissions par collecteur" + ""+ " Du: " + dateEdit1.Text + " Au: " + dateEdit2.Text, "icons8_Grid.ico");
                etat.Parameters["date1"].Value = dateEdit1.Text;
                etat.Parameters["date2"].Value = dateEdit2.Text;
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
        }
        public void Display_Collecteur()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT code,CONCAT(code,' ',nom,' ', prenom ) nomprenom FROM Tcollecteur");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    string collecteur = connexion.dr.GetString(1);
                    cmbcommission.Properties.Items.Add(collecteur);
                    //this.cmbTypeclasse.SelectedIndex = 0;
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                //XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbcommission_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT code,CONCAT(code,' ',nom,' ', prenom ) nomprenom FROM Tcollecteur WHERE  CONCAT(code,' ',nom,' ', prenom )='" + cmbcommission.EditValue + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    txtcoll.Text = connexion.dr.GetInt32(0).ToString();

                }
                connexion.deconnecter();
                // if (cmbzone.Text.Equals(""))
                if (string.IsNullOrEmpty(cmbcommission .Text))
                {
                    txtcoll.Text = "";
                }
            }
            catch (Exception)
            {
                //XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

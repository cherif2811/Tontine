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
    public partial class Frmlisting_tontine_par_collecteur : DevExpress.XtraEditors.XtraUserControl
    {
        string _nomprenom;
        FrmMenu.Menu menu;
        public Frmlisting_tontine_par_collecteur(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
            Display_Collecteur();
        }
        //Appel mode reglement
        public void Display_Collecteur()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT code, CONCAT(code,' ', nom,' ', prenom) as nomprenom
FROM Tcollecteur");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    _nomprenom = connexion.dr.GetString(1);
                    cmbcollecteur.Properties.Items.Add(_nomprenom);
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
        private void cmbcollecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT code, CONCAT(code,' ', nom,' ', prenom) as nomprenom FROM Tcollecteur WHERE  CONCAT(code,' ', nom,' ', prenom)='" + cmbcollecteur.EditValue + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    txtidcollecteur.Text = connexion.dr.GetInt32(0).ToString();

                }
                connexion.deconnecter();
                
            }
            catch (Exception)
            {
                //XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (string.IsNullOrEmpty(cmbcollecteur.Text))
            {
                XtraMessageBox.Show("veuillez selectionner un collecteur", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dateEdit1.Focus();
                return;
            }
            else
            {

                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.Situation_tontine_par_collecteur etat = new Etat.Situation_tontine_par_collecteur(txtidcollecteur.EditValue.ToString(), Convert.ToDateTime(dateEdit1.Text), Convert.ToDateTime(dateEdit2.Text));
                menu.AddTabControldroit(frm, "Liste tontine" + "" + " Du : " + dateEdit1.Text + " Au : " + dateEdit2.Text, "icons8_Grid.ico");
                etat.Parameters["date1"].Value = dateEdit1.Text;
                etat.Parameters["date2"].Value = dateEdit2.Text;
                etat.Parameters["collecteur"].Value = cmbcollecteur.Text;
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
        }
    }
}

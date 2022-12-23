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
    public partial class Frmbenefice : DevExpress.XtraEditors.XtraUserControl
    {
        int _idrecherche, i = 0;
        FrmMenu.Menu menu;
        public Frmbenefice(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
            Display_park_produits();
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
                XtraMessageBox.Show("veuillez choisir une 2eme date ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dateEdit2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbparkproduit.Text))
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.liste_benefice etat = new Etat.liste_benefice(Convert.ToDateTime(dateEdit1.EditValue),Convert.ToDateTime(dateEdit2.EditValue));
                menu.AddTabControldroit(frm, "Liste Benefice" + "", "icons8_Grid.ico");
                //etat.Parameters["date1"].Value = dateEdit1.Text;
                //etat.Parameters["date2"].Value = dateEdit2.Text;
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
           else
            {
                Verification();
                if (_idrecherche > i)
                {
                    this.Cursor = Cursors.WaitCursor;
                    FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                    Etat.liste_benefice_par_articles etat = new Etat.liste_benefice_par_articles(Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit2.EditValue), txtcodepark.Text);
                    menu.AddTabControldroit(frm, "Liste Benefice " + cmbparkproduit.Text + " Du: " + dateEdit1.Text + "Au :" + dateEdit2.Text, "icons8_Grid.ico");
                    etat.Parameters["date1"].Value = dateEdit1.Text;
                    etat.Parameters["date2"].Value = dateEdit2.Text;
                    frm.Dock = DockStyle.Fill;
                    frm.documentViewer1.DocumentSource = etat;
                    etat.CreateDocument();
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    XtraMessageBox.Show("L'article : " + cmbparkproduit.Text + " n'a effectué aucune opération entre les dates selectionnée" + " ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }
        private void Verification()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT  COUNT(codeart) FROM tmp_benefice WHERE codeart='" + txtcodepark.Text + "' AND date BETWEEN'" + dateEdit1.EditValue + "'AND '" + dateEdit2.EditValue + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    _idrecherche = connexion.dr.GetInt32(0);
                }
                connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Appel mode reglement
        public void Display_park_produits()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT CodeArt,Designation1 FROM Tarticle");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    string zone = connexion.dr.GetString(1);
                   cmbparkproduit .Properties.Items.Add(zone);
                    //this.cmbTypeclasse.SelectedIndex = 0;
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                // XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbparkproduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT CodeArt,Designation1 FROM Tarticle WHERE  Designation1='" + cmbparkproduit.EditValue + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    txtcodepark.Text = connexion.dr.GetString(0);
                }
                connexion.deconnecter();
                if (string.IsNullOrEmpty(cmbparkproduit.Text))
                {
                    txtcodepark.Text = "";
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

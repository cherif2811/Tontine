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
using suivibouteilles.Dataset;

namespace suivibouteilles.FrmEdition
{
    public partial class Frmlistetontine : DevExpress.XtraEditors.XtraUserControl
    { FrmMenu.Menu menu;
        int _idreche, i = 0;
        public Frmlistetontine(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
            Display_zone();
        }
        private void Verification_zone_existe_Tnote()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT COUNT(codeclt) From tmp_liste_cotisation_tontine WHERE codeclt='" + txtcodeclt.Text + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    _idreche = connexion.dr.GetInt32(0);
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
            if (string.IsNullOrEmpty(txtcodeclt.Text))
            {

                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.liste_tontine etat = new Etat.liste_tontine(Convert.ToDateTime(dateEdit1.Text), Convert.ToDateTime(dateEdit2.Text));
                menu.AddTabControldroit(frm, "Liste tontine" + ""+ " Du : " + dateEdit1.Text + " Au : " +dateEdit2.Text, "icons8_Grid.ico");
                etat.Parameters["date1"].Value = dateEdit1.Text;
                etat.Parameters["date2"].Value = dateEdit2.Text;
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
           //if (string.IsNullOrEmpty(txtidzone.Text) || (string.IsNullOrEmpty(txtidcollecteur.Text)))
          else
            {
                Verification_zone_existe_Tnote();
                if (_idreche > i)
                {
                    this.Cursor = Cursors.WaitCursor;
                    FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                    Etat.liste_tontine_par_zone etat = new Etat.liste_tontine_par_zone(( txtcodeclt.Text), Convert.ToDateTime(dateEdit1.Text), Convert.ToDateTime(dateEdit2.Text));
                    menu.AddTabControldroit(frm, "Liste tontine  " + cmbzone.Text + " Du : " + dateEdit1.Text + " Au: " +dateEdit2.Text, "icons8_Grid.ico");
                    etat.Parameters["date1"].Value = dateEdit1.Text;
                    etat.Parameters["date2"].Value = dateEdit2.Text;
                    frm.Dock = DockStyle.Fill;
                    frm.documentViewer1.DocumentSource = etat;
                    etat.CreateDocument();
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    XtraMessageBox.Show("La zone  :" + cmbzone.Text + " ne faite pas partie d'une opération" + 0 + " ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //cmbclasse.Focus();
                    //return;
                }
            }
        }
        //Appel mode reglement
        public void Display_zone()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT codeclt,nom FROM tmp_client_filtre");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    string client = connexion.dr.GetString(1);
                    cmbzone.Properties.Items.Add(client);
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
           
        }

        private void gridLookUpEdit1View_Click(object sender, EventArgs e)
        {
           
           
        }

        private void comboBoxEdit1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbzone_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT codeclt,nom FROM tmp_client_filtre WHERE nom='" + cmbzone.EditValue + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    txtcodeclt.Text = connexion.dr.GetString(0).ToString();
                   
                }
                connexion.deconnecter();
               // if (cmbzone.Text.Equals(""))
                    if (string.IsNullOrEmpty(cmbzone.Text))
                    {
                    txtcodeclt.Text = "";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
                //XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class Frmliste_parc : DevExpress.XtraEditors.XtraUserControl
    {
        Double mise;
        FrmMenu.Menu menu;
        public Frmliste_parc(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
            Display_park_produits();
        }

        private void btimprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidmise.Text))
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.liste_souscription_parc etat = new Etat.liste_souscription_parc();
                menu.AddTabControldroit(frm, "Liste des souscriptions aux mises" + "", "icons8_Grid.ico");
                //etat.Parameters["date1"].Value = dateEdit1.Text;
                //etat.Parameters["date2"].Value = dateEdit2.Text;
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.liste_souscription_client_par_pack etat = new Etat.liste_souscription_client_par_pack(Convert.ToInt32( txtidmise.Text));
                menu.AddTabControldroit(frm, "Liste de souscription par packs " +cmbparkproduit.EditValue+ "", "icons8_Grid.ico");
                //etat.Parameters["date1"].Value = dateEdit1.Text;
                //etat.Parameters["date2"].Value = dateEdit2.Text;
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
        }
      
        public void Display_park_produits()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT id,mise FROM Tmise");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    mise = connexion.dr.GetDouble(1);
                    cmbparkproduit.Properties.Items.Add(mise);
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
            connexion.cmd.CommandText = ("SELECT id, mise FROM Tmise WHERE  mise='" + cmbparkproduit.EditValue + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    txtidmise.Text = connexion.dr.GetInt32(0).ToString();

                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                //XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }


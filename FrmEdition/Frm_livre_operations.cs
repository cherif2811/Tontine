using DevExpress.XtraCharts.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
using suivibouteilles.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suivibouteilles.FrmEdition
{
    public partial class Frm_livre_operations : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMenu.Menu menu;
        string annee;
        public Frm_livre_operations(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu=en;
            Affichage_annee();
        }
        public void Affichage_annee()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT YEAR(dateop) AS annee FROM Tdepot GROUP BY YEAR(dateop)");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    annee = connexion.dr.GetSqlValue(0).ToString();
                    cmbannee.Properties.Items.Add(annee);
                    //this.cmbTypeclasse.SelectedIndex = 0;
                }
                connexion.deconnecter();
            }
            catch (Exception ex)
            {
                 XtraMessageBox.Show(ex.ToString());
                //XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbannee_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT YEAR(dateop) AS annee FROM Tdepot WHERE YEAR(dateop)='" + cmbannee.EditValue + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                   // textEdit1.Text = connexion.dr.GetSqlValue(0).ToString();

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
            if (string.IsNullOrEmpty(cmbannee.Text))
            {
                XtraMessageBox.Show("veuillez choisir une année", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbannee.Focus();
                return;
            }
           
           else
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
                Etat.Livre_0001 etat = new Etat.Livre_0001(this);
                menu.AddTabControldroit(frm, "Livre de depot & retrait" + "" + " Du: " + cmbannee.Text + "", "icons8_Grid.ico");
                etat.Parameters["annee"].Value = cmbannee.Text;
                //etat.Parameters["date2"].Value = dateEdit2.Text;
                frm.Dock = DockStyle.Fill;
                frm.documentViewer1.DocumentSource = etat;
                etat.CreateDocument();
                this.Cursor = Cursors.Default;
            }
        }
    }
}

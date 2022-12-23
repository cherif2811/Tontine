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

namespace suivibouteilles.FrmGestion
{
    public partial class Affectationparkclients : DevExpress.XtraEditors.XtraUserControl
    {
        string _etat = "En attente";
        int _idreche, i = 0;
        Double mise;
        public Affectationparkclients()
        {
            InitializeComponent();
            Display_park_produits();
            this.taffectationparkclientTableAdapter.Fill(dataSet1.Taffectationparkclient);
        }

        private void cmbclient_Click(object sender, EventArgs e)
        {
            this.tclient1TableAdapter.Fill(dataSet1.Tclient1);
        }

        private void gridLookUpEdit1View_Click(object sender, EventArgs e)
        {
            if (gridLookUpEdit1View.SelectedRowsCount == 1)
            {
                txtcodeclt.EditValue = gridLookUpEdit1View.GetFocusedRowCellValue("codeclt").ToString();
                txtnom.EditValue = gridLookUpEdit1View.GetFocusedRowCellValue("nomclt").ToString();
                txtprenom.EditValue = gridLookUpEdit1View.GetFocusedRowCellValue("prenom").ToString();
                txttel1.EditValue = gridLookUpEdit1View.GetFocusedRowCellValue("tel1").ToString();
            }
        }
        //Appel mode reglement
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

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous l'enregistrement?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (string.IsNullOrEmpty(cmbclient.Text))
                    {
                        XtraMessageBox.Show("Veuillez selectionner un client ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbclient.Focus();
                        return;
                    }

                    if (string.IsNullOrEmpty(cmbparkproduit.Text))
                    {
                        XtraMessageBox.Show("Veuillez selectionner une mise ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbparkproduit.Focus();
                        return;
                    }

                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = @"INSERT INTO Taffectationmise (codeclt,id,mise)VALUES(@codeclt, @id,@mise)";
                            connexion.cmd.Parameters.AddWithValue("@codeclt", txtcodeclt.Text);
                            connexion.cmd.Parameters.AddWithValue("@id", txtidmise.Text);
                            connexion.cmd.Parameters.AddWithValue("@mise", Convert.ToDouble(cmbparkproduit.Text));
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                            this.taffectationparkclientTableAdapter.Fill(dataSet1.Taffectationparkclient);
                            XtraMessageBox.Show("enregistrement effectuée");
                            // Vider();
                            {

                            }

                            connexion.deconnecter();
                        }
                        catch (Exception)
                        {
                            //XtraMessageBox.Show(ex.ToString());
                            XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally { }
                }
                catch (Exception)
                {
                    //XtraMessageBox.Show(ex.ToString());
                    XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void _update()
        {

            DialogResult result = XtraMessageBox.Show("Voulez vous modifiez?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (txtcodeclt.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez selectionner un client ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbclient.Focus();
                        return;
                    }
                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.deconnecter();
                            connexion.cmd.CommandText = @"UPDATE Taffectationmise SET codeclt=@codeclt,id=@id,mise=@mise WHERE indexe='" + txtindexe.EditValue + "'";
                            connexion.cmd.Parameters.AddWithValue("@codeclt", txtcodeclt.Text);
                            connexion.cmd.Parameters.AddWithValue("@id", txtidmise.Text);
                            connexion.cmd.Parameters.AddWithValue("@mise", Convert.ToDouble(cmbparkproduit.Text));
                            // connexion.cmd.Parameters.AddWithValue("@prix", Convert.ToDouble(txtmontant.Text));
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                            this.taffectationparkclientTableAdapter.Fill(dataSet1.Taffectationparkclient);
                            XtraMessageBox.Show("Modification effectuée");

                        }
                        catch (Exception)
                        {
                            // XtraMessageBox.Show(ex.ToString());
                            XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally { }
                }
                catch (Exception)
                {
                    //XtraMessageBox.Show(ex.ToString());
                    XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void btupdate_Click(object sender, EventArgs e)
        {
            if (_idreche > i)
            {
                XtraMessageBox.Show("Impossible de modifier la parc " + cmbparkproduit.Text + " car elle est déja utilser ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                _update();
                
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //btOk.Enabled = false;
            if (gridView1.SelectedRowsCount == 1)
            {
                txtindexe.EditValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("indexe").ToString());
                txtcodeclt.EditValue= gridView1.GetFocusedRowCellValue("codeclt").ToString();
                txtnom.EditValue= gridView1.GetFocusedRowCellValue("nomclt").ToString();
                txtprenom.EditValue = gridView1.GetFocusedRowCellValue("prenom").ToString();
                txttel1.EditValue = gridView1.GetFocusedRowCellValue("tel1").ToString();
                cmbparkproduit.EditValue= gridView1.GetFocusedRowCellValue("mise").ToString();
                txtidmise.EditValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id").ToString());
               // textEdit1.Text = gridView1.GetFocusedRowCellValue("libelle").ToString();
               // txtmise.EditValue = gridView1.GetFocusedRowCellValue("mise").ToString();
                //txtmontant.EditValue = gridView1.GetFocusedRowCellValue("prix").ToString();
                //_etat = gridView1.GetFocusedRowCellValue("etat").ToString();
                //Verification_affectation();
            }
        }
        private void Verification_affectation()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT Count(co) AS Roun From Ttontine WHERE codepark='" + txtidmise.Text + "' AND codeclt='" + txtcodeclt.Text + "' AND idafect='" + txtindexe.Text + "'");
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
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void delete_affectation()
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous supprimer  " + cmbparkproduit.EditValue + " ", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(cmbparkproduit.Text))
                {
                    XtraMessageBox.Show("Veuillez selectionner une ligne ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //textEdit1.Focus();
                    return;
                }
                try
                {
                    ClassConnexion connexion = new ClassConnexion();
                    connexion.connecter();
                    connexion.cmd.Connection = connexion.con;
                    connexion.cmd.CommandText = ("DELETE Taffectationpark WHERE codepark='" + txtidmise.Text + "' AND codeclt='" + txtcodeclt.Text + "' AND indexe='" + txtindexe.Text + "'");
                    connexion.connecter();
                    connexion.cmd.ExecuteNonQuery();
                    this.taffectationparkclientTableAdapter.Fill(dataSet1.Taffectationparkclient);
                    XtraMessageBox.Show("Suppression effectuée");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString());
                   // XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbclient_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (_idreche > i)
            {
                XtraMessageBox.Show("Impossible de supprimer la parc " + cmbparkproduit.Text + " car elle est déja utilser ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                delete_affectation();
            }
        }
    } }


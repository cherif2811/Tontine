using DevExpress.XtraEditors;
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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace suivibouteilles.FrmOperations
{
    public partial class Frmprets_droit : DevExpress.XtraEditors.XtraUserControl
    {
        Frmprets_gauche menu;
        public Frmprets_droit(Frmprets_gauche en)
        {
            InitializeComponent();
            menu = en;
            this.tpretTableAdapter.Fill(dataSet1.Tpret, menu._codeclient);
            num_pret();
            solde_general();
        }
        public void solde_general()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT       mtdepot-(mtretrait+mtpret) AS Solde FROM Total_solde_operations");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    Double mise = connexion.dr.GetDouble(0);
                   //mbmise.Properties.Items.Add(mise);
                    txtreste.EditValue = mise;
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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }
        private void _vider()
        {
            txtmontant.EditValue = 0;
        }
        private void num_pret()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("EXECUTE  num_pret");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    txtnum_retrait.EditValue = connexion.dr.GetString(0);
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                // XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application dans la fonction EXECUTE  num_depot", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btok_Click(object sender, EventArgs e)
        {

            DialogResult result = XtraMessageBox.Show("Voulez vous l'enregistrement?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (string.IsNullOrEmpty(txtnom.Text))
                    {
                        XtraMessageBox.Show("Veuillez renseigner le nom ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtnom.Focus();
                        return;
                    }
                
                    if (Convert.ToDouble(txtmontant.EditValue) == 0)
                    {
                        XtraMessageBox.Show("Renseigner le montant du pret ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        return;
                    }

                    if (Convert.ToDouble(txtmontant.EditValue) > (Convert.ToDouble(txtreste.EditValue)))
                    {
                        XtraMessageBox.Show("impossible d'octroyer le Prêts montant car le solde est insuffisant", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        txtmontant.EditValue = 0;
                        return;
                    }
                    //if (Convert.ToDouble(txtreste.EditValue) == 0)
                    //{
                    //    XtraMessageBox.Show("le client : " + txtnom.EditValue + " est à la fin de la cotisation du parc  " + cmbparkproduit.EditValue + "", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    return;
                    //}
                    else
                        try
                        {
                            // autonum_matricule();
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = "SELECT codeclt FROM Tpret WHERE  codeclt='" + txtcode.Text + "' AND datepret='" + txtdateop.Text.Substring(0, 10) + "'";
                            connexion.connecter();
                            connexion.dr = connexion.cmd.ExecuteReader();
                            if (connexion.dr.HasRows)
                            {
                                XtraMessageBox.Show("l'opération  " + 0 + " Existe déja pour le client : " + 0 + " date : " + txtdateop.Text + "", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else
                            {
                                connexion.deconnecter();
                                connexion.cmd.CommandText = @"INSERT INTO Tpret (codeclt, datepret, montant, commentaire, iduser, datecreation,numpret)VALUES(@codeclt, @datepret, @montant, @commentaire, @iduser, @datecreation,@numpret)";
                                connexion.cmd.Parameters.AddWithValue("@codeclt", txtcode.Text);
                                connexion.cmd.Parameters.AddWithValue("@datepret", txtdateop.Text.Substring(0, 10).ToString());
                                connexion.cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(txtmontant.Text));
                                connexion.cmd.Parameters.AddWithValue("@commentaire", txtcommentaire.Text.Replace("'", "'"));
                                connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                                connexion.cmd.Parameters.AddWithValue("@datecreation", DateTime.Now.ToString());
                                connexion.cmd.Parameters.AddWithValue("@numpret", txtnum_retrait.Text);
                                connexion.connecter();
                                connexion.cmd.ExecuteNonQuery();
                                connexion.deconnecter();
                                this.tpretTableAdapter.Fill(dataSet1.Tpret, menu._codeclient);
                                XtraMessageBox.Show("enregistrement effectuée");
                                num_pret();
                                solde_general();
                           
                                // verification_montant_restant();
                                _vider();
                                //if (Convert.ToDouble(txtreste.EditValue) == 0)
                                //{

                                //   // _notification_fin_cotisation();
                                //}
                            }
                            connexion.deconnecter();
                        }
                        catch (Exception)
                        {
                           // XtraMessageBox.Show(ex.ToString());
                            XtraMessageBox.Show("Une erreur s'est produite dans l'Application lors de l'enregistrement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally { }
                }
                catch (Exception)
                {
                    //XtraMessageBox.Show(ex.ToString());
                    XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 1)
            {

                txtcodepret.EditValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("codepret").ToString());     
               txtdateop.EditValue = gridView1.GetFocusedRowCellValue("datepret");
                txtmontant.EditValue = gridView1.GetFocusedRowCellValue("montant").ToString();
                txtcommentaire.Text = gridView1.GetFocusedRowCellValue("commentaire").ToString();
                Btok.Enabled = false;
                // verification_tontine_client_existe();
                // verification_montant_restant();
                // txtreste.EditValue =Convert.ToDouble( txtmontant.EditValue) -Convert.ToDouble( txtprixvente.EditValue);
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous l'enregistrement?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (string.IsNullOrEmpty(txtnom.Text))
                    {
                        XtraMessageBox.Show("Veuillez renseigner le nom ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtnom.Focus();
                        return;
                    }

                    if (Convert.ToDouble(txtmontant.EditValue) == 0)
                    {
                        XtraMessageBox.Show("Renseigner le montant du pret ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        return;
                    }

                    if (Convert.ToDouble(txtmontant.EditValue) > (Convert.ToDouble(txtreste.EditValue)))
                    {
                        XtraMessageBox.Show("impossible d'octroyer le Prêts montant car le solde est insuffisant", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        txtmontant.EditValue = 0;
                        return;
                    }
                    //if (Convert.ToDouble(txtreste.EditValue) == 0)
                    //{
                    //    XtraMessageBox.Show("le client : " + txtnom.EditValue + " est à la fin de la cotisation du parc  " + cmbparkproduit.EditValue + "", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    return;
                    //}
                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.deconnecter();
                            connexion.cmd.CommandText = @"UPDATE Tpret SET codeclt=@codeclt, datepret=@datepret, montant=@montant, commentaire=@commentaire, iduser=@iduser,datemodif=@datemodif  WHERE codepret='" + txtcodepret.EditValue + "'";
                            connexion.cmd.Parameters.AddWithValue("@codeclt", txtcode.Text);
                            connexion.cmd.Parameters.AddWithValue("@datepret", txtdateop.Text.Substring(0, 10).ToString());
                            connexion.cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(txtmontant.Text));
                            connexion.cmd.Parameters.AddWithValue("@commentaire", txtcommentaire.Text.Replace("'", "'"));
                            connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                            connexion.cmd.Parameters.AddWithValue("@datemodif", DateTime.Now.ToString());
                            connexion.cmd.Parameters.AddWithValue("@numpret", txtnum_retrait.Text);
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                            this.tpretTableAdapter.Fill(dataSet1.Tpret, menu._codeclient);
                            XtraMessageBox.Show("Modification effectuée");
                            solde_general();
                            num_pret();
                            _vider();
                            Btok.Enabled = true;
                            //  verification_montant_restant();
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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous supprimer la cotisation " + txtmontant.EditValue + " du " + txtdateop.Text + " Cette opération est irréversible", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtcodepret.Text))
                {
                    XtraMessageBox.Show("Veuillez double cliquer sur une ligne ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    ClassConnexion connexion = new ClassConnexion();
                    connexion.connecter();
                    connexion.cmd.Connection = connexion.con;
                    connexion.cmd.CommandText = ("DELETE Tpret WHERE codeclt='" + txtcode.Text + "' AND codepret='" + txtcodepret.Text + "'");
                    connexion.connecter();
                    connexion.cmd.ExecuteNonQuery();
                    this.tpretTableAdapter.Fill(dataSet1.Tpret, menu._codeclient);
                    XtraMessageBox.Show("Suppression effectuée ");
                    solde_general();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Une erreur s'est produite ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
    }


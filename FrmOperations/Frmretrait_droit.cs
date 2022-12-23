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
using static DevExpress.XtraBars.Docking2010.Views.BaseRegistrator;

namespace suivibouteilles.FrmOperations
{
    public partial class Frmretrait_droit : DevExpress.XtraEditors.XtraUserControl
    {
        Frmretrait_gauche menu;
        public Frmretrait_droit(Frmretrait_gauche en)
        {
            InitializeComponent();
            menu = en;
            this.tmp_grid_retraitTableAdapter.Fill(dataSet1.tmp_grid_retrait, menu._codeclient);
           Affichage_mise();
            num_retrait();

        }
        private void verification_montant_restant()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT codeclt, idafect, idmise, mise, mtdepot, mtret, solde FROM tmp_2eme_calcul_solde WHERE codeclt='" + txtcode.EditValue + "' AND idmise='" + txtidmise.EditValue + "' AND  idafect='" + txtidafect.EditValue + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader(0);
                //if ((!connexion.dr.HasRows) || (connexion.dr.IsDBNull(0)))
                while (connexion.dr.Read())
                {
                 
                    txtreste.EditValue = connexion.dr.GetDouble(6);
                }
                //if (_idreche > 0)
                //{

                //    //txtreste.EditValue = Convert.ToDouble(_prix).ToString();
                //    txtreste.EditValue = _prix - _montantcotise;
                //}

                //if (_idreche == 0)
                //{
                //    txtreste.EditValue = txtprixvente.EditValue;
                //}
                connexion.deconnecter();
            }
            catch (Exception)
            {
                // XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void num_retrait()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("EXECUTE  num_retrait");
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
        public void Affichage_mise()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT idafect,  idmise,  codeclt, mise, montant FROM   tmp_somme_depot WHERE codeclt='" + menu._codeclient + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    Double mise = connexion.dr.GetDouble(3);
                    cmbmise.Properties.Items.Add(mise);
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

        private void cmbmise_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT    idafect,  idmise,  codeclt, mise, montant FROM   tmp_somme_depot  WHERE codeclt = '" + menu._codeclient + "' AND mise='" + cmbmise.Text + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    txtidafect.Text = connexion.dr.GetInt32(0).ToString();
                    txtidmise.Text = connexion.dr.GetInt32(1).ToString();
                    txtmise.EditValue = connexion.dr.GetDouble(3).ToString();
                    txtreste.EditValue= connexion.dr.GetDouble(4).ToString();
                    //txtprixvente.EditValue = connexion.dr.GetDouble(5).ToString();
                    //verification_tontine_client_existe();
                    verification_montant_restant();

                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                //XtraMessageBox.Show(ex.ToString());
               XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _vider()
        {
            txtmontant.EditValue = 0;
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

                    if (string.IsNullOrEmpty(cmbmise.Text))
                    {
                        XtraMessageBox.Show("Veuillez selectionner une mise", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbmise.Focus();
                        return;
                    }
                    if (Convert.ToInt32(txtmontant.EditValue) == 0)
                    {
                        XtraMessageBox.Show("Renseigner le montant à cotiser ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        return;
                    }
                   
                    if (Convert.ToDouble(txtmontant.EditValue) > (Convert.ToDouble(txtreste.EditValue)))
                    {
                        XtraMessageBox.Show("le montant saisie est supperieur au solde", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        txtmontant.EditValue = 0;
                        return;
                    }
                    //if (Convert.ToDouble(txtmontant.EditValue) > (Convert.ToDouble(txtmise.EditValue)))
                    //{
                    //    XtraMessageBox.Show("le montant à cotisé est supperieur au prix de vente du parc", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //    txtmontant.Focus();
                    //    txtmontant.EditValue = 0;
                    //    return;
                    //}
                    //if (Convert.ToDouble(txtmontant.EditValue) > (Convert.ToDouble(txtreste.EditValue)))
                    //{
                    //    XtraMessageBox.Show("le montant à cotisé est supperieur au reste", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //    txtmontant.Focus();
                    //    txtmontant.EditValue = 0;
                    //    return;
                    //}
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
                            connexion.cmd.CommandText = "SELECT codeclt FROM Tretrait WHERE  codeclt='" + txtcode.Text + "' AND idafect='" + txtidafect.Text + "' AND idmise='" + txtidmise.Text + "' AND dateop='" + txtdateop.Text.Substring(0, 10) + "'";
                            connexion.connecter();
                            connexion.dr = connexion.cmd.ExecuteReader();
                            if (connexion.dr.HasRows)
                            {
                                XtraMessageBox.Show("l'opération  " + cmbmise.Text + " Existe déja pour le client : " + cmbmise.Text + " date : " + txtdateop.Text + "", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else
                            {
                                connexion.deconnecter();
                                connexion.cmd.CommandText = @"INSERT INTO Tretrait (codeclt, dateop, montant, commentaire, iduser, datecreation,idmise,idafect,numretrait)VALUES(@codeclt, @dateop, @montant, @commentaire, @iduser, @datecreation,@idmise,@idafect,@numretrait)";
                                connexion.cmd.Parameters.AddWithValue("@codeclt", txtcode.Text);
                                connexion.cmd.Parameters.AddWithValue("@dateop", txtdateop.Text.Substring(0, 10).ToString());
                                connexion.cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(txtmontant.Text));
                                connexion.cmd.Parameters.AddWithValue("@commentaire", txtcommentaire.Text.Replace("'", "'"));
                                connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                                connexion.cmd.Parameters.AddWithValue("@datecreation", DateTime.Now.ToString());
                                connexion.cmd.Parameters.AddWithValue("@idmise", txtidmise.Text);
                                //connexion.cmd.Parameters.AddWithValue("@mise", Convert.ToDouble(txtmise.Text));
                                connexion.cmd.Parameters.AddWithValue("@idafect", txtidafect.Text);
                                connexion.cmd.Parameters.AddWithValue("@numretrait", txtnum_retrait.Text);
                                connexion.connecter();
                                connexion.cmd.ExecuteNonQuery();
                                connexion.deconnecter();
                                XtraMessageBox.Show("enregistrement effectuée");
                                num_retrait();
                                this.tmp_grid_retraitTableAdapter.Fill(dataSet1.tmp_grid_retrait, menu._codeclient);
                                // this.tgridclientcollecteurzoneBindingSource.DataSource = dataSet1;
                                // verification_montant_restant();
                                _vider();
                                //if (Convert.ToDouble(txtreste.EditValue) == 0)
                                //{

                                //   // _notification_fin_cotisation();
                                //}
                            }
                            connexion.deconnecter();
                        }
                        catch (Exception ex)
                        {
                             XtraMessageBox.Show(ex.ToString());
                           // XtraMessageBox.Show("Une erreur s'est produite dans l'Application lors de l'enregistrement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                txtcoderet.EditValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("coderet").ToString());
                txtidmise.EditValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("idmise").ToString());
                cmbmise.EditValue = gridView1.GetFocusedRowCellValue("mise").ToString();
                txtidafect.EditValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("idafect").ToString());
                txtmise.EditValue = gridView1.GetFocusedRowCellValue("mise").ToString();
                txtdateop.EditValue = gridView1.GetFocusedRowCellValue("dateop");
                txtmontant.EditValue = gridView1.GetFocusedRowCellValue("montant").ToString();
                txtcommentaire.Text = gridView1.GetFocusedRowCellValue("commentaire").ToString();
                Btok.Enabled = false;
                 verification_montant_restant();
                // txtreste.EditValue =Convert.ToDouble( txtmontant.EditValue) -Convert.ToDouble( txtprixvente.EditValue);
                // verification_tontine_client_existe();
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous modifiez?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (string.IsNullOrEmpty(txtnom.Text))
                    {
                        XtraMessageBox.Show("Veuillez renseigner le nom ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtnom.Focus();
                        return;
                    }

                    if (string.IsNullOrEmpty(cmbmise.Text))
                    {
                        XtraMessageBox.Show("Veuillez selectionner une mise", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbmise.Focus();
                        return;
                    }
                    if (Convert.ToInt32(txtmontant.EditValue) == 0)
                    {
                        XtraMessageBox.Show("Renseigner le montant à cotiser ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        return;
                    }

                    if (Convert.ToDouble(txtmontant.EditValue) > (Convert.ToDouble(txtreste.EditValue)))
                    {
                        XtraMessageBox.Show("le montant saisie est supperieur au solde", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        txtmontant.EditValue = 0;
                        return;
                    }
                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.deconnecter();
                            connexion.cmd.CommandText = @"UPDATE Tretrait SET codeclt=@codeclt, dateop=@dateop, montant=@montant, commentaire=@commentaire, iduser=@iduser, idmise=@idmise,datemodif=@datemodif  WHERE coderet='" + txtcoderet.EditValue + "'";
                            connexion.cmd.Parameters.AddWithValue("@codeclt", txtcode.Text);
                            connexion.cmd.Parameters.AddWithValue("@dateop", txtdateop.Text.Substring(0, 10).ToString());
                            connexion.cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(txtmontant.Text));
                            connexion.cmd.Parameters.AddWithValue("@commentaire", txtcommentaire.Text.Replace("'", "'"));
                            connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                            connexion.cmd.Parameters.AddWithValue("@datecreation", DateTime.Now.ToString());
                            connexion.cmd.Parameters.AddWithValue("@idmise", txtidmise.Text);
                            //connexion.cmd.Parameters.AddWithValue("@mise", Convert.ToDouble(txtmise.Text));
                            connexion.cmd.Parameters.AddWithValue("@idafect", txtidafect.Text);
                           // connexion.cmd.Parameters.AddWithValue("@numretrait", txtnum_retrait.Text);
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                            this.tmp_grid_retraitTableAdapter.Fill(dataSet1.tmp_grid_retrait, menu._codeclient);
                            XtraMessageBox.Show("Modification effectuée");
                            Btok.Enabled = true;
                             verification_montant_restant();

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
                if (string.IsNullOrEmpty(cmbmise.Text))
                {
                    XtraMessageBox.Show("Veuillez double cliquer sur une ligne ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    ClassConnexion connexion = new ClassConnexion();
                    connexion.connecter();
                    connexion.cmd.Connection = connexion.con;
                    connexion.cmd.CommandText = ("DELETE Tdepot WHERE codeclt='" + txtcode.Text + "' AND codeop='" + txtcoderet.Text + "'");
                    connexion.connecter();
                    connexion.cmd.ExecuteNonQuery();
                    this.tmp_grid_retraitTableAdapter.Fill(dataSet1.tmp_grid_retrait, menu._codeclient);
                    XtraMessageBox.Show("Suppression effectuée ");
                    //verification_montant_restant();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Une erreur s'est produite ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }
    } }


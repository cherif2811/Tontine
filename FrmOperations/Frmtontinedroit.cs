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
using DevExpress.XtraBars.Alerter;

namespace suivibouteilles.FrmOperations
{
    public partial class Frmtontinedroit : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMenu.Menu menum;
        int _idreche, i = 0;
        Double _prix, _reste, _montantcotise;
        Frmtontinegauche menu;
        public Frmtontinedroit(Frmtontinegauche en)
        {
            InitializeComponent();
            menu = en;

            Display_park_produits();
            this.tgridtontineclientTableAdapter.Fill(dataSet1.Tgridtontineclient, menu._codeclient);
            num_depot();
        }

        private void num_depot()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("EXECUTE  num_depot");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    txtnum_depot.EditValue = connexion.dr.GetString(0);
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                // XtraMessageBox.Show(ex.ToString());
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

                    if (string.IsNullOrEmpty(cmbparkproduit.Text))
                    {
                        XtraMessageBox.Show("Veuillez selectionner un pack ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbparkproduit.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(txtzone.Text))
                    {
                        XtraMessageBox.Show("Veuillez selectionner une zone ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtzone.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(txtnbrecase.Text))
                    {
                        XtraMessageBox.Show("Veuillez renseigner le nombre de case ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtnbrecase.Focus();
                        return;
                    }
                    if (Convert.ToInt32(txtnbrecase.EditValue) == 0)
                    {
                        XtraMessageBox.Show("verifier le nombre de case ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        return;
                    }
                    if (Convert.ToDouble(txtmontant.EditValue) > (Convert.ToDouble(txtprixvente.EditValue)))
                    {
                        XtraMessageBox.Show("le montant à cotisé est supperieur au prix de vente du parc", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        txtmontant.EditValue = 0;
                        return;
                    }
                    if (Convert.ToDouble(txtmontant.EditValue) > (Convert.ToDouble(txtreste.EditValue)))
                    {
                        XtraMessageBox.Show("le montant à cotisé est supperieur au reste", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        txtmontant.EditValue = 0;
                        return;
                    }
                    if (Convert.ToDouble(txtreste.EditValue) == 0)
                    {
                        XtraMessageBox.Show("le client : " + txtnom.EditValue + " est à la fin de la cotisation du parc  " + cmbparkproduit.EditValue + "", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                        try
                        {
                            // autonum_matricule();
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = "SELECT codeclt FROM Ttontine WHERE  codeclt='" + txtcode.Text + "' AND idafect='" + txtidafect.Text + "' AND codepark='" + txtcodepark.Text + "' AND dateop='" + txtdateop.Text.Substring(0, 10) + "'";
                            connexion.connecter();
                            connexion.dr = connexion.cmd.ExecuteReader();
                            if (connexion.dr.HasRows)
                            {
                                XtraMessageBox.Show("l'opération  " + cmbparkproduit.Text + " Existe déja pour le client : " + cmbparkproduit.Text + " date : " + txtdateop.Text + "", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else
                            {
                                connexion.deconnecter();
                                connexion.cmd.CommandText = @"INSERT INTO Ttontine (codeclt, dateop, montant, commentaire, iduser, datecreation,codepark,nbrecase,idafect)VALUES(@codeclt, @dateop, @montant, @commentaire, @iduser, @datecreation,@codepark,@nbrecase,@idafect)";
                                connexion.cmd.Parameters.AddWithValue("@codeclt", txtcode.Text);
                                connexion.cmd.Parameters.AddWithValue("@dateop", txtdateop.Text.Substring(0, 10).ToString());
                                connexion.cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(txtmontant.Text));
                                connexion.cmd.Parameters.AddWithValue("@commentaire", txtcommentaire.Text.Replace("'", "'"));
                                connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                                connexion.cmd.Parameters.AddWithValue("@datecreation", DateTime.Now.ToString());
                                connexion.cmd.Parameters.AddWithValue("@codepark", txtcodepark.Text);
                                connexion.cmd.Parameters.AddWithValue("@nbrecase", txtnbrecase.Text);
                                connexion.cmd.Parameters.AddWithValue("@idafect", txtidafect.Text);
                                connexion.connecter();
                                connexion.cmd.ExecuteNonQuery();
                                connexion.deconnecter();
                                XtraMessageBox.Show("enregistrement effectuée");
                                this.tgridtontineclientTableAdapter.Fill(dataSet1.Tgridtontineclient, menu._codeclient);
                                verification_montant_restant();
                                _vider();
                                if (Convert.ToDouble(txtreste.EditValue) == 0)
                                {
                                    //XtraMessageBox.Show("le client" + txtnom.EditValue + "est à la fin de la cotisation du parc " + cmbparkproduit.EditValue + "", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //return;
                                    _notification_fin_cotisation();
                                }
                            }
                            connexion.deconnecter();
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

        private void cmbclient_Click(object sender, EventArgs e)
        {
            this.tgridclient_collecteur_zoneTableAdapter.Fill(dataSet1.Tgridclient_collecteur_zone);
        }
        //Appel mode reglement
        public void Display_park_produits()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT Taffectationpark.indexe,Tpark.codepark, libelle, mise,codeclt ,Taffectationpark.prix FROM Tpark,Taffectationpark
  WHERE Tpark.codepark=Taffectationpark.codepark AND  Taffectationpark.etat='En attente'
  AND Taffectationpark.codeclt='" + menu._codeclient + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    string parc = connexion.dr.GetString(2);
                    cmbparkproduit.Properties.Items.Add(parc);
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
        //verifie count ttontine null
        private void verification_tontine_client_existe()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT COUNT(codeclt) as nb FROM tmp_tontine_reste_apayer WHERE codeclt='" + txtcode.EditValue + "' AND codepark='" + txtcodepark.EditValue + "' AND  idafect='" + txtidafect.EditValue + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader(0);
                //if ((!connexion.dr.HasRows) || (connexion.dr.IsDBNull(0)))
                while (connexion.dr.Read())
                {
                    _idreche = connexion.dr.GetInt32(0);
                }
               if(_idreche==0)
                {
                    txtreste.EditValue = txtprixvente.EditValue;
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                // XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void verification_montant_restant()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT codeclt, codepark ,prix,montant,reste ,idafect FROM tmp_tontine_reste_apayer WHERE codeclt='" + txtcode.EditValue + "' AND codepark='" + txtcodepark.EditValue + "' AND  idafect='" + txtidafect.EditValue + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader(0);
                //if ((!connexion.dr.HasRows) || (connexion.dr.IsDBNull(0)))
                while (connexion.dr.Read())
                {
                    _prix = connexion.dr.GetDouble(2);
                    _montantcotise = connexion.dr.GetDouble(3);
                    _reste = connexion.dr.GetDouble(4);
                }
                    if (_idreche > 0)
                    {

                        //txtreste.EditValue = Convert.ToDouble(_prix).ToString();
                        txtreste.EditValue = _prix - _montantcotise;
                    }

                    if (_idreche == 0)
                    {
                        txtreste.EditValue = txtprixvente.EditValue;
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
            connexion.cmd.CommandText = (@"SELECT  Taffectationpark.indexe, Tpark.codepark, libelle, mise,codeclt,Taffectationpark.prix FROM Tpark,Taffectationpark
  WHERE Tpark.codepark = Taffectationpark.codepark AND Taffectationpark.etat='En attente' AND Taffectationpark.codeclt = '" + menu._codeclient + "' AND libelle='" + cmbparkproduit.Text + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    txtidafect.Text= connexion.dr.GetInt32(0).ToString();
                    txtcodepark.Text = connexion.dr.GetInt32(1).ToString();
                    txtmise.EditValue = connexion.dr.GetDouble(3).ToString();
                    txtprixvente.EditValue = connexion.dr.GetDouble(5).ToString();
                    verification_tontine_client_existe();
                   verification_montant_restant();
                    //if (Convert.ToDouble(txtreste.EditValue) == 0)
                    //{
                    //    XtraMessageBox.Show("le client est à la fin de la cotisation ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    Btok.Enabled = false;
                    //    btupdate.Enabled = false;
                    //    simpleButton4.Enabled = false;
                    //}
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                //XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    if (string.IsNullOrEmpty(cmbparkproduit.Text))
                    {
                        XtraMessageBox.Show("Veuillez selectionner un pack ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbparkproduit.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(txtzone.Text))
                    {
                        XtraMessageBox.Show("Veuillez selectionner une zone ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtzone.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(txtnbrecase.Text))
                    {
                        XtraMessageBox.Show("Veuillez renseigner le nombre de case ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtnbrecase.Focus();
                        return;
                    }
                    if (Convert.ToInt32(txtnbrecase.EditValue) == 0)
                    {
                        XtraMessageBox.Show("verifier le nombre de case ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        return;
                    }
                    if (Convert.ToDouble(txtreste.EditValue) == 0)
                    {
                        XtraMessageBox.Show("le client : " + txtnom.EditValue + " est à la fin de la cotisation du parc  " + cmbparkproduit.EditValue + "", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.deconnecter();
                            connexion.cmd.CommandText = @"UPDATE Ttontine SET codeclt=@codeclt, dateop=@dateop, montant=@montant, commentaire=@commentaire, iduser=@iduser, codepark=@codepark, nbrecase=@nbrecase,datemodif=@datemodif  WHERE codeop='" + txtcodeop.EditValue + "'";
                            connexion.cmd.Parameters.AddWithValue("@codeclt", txtcode.Text);
                            connexion.cmd.Parameters.AddWithValue("@dateop", txtdateop.Text.Substring(0, 10));
                            connexion.cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(txtmontant.Text));
                            connexion.cmd.Parameters.AddWithValue("@commentaire", txtcommentaire.Text.Replace("'", "'"));
                            connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                            connexion.cmd.Parameters.AddWithValue("@datemodif", DateTime.Now.ToString());
                            connexion.cmd.Parameters.AddWithValue("@codepark", txtcodepark.Text);
                            connexion.cmd.Parameters.AddWithValue("@nbrecase", txtnbrecase.Text);
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                            this.tgridtontineclientTableAdapter.Fill(dataSet1.Tgridtontineclient, menu._codeclient);
                            XtraMessageBox.Show("Modification effectuée");
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 1)
            {
              
                txtcodeop.EditValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("codeop").ToString());
                txtcodepark.EditValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("codepark").ToString());
                cmbparkproduit.EditValue = gridView1.GetFocusedRowCellValue("libelle").ToString();
                txtidafect.EditValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("idafect").ToString());
                txtmise.EditValue = gridView1.GetFocusedRowCellValue("mise").ToString();
                txtdateop.EditValue = gridView1.GetFocusedRowCellValue("dateop");
                txtmontant.EditValue = gridView1.GetFocusedRowCellValue("montant").ToString();
                txtcommentaire.Text = gridView1.GetFocusedRowCellValue("commentaire").ToString();
                txtnbrecase.Text = Convert.ToInt32(gridView1.GetFocusedRowCellValue("nbrecase")).ToString();
                verification_tontine_client_existe();
                verification_montant_restant();
              // txtreste.EditValue =Convert.ToDouble( txtmontant.EditValue) -Convert.ToDouble( txtprixvente.EditValue);
            }

        }

        private void btrecu_Click(object sender, EventArgs e)
        {
            //_chiffreenLettre = NumberToWords(Convert.ToInt32(txtmtinscrpt.Text));
            FrmOperations.Frmreçu frmrecu = new FrmOperations.Frmreçu();
            frmrecu.Text = txtcode.Text + " " + txtnom.Text + " " + txtprenom.Text + " " + cmbparkproduit.EditValue + "";
            //  Etat.RecuInscription etat = new Etat.RecuInscription(_idannee, _idclasse, Txtmatricule.Text);
            // etat.Parameters["enlettre"].Value = _chiffreenLettre;
            //etat.Parameters["anneerecu"].Value = menu.txtanneemenu.Text;
            //etat.Parameters["TotalPayer"].Value = labelControl10.Text;
            // etat.Parameters["mtEnletter"].Value = _chiffreenLettre;
            // frmrecu.documentViewer1.DocumentSource = etat;
            // etat.CreateDocument();
            frmrecu.Dock = DockStyle.Fill;
            frmrecu.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
            //if (txtcode.Text.Equals(""))
            //{
            //    XtraMessageBox.Show("veuillez selectionner  un client", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
            //else
            //{
            //    this.Cursor = Cursors.WaitCursor;
            //    FrmEdition.Frmprint frm = new FrmEdition.Frmprint();
            //    menum.AddTabControldroit(frm, "Detail Paiement Ecolage, Eleve: " + txtcode.Text + " " + txtnom.Text + " " + txtprenom.Text, "icons8_Grid.ico");
            //    Etat.XtraReport1 etat = new Etat.XtraReport1();
            //    //etat.Parameters["classedetailpaiement"].Value = cmbclasse.Text;
            //    //etat.Parameters["netapayer"].Value = _restapayer;
            //    //etat.Parameters["anneedtpaiement"].Value = menu.txtanneemenu.Text;
            //    frm.documentViewer1.DocumentSource = etat;
            //    etat.CreateDocument();
            //    frm.Dock = DockStyle.Fill;
            //    this.Cursor = Cursors.Default;
            //}
        }

        private void txtnbrecase_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtnbrecase_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtmontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtnbrecase.EditValue = (Convert.ToInt32(txtmontant.EditValue) / Convert.ToInt32(txtmise.EditValue));
        }

        private void txtmontant_Leave(object sender, EventArgs e)
        {

        }

        private void txtmontant_MouseLeave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtmontant.EditValue) > (Convert.ToDouble(txtprixvente.EditValue)))
            {
                XtraMessageBox.Show("le montant à cotisé est supperieur au prix de vente du parc", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtmontant.Focus();
                txtmontant.EditValue = 0;
                return;
            }
            if (Convert.ToDouble(txtmontant.EditValue) > (Convert.ToDouble(txtreste.EditValue)))
            {
                XtraMessageBox.Show("le montant à cotisé est supperieur au reste", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtmontant.Focus();
                txtmontant.EditValue = 0;
                return;
            }
            //if (Convert.ToDouble(txtreste.EditValue) == 0)
            //{
            //    XtraMessageBox.Show("le client  "  + txtnom.EditValue + " est à la fin de la cotisation du parc  " + cmbparkproduit.EditValue + "", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void alertControl1_AlertClick(object sender, AlertClickEventArgs e)
        {

        }
        private void _notification_fin_cotisation()
        {
            int indexnotification = 0;
            string[] toast = { "2fe5ae8a-e706-48e9-8f56-004d80e867fd" };
            toastNotificationsManager1.Notifications[indexnotification].Body = "Fin de cotisation"+" " + cmbparkproduit.Text + " du Client " + txtnom.Text+" "+txtprenom.Text;
            toastNotificationsManager1.Notifications[indexnotification].Header = "Fin de cotisation";
            toastNotificationsManager1.ShowNotification(toast[indexnotification].ToString());
        }
   
        private void txtmontant_EditValueChanged(object sender, EventArgs e)
        {
            txtnbrecase.EditValue = (Convert.ToInt32(txtmontant.EditValue) / Convert.ToInt32(txtmise.EditValue));
            //if (Convert.ToDouble(txtmontant.EditValue) > (Convert.ToDouble(txtprixvente.EditValue)))
            //{
            //    XtraMessageBox.Show("le montant à cotisé est supperieur au prix de vente du parc", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    txtmontant.Focus();
            //   txtmontant.EditValue= 0;
            //    return;
            //}
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous supprimer la tontine " + cmbparkproduit.EditValue + " du " + txtdateop.Text + " Cette opération est irréversible", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(cmbparkproduit.Text))
                {
                    XtraMessageBox.Show("Veuillez double cliquer sur une ligne ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    ClassConnexion connexion = new ClassConnexion();
                    connexion.connecter();
                    connexion.cmd.Connection = connexion.con;
                    connexion.cmd.CommandText = ("DELETE Ttontine WHERE codeclt='" + txtcode.Text + "' AND codeop='" + txtcodeop.Text + "'");
                    connexion.connecter();
                    connexion.cmd.ExecuteNonQuery();
                    this.tgridtontineclientTableAdapter.Fill(dataSet1.Tgridtontineclient, menu._codeclient);
                    XtraMessageBox.Show("Suppression effectuée ");
                    verification_montant_restant();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Une erreur s'est produite ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}

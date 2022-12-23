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

namespace suivibouteilles.FrmOperations
{
    public partial class Frmdepot_droit : DevExpress.XtraEditors.XtraUserControl
    {
        Frmdepotgauche menu;
        public Frmdepot_droit(Frmdepotgauche en)
        {
            InitializeComponent();
            menu = en;
            Affichage_mise();
            this.tgridtontineclientTableAdapter.Fill(dataSet1.Tgridtontineclient, menu._codeclient);
            num_depot();
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitterControl2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btajtclient_Click(object sender, EventArgs e)
        {

        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void txtprixvente_EditValueChanged(object sender, EventArgs e)
        {

        }
        public void Affichage_mise()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT indexe, codeclt, id, mise FROM    Taffectationmise
  WHERE codeclt='" + menu._codeclient + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                   Double mise= connexion.dr.GetDouble(3);
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
        private void cmbparkproduit_SelectedIndexChanged(object sender, EventArgs e)
        {
             ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT indexe, codeclt, id, mise FROM    Taffectationmise  WHERE codeclt = '" + menu._codeclient + "' AND mise='" + cmbmise.Text + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    txtidafect.Text = connexion.dr.GetInt32(0).ToString();
                    txtidmise.Text = connexion.dr.GetInt32(2).ToString();
                    txtmise.EditValue = connexion.dr.GetDouble(3).ToString();
                    //txtprixvente.EditValue = connexion.dr.GetDouble(5).ToString();
                    //verification_tontine_client_existe();
                    //verification_montant_restant();
                  
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                //XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEdit1_FormatEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)

        { 
       
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtmontant_EditValueChanged(object sender, EventArgs e)
        {
            txtnbrecase.EditValue = (Convert.ToInt32(txtmontant.EditValue) / Convert.ToInt32(txtmise.EditValue));
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

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
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application dans la fonction EXECUTE  num_depot", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    
                    if (string.IsNullOrEmpty(txtnbrecase.Text))
                    {
                        XtraMessageBox.Show("Veuillez renseigner le nombre de case ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtnbrecase.Focus();
                        return;
                    }
                    if (Convert.ToInt32(txtmontant.EditValue) == 0)
                    {
                        XtraMessageBox.Show("Renseigner le montant à cotiser ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        return;
                    }
                    if (Convert.ToInt32(txtnbrecase.EditValue) == 0)
                    {
                        XtraMessageBox.Show("verifier le montant à cotiser ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        return;
                    }
                    if (Convert.ToDouble(txtmontant.EditValue) < (Convert.ToDouble(txtmise.EditValue)))
                    {
                        XtraMessageBox.Show("le montant à cotiser est inferieur à la mise", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                            connexion.cmd.CommandText = "SELECT codeclt FROM Tdepot WHERE  codeclt='" + txtcode.Text + "' AND idafect='" + txtidafect.Text + "' AND idmise='" + txtidmise.Text + "' AND dateop='" + txtdateop.Text.Substring(0, 10) + "'";
                            connexion.connecter();
                            connexion.dr = connexion.cmd.ExecuteReader();
                            if (connexion.dr.HasRows)
                            {
                                XtraMessageBox.Show("l'opération  " + cmbmise.Text + " Existe déja pour le client : " + cmbmise.Text + " date : " + txtdateop.Text + "", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else
                            {
                                connexion.deconnecter();
                                connexion.cmd.CommandText = @"INSERT INTO Tdepot (codeclt, dateop, montant, commentaire, iduser, datecreation,idmise,mise,nbrecase,idafect,numdepot)VALUES(@codeclt, @dateop, @montant, @commentaire, @iduser, @datecreation,@idmise,@mise,@nbrecase,@idafect,@numdepot)";
                                connexion.cmd.Parameters.AddWithValue("@codeclt", txtcode.Text);
                                connexion.cmd.Parameters.AddWithValue("@dateop", txtdateop.Text.Substring(0, 10).ToString());
                                connexion.cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(txtmontant.Text));
                                connexion.cmd.Parameters.AddWithValue("@commentaire", txtcommentaire.Text.Replace("'", "'"));
                                connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                                connexion.cmd.Parameters.AddWithValue("@datecreation", DateTime.Now.ToString());
                                connexion.cmd.Parameters.AddWithValue("@idmise", txtidmise.Text);
                                connexion.cmd.Parameters.AddWithValue("@mise", Convert.ToDouble(txtmise.Text));
                                connexion.cmd.Parameters.AddWithValue("@nbrecase", txtnbrecase.Text);
                                connexion.cmd.Parameters.AddWithValue("@idafect", txtidafect.Text);
                                connexion.cmd.Parameters.AddWithValue("@numdepot", txtnum_depot.Text);
                                connexion.connecter();
                                connexion.cmd.ExecuteNonQuery();
                                connexion.deconnecter();
                                XtraMessageBox.Show("enregistrement effectuée");
                                num_depot();
                                this.tgridtontineclientTableAdapter.Fill(dataSet1.Tgridtontineclient, menu._codeclient);
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

                    if (string.IsNullOrEmpty(txtnbrecase.Text))
                    {
                        XtraMessageBox.Show("Veuillez renseigner le nombre de case ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtnbrecase.Focus();
                        return;
                    }
                    if (Convert.ToInt32(txtmontant.EditValue) == 0)
                    {
                        XtraMessageBox.Show("Renseigner le montant à cotiser ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        return;
                    }
                    if (Convert.ToInt32(txtnbrecase.EditValue) == 0)
                    {
                        XtraMessageBox.Show("verifier le montant à cotiser ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmontant.Focus();
                        return;
                    }
                    if (Convert.ToDouble(txtmontant.EditValue) < (Convert.ToDouble(txtmise.EditValue)))
                    {
                        XtraMessageBox.Show("le montant à cotiser est inferieur à la mise", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                            connexion.cmd.CommandText = @"UPDATE Tdepot SET codeclt=@codeclt, dateop=@dateop, montant=@montant, commentaire=@commentaire, iduser=@iduser, idmise=@idmise,mise=@mise, nbrecase=@nbrecase,datemodif=@datemodif  WHERE codeop='" + txtcodeop.EditValue + "'";
                            connexion.cmd.Parameters.AddWithValue("@codeclt", txtcode.Text);
                            connexion.cmd.Parameters.AddWithValue("@dateop", txtdateop.Text.Substring(0, 10));
                            connexion.cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(txtmontant.Text));
                            connexion.cmd.Parameters.AddWithValue("@commentaire", txtcommentaire.Text.Replace("'", "'"));
                            connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                            connexion.cmd.Parameters.AddWithValue("@datemodif", DateTime.Now.ToString());
                            connexion.cmd.Parameters.AddWithValue("@idmise", txtidmise.Text);
                            connexion.cmd.Parameters.AddWithValue("@mise", txtmise.Text);
                            connexion.cmd.Parameters.AddWithValue("@nbrecase", txtnbrecase.Text);
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                            this.tgridtontineclientTableAdapter.Fill(dataSet1.Tgridtontineclient, menu._codeclient);
                            XtraMessageBox.Show("Modification effectuée");
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 1)
            {

                txtcodeop.EditValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("codeop").ToString());
                txtidmise.EditValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("idmise").ToString());
                cmbmise.EditValue = gridView1.GetFocusedRowCellValue("mise").ToString();
                txtidafect.EditValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("idafect").ToString());
                txtmise.EditValue = gridView1.GetFocusedRowCellValue("mise").ToString();
                txtdateop.EditValue = gridView1.GetFocusedRowCellValue("dateop");
                txtmontant.EditValue = gridView1.GetFocusedRowCellValue("montant").ToString();
                txtcommentaire.Text = gridView1.GetFocusedRowCellValue("commentaire").ToString();
                txtnbrecase.Text = Convert.ToInt32(gridView1.GetFocusedRowCellValue("nbrecase")).ToString();
                Btok.Enabled = false;
               // verification_tontine_client_existe();
               // verification_montant_restant();
                // txtreste.EditValue =Convert.ToDouble( txtmontant.EditValue) -Convert.ToDouble( txtprixvente.EditValue);
            }
        }

        private void txtmontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtnbrecase.EditValue = (Convert.ToInt32(txtmontant.EditValue) / Convert.ToInt32(txtmise.EditValue));
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
                    connexion.cmd.CommandText = ("DELETE Tdepot WHERE codeclt='" + txtcode.Text + "' AND codeop='" + txtcodeop.Text + "'");
                    connexion.connecter();
                    connexion.cmd.ExecuteNonQuery();
                    this.tgridtontineclientTableAdapter.Fill(dataSet1.Tgridtontineclient, menu._codeclient);
                    XtraMessageBox.Show("Suppression effectuée ");
                    //verification_montant_restant();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Une erreur s'est produite ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void txtmontant_Leave(object sender, EventArgs e)
        {
            //        if (Convert.ToDouble(txtmontant.EditValue) < (Convert.ToDouble(txtmise.EditValue)))
            //{
            //    XtraMessageBox.Show("le montant à cotiser est inferieur à la mise", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    txtmontant.Focus();
            //    txtmontant.EditValue = 0;
            //    return;
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }
    }
}

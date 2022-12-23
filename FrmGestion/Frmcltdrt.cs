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
    public partial class Frmcltdrt : DevExpress.XtraEditors.XtraUserControl
    {
        Frmcltgauche menu;
        public string _Codeclt;
        public Frmcltdrt(Frmcltgauche en)
        {
            InitializeComponent();
            menu = en;
           
        }
        private void Vider()
        {
            //txtnom.EditValue = "";
            ////txtNif.EditValue = "";
            //txtville.EditValue = "";
            //txtadresse.EditValue = "";
            //txttel1.EditValue = "";
            //txttel2.EditValue = "";
     
        }
        //creation de numero autoincrement
        private void autonum_matricule()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("EXECUTE  num_client ");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    txtcode.EditValue = connexion.dr.GetString(0);
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                // XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void update_client()
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous modifiez?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (txtnom.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez renseigner les champs ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtnom.Focus();
                        return;
                    }
                    

                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.deconnecter();
                            connexion.cmd.CommandText = @"UPDATE Tclient SET  nomclt=@nomclt, prenom=@prenom, sexe=@sexe, adresse=@adresse, tel1=@tel1, tel2=@tel2, DtModification=@DtModification,iduser=@iduser,fonction=@fonction WHERE Codeclt='" + txtcode.EditValue + "'";
                          //  connexion.cmd.Parameters.AddWithValue("@codeclt", txtcode.EditValue);
                            connexion.cmd.Parameters.AddWithValue("@nomclt", txtnom.Text.Replace("'", "'"));
                            connexion.cmd.Parameters.AddWithValue("@prenom", txtprenom.Text);
                            connexion.cmd.Parameters.AddWithValue("@sexe", cmbsexe.Text);
                            connexion.cmd.Parameters.AddWithValue("@adresse", txtadresse.Text);
                            connexion.cmd.Parameters.AddWithValue("@tel1", txttel1.Text);
                            connexion.cmd.Parameters.AddWithValue("@tel2", txttel2.Text);
                            connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                            connexion.cmd.Parameters.AddWithValue("@fonction", txtfonction.Text);
                            connexion.cmd.Parameters.AddWithValue("@DtModification", DateTime.Now.ToString());
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                            menu.Displaygrid();
                            XtraMessageBox.Show("Modification effectuée");
                            Vider();
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

                   
                    
                    if (string.IsNullOrEmpty(cmbsexe.Text))
                    {
                        XtraMessageBox.Show("Veuillez selectionner le sexe ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbsexe.Focus();
                        return;
                    }
                    
                    else
                        try
                        {
                            autonum_matricule();
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = "SELECT codeclt FROM Tclient WHERE  codeclt='" + txtcode.EditValue + "'";
                            connexion.connecter();
                            connexion.dr = connexion.cmd.ExecuteReader();
                            if (connexion.dr.HasRows)
                            {
                                XtraMessageBox.Show("le client  " + txtnom.Text + "  " + 0 + "   Existe déja");
                            }
                            else
                            {
                                //ClassConnexion connexion = new ClassConnexion();
                               // connexion.connecter();
                               // connexion.cmd.Connection = connexion.con;
                                connexion.deconnecter();
                                connexion.cmd.CommandText = @"INSERT INTO Tclient (codeclt,nomclt, prenom, sexe, adresse, tel1, tel2, codecol, idzone, typeclt,DtCreation, iduser,fonction)VALUES(@codeclt,@nomclt, @prenom, @sexe, @adresse, @tel1, @tel2, @codecol, @idzone,@typeclt, @DtCreation, @iduser,@fonction)";
                                connexion.cmd.Parameters.AddWithValue("@codeclt", txtcode.EditValue);
                                connexion.cmd.Parameters.AddWithValue("@nomclt", txtnom.Text.Replace("'", "'"));
                                connexion.cmd.Parameters.AddWithValue("@prenom", txtprenom.Text.Replace("'", "'"));
                                connexion.cmd.Parameters.AddWithValue("@sexe", cmbsexe.Text);
                                connexion.cmd.Parameters.AddWithValue("@adresse", txtadresse.Text);
                                connexion.cmd.Parameters.AddWithValue("@tel1", txttel1.Text);
                                connexion.cmd.Parameters.AddWithValue("@tel2", txttel2.Text);
                                connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                                connexion.cmd.Parameters.AddWithValue("@fonction", txtfonction.Text);
                                connexion.cmd.Parameters.AddWithValue("@DtCreation", DateTime.Now.ToString());
                                connexion.connecter();
                                connexion.cmd.ExecuteNonQuery();
                                connexion.deconnecter();
                                menu.Displaygrid();
                                XtraMessageBox.Show("enregistrement effectuée");
                                Vider();
                            }
                        }
                        // connexion.deconnecter();

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

        private void btupdate_Click(object sender, EventArgs e)
        {
            update_client();
        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }
       
        private void cmbzone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbcollecteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbcollecteur_Click(object sender, EventArgs e)
        {
           // this.tcollecteurTableAdapter.Fill(dataSet1.Tcollecteur);
        }

        private void gridLookUpEdit1View_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbcollecteur_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

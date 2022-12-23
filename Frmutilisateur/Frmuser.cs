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

namespace suivibouteilles.Frmutilisateur
{
    public partial class Frmuser : DevExpress.XtraEditors.XtraUserControl
    {
        public int _idprofil, _iduser;
        string _False = "False";
        Frmutilisateur.Frmusergauche menumere;
        public Frmuser(Frmutilisateur.Frmusergauche menueenf)
        {
            InitializeComponent();
            menumere = menueenf;
            DisplayProfil();
            TxtPassword.Properties.PasswordChar = '*';
        }
        //Display TProfil
        public void DisplayProfil()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT idprofil, Libprofil FROM TProfil");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    string profil = connexion.dr.GetString(1);
                    cmbprofil.Properties.Items.Add(profil);
                    //this.cmbTypeclasse.SelectedIndex = 0;
                }
                connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void vider()
        {
            Txtlogin.Text = "";
            TxtPassword.Text = "";
            TxtNom.Text = "";
            txtPrenom.Text = "";
            txtmail.Text = "";
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Veuillez selectioner un Profi " + cmbprofil.Text + "", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
                try
                {
                    if (Txtlogin.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez renseigner le champs ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Txtlogin.Focus();
                        return;
                    }
                    //if (TxtPassword.Text.Equals(""))
                    //{
                    //    XtraMessageBox.Show("Veuillez renseigner un password ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //    TxtPassword.Focus();
                    //    return;
                    //}
                    if (TxtNom.Text == "")
                    {
                        XtraMessageBox.Show("Veuillez renseigner un nom", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        TxtNom.Focus();
                        return;
                    }
                    if (txtPrenom.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez selectionner un prénom ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtPrenom.Focus();
                        return;
                    }
                    else
                        try
                        {

                            {
                                ClassConnexion connexion = new ClassConnexion();
                                connexion.connecter();
                                connexion.cmd.Connection = connexion.con;
                                connexion.cmd.CommandText = @"UPDATE TLogin SET UserName=@UserName, PwdName=@PwdName, NomLogin=@NomLogin, PrenomLogin=@PrenomLogin, Email=@Email,idprofil=@idprofil WHERE iduser='" + _iduser + "'";
                                connexion.cmd.Parameters.AddWithValue("@UserName", Txtlogin.Text);
                                connexion.cmd.Parameters.AddWithValue("@PwdName", TxtPassword.Text);
                                connexion.cmd.Parameters.AddWithValue("@NomLogin", TxtNom.Text);
                                connexion.cmd.Parameters.AddWithValue("@PrenomLogin", txtPrenom.Text);
                                connexion.cmd.Parameters.AddWithValue("@idprofil", _idprofil);
                                connexion.cmd.Parameters.AddWithValue("@Email", txtmail.Text);
                                connexion.connecter();
                                connexion.cmd.ExecuteNonQuery();
                                // insermenu();
                                connexion.deconnecter();
                                menumere.DisplayUser();
                                XtraMessageBox.Show("Modification effectuée");
                                // vider();
                            }
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(ex.ToString());
                        }
                        finally { }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString());
                }
        }

        private void cmbprofil_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT idprofil, Libprofil FROM TProfil WHERE Libprofil='" + cmbprofil.EditValue + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    _idprofil = connexion.dr.GetInt32(0);
                }
                connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btokutilisateur_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Veuillez selectioner un Profi " + cmbprofil.Text + "", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
                try
                {
                    if (Txtlogin.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez renseigner le champs ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Txtlogin.Focus();
                        return;
                    }
                    if (TxtPassword.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez renseigner un password ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        TxtPassword.Focus();
                        return;
                    }
                    if (TxtNom.Text == "")
                    {
                        XtraMessageBox.Show("Veuillez renseigner un nom", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        TxtNom.Focus();
                        return;
                    }
                    if (txtPrenom.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez selectionner un prénom ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtPrenom.Focus();
                        return;
                    }
                    else
                        try
                        {

                            {
                                ClassConnexion connexion = new ClassConnexion();
                                connexion.connecter();
                                connexion.cmd.Connection = connexion.con;
                                connexion.cmd.CommandText = @"INSERT INTO TLogin (UserName, PwdName, NomLogin, PrenomLogin, idprofil, Email,ChangeBase, connexion, changeannee, requete, parametres, menusociete, menuparametrage, menugestionacces, menuclient, btnajoutclient, 
                  btnupdateclient, btndeletclient, btnlisteclient, menugestion, menufrs, btnajoutefrs, btnupdatefrs, btndeletefrs, btnlistefrs, menuarticle, btnajoutarticle, btnupdatearticle, btndeletearticle, btnlistearticle, menuoperation, menubonentree, 
                  btnajouterbe, btnupdatebe, btndeletebe, btnlistebe, btnprintbe, btnhistobe, menubonsortie, btnajouterbs, btnupdatebs, btndeletebs, btnlistebs, btnhistobs, menurapport, menucompteclt, menuetatstock, menujournalentree, 
                  menujournalsortie, menujournalbouteillerendu, menumvt) 
VALUES (@UserName, @PwdName, @NomLogin, @PrenomLogin, @idprofil, @Email,@ChangeBase, @connexion, @changeannee, @requete, @parametres, @menusociete, @menuparametrage, @menugestionacces, @menuclient, @btnajoutclient, 
                  @btnupdateclient, @btndeletclient, @btnlisteclient, @menugestion, @menufrs, @btnajoutefrs, @btnupdatefrs, @btndeletefrs, @btnlistefrs, @menuarticle, @btnajoutarticle, @btnupdatearticle, @btndeletearticle, @btnlistearticle, @menuoperation, @menubonentree, 
                  @btnajouterbe, @btnupdatebe, @btndeletebe, @btnlistebe, @btnprintbe, @btnhistobe, @menubonsortie, @btnajouterbs, @btnupdatebs, @btndeletebs, @btnlistebs, @btnhistobs, @menurapport, @menucompteclt, @menuetatstock, @menujournalentree, 
                  @menujournalsortie, @menujournalbouteillerendu, @menumvt
)";
                                connexion.cmd.Parameters.AddWithValue("@UserName", Txtlogin.Text);
                                connexion.cmd.Parameters.AddWithValue("@PwdName", TxtPassword.Text);
                                connexion.cmd.Parameters.AddWithValue("@NomLogin", TxtNom.Text);
                                connexion.cmd.Parameters.AddWithValue("@PrenomLogin", txtPrenom.Text);
                                connexion.cmd.Parameters.AddWithValue("@idprofil", _idprofil);
                                connexion.cmd.Parameters.AddWithValue("@Email", txtmail.Text);
                                connexion.cmd.Parameters.AddWithValue("@ChangeBase", _False);
                                connexion.cmd.Parameters.AddWithValue("@connexion", "True");
                                connexion.cmd.Parameters.AddWithValue("@changeannee", _False);
                                connexion.cmd.Parameters.AddWithValue("@requete", _False);

                                connexion.cmd.Parameters.AddWithValue("@parametres", _False);
                                connexion.cmd.Parameters.AddWithValue("@menusociete", _False);
                                connexion.cmd.Parameters.AddWithValue("@menuparametrage", _False);
                                connexion.cmd.Parameters.AddWithValue("@menugestionacces", _False);
                                connexion.cmd.Parameters.AddWithValue("@menuclient", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnajoutclient", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnupdateclient", _False);
                                connexion.cmd.Parameters.AddWithValue("@btndeletclient", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnlisteclient", _False);
                                connexion.cmd.Parameters.AddWithValue("@menugestion", _False);
                                connexion.cmd.Parameters.AddWithValue("@menufrs", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnajoutefrs", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnupdatefrs", _False);
                                connexion.cmd.Parameters.AddWithValue("@btndeletefrs", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnlistefrs", _False);
                                connexion.cmd.Parameters.AddWithValue("@menuarticle", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnajoutarticle", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnupdatearticle", _False);
                                connexion.cmd.Parameters.AddWithValue("@btndeletearticle", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnlistearticle", _False);
                                connexion.cmd.Parameters.AddWithValue("@menuoperation", _False);
                                connexion.cmd.Parameters.AddWithValue("@menubonentree", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnajouterbe", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnupdatebe", _False);
                                connexion.cmd.Parameters.AddWithValue("@btndeletebe", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnlistebe", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnprintbe", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnhistobe", _False);
                                connexion.cmd.Parameters.AddWithValue("@menubonsortie", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnajouterbs", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnupdatebs", _False);
                                connexion.cmd.Parameters.AddWithValue("@btndeletebs", _False);
                                connexion.cmd.Parameters.AddWithValue("@btnlistebs", _False);

                                connexion.cmd.Parameters.AddWithValue("@btnhistobs", _False);
                                connexion.cmd.Parameters.AddWithValue("@menurapport", _False);
                                connexion.cmd.Parameters.AddWithValue("@menucompteclt", _False);
                                connexion.cmd.Parameters.AddWithValue("@menuetatstock", _False);
                                connexion.cmd.Parameters.AddWithValue("@menujournalentree", _False);
                                connexion.cmd.Parameters.AddWithValue("@menujournalsortie", _False);
                                connexion.cmd.Parameters.AddWithValue("@menujournalbouteillerendu", _False);
                                connexion.cmd.Parameters.AddWithValue("@menumvt", _False);
                                connexion.cmd.ExecuteNonQuery();
                                connexion.deconnecter();
                                menumere.DisplayUser();
                                XtraMessageBox.Show("Opération effectuée");
                                vider();
                            }
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(ex.ToString());
                        }
                        finally { }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString());
                }
        }

    }
}
    

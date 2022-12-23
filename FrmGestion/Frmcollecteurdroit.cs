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
using System.Data.SqlClient;

namespace suivibouteilles.FrmGestion
{
    public partial class Frmcollecteurdroit : DevExpress.XtraEditors.XtraUserControl
    {
        Frmcollecteurgauche menu;
        public Frmcollecteurdroit(Frmcollecteurgauche en)
        {
            InitializeComponent();
            menu = en;
        }
        //creation de numero autoincrement
        private void autonum_matricule()
        {
            try
            {
                // string customId = string.Empty;
                // DateTime dt = DateTime.Now;
                //customId = dt.ToString("yyyyMMdd");
                // string format = "Reçu";
                ClassConnexion connexion = new ClassConnexion();
                connexion.connecter();
                connexion.cmd.Connection = connexion.con;
                connexion.cmd.CommandText = ("SELECT Count(code) AS Roun From Tcollecteur");
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                connexion.dr.Read();
                if ((!connexion.dr.HasRows) || (connexion.dr.IsDBNull(0)))
                {
                    //txtNo.Text = "1";
                    //txtIdRef.Text = format + customId + "0001";
                    txtNo.Text = "1";
                    // txtIdRef.Text = format + customId
                }
                else
                {
                    int newid = Convert.ToInt32(connexion.dr.GetInt32(0));
                    newid++;
                    txtNo.Text = newid.ToString();
                    txtIdRef.Text = newid.ToString("COLL00000");
                    txtcode.EditValue = txtIdRef.Text;
                    // txtIdRef.Text = format + customId + newid.ToString("0000");
                }
                connexion.deconnecter();
                //connexion.dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generator Auto" + ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void labelControl14_Click(object sender, EventArgs e)
        {

        }
        private void update()
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
                            connexion.cmd.CommandText = @"UPDATE Tcollecteur SET  nom=@nom, prenom=@prenom, sexe=@sexe, datenaissance=@datenaissance, adresse=@adresse, tel1=@tel1, tel2=@tel2, nomp=@nomp, prenomp=@prenomp, adressep=@adressep, tel1p=@tel1p, tel2p=@tel2p , iduser=@iduser,DtModification=@DtModification WHERE code='" + txtcode.Text + "'";
                            connexion.cmd.Parameters.AddWithValue("@code", txtcode.Text);
                            connexion.cmd.Parameters.AddWithValue("@nom", txtnom.Text.Replace("'", "'"));
                            connexion.cmd.Parameters.AddWithValue("@prenom", txtprenom.Text.Replace("'", "'"));
                            connexion.cmd.Parameters.AddWithValue("@sexe", cmbsexe.Text);
                            // connexion.cmd.Parameters.AddWithValue("@datenaissance", txtdatenaissance.Text.Substring(0,10));
                            if (string.IsNullOrEmpty(dateEdit1.Text))
                            {
                                connexion.cmd.Parameters.Add(new SqlParameter("@datenaissance", DBNull.Value));
                            }
                            else
                            {
                                connexion.cmd.Parameters.Add(new SqlParameter("@datenaissance", dateEdit1.Text.Substring(0, 10)));
                            }
                            connexion.cmd.Parameters.AddWithValue("@adresse", txtadresse.Text.Replace("'", "'"));
                            connexion.cmd.Parameters.AddWithValue("@tel1", txttel1.Text);
                            connexion.cmd.Parameters.AddWithValue("@tel2", txttel2.Text);
                            connexion.cmd.Parameters.AddWithValue("@nomp", txtnomp.Text.Replace("'", "'"));
                            connexion.cmd.Parameters.AddWithValue("@prenomp", txtprenomp.Text.Replace("'", "'"));
                            connexion.cmd.Parameters.AddWithValue("@adressep", txtadressep.Text.Replace("'", "'"));
                            connexion.cmd.Parameters.AddWithValue("@tel1p", txttel1p.Text);
                            connexion.cmd.Parameters.AddWithValue("@tel2p", txttel2p.Text);
                            connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                            connexion.cmd.Parameters.AddWithValue("@DtModification", DateTime.Now.ToString());
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                            menu.Displaygrid();
                            XtraMessageBox.Show("Modification effectuée");
                            //Vider();
                        }
                        catch (Exception)
                        {
                           // XtraMessageBox.Show(ex.ToString());
                            XtraMessageBox.Show("Une erreur s'est produite ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        finally { }
                }
                catch (Exception)
                {
                    //XtraMessageBox.Show(ex.ToString());
                    XtraMessageBox.Show("Une erreur s'est produite ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
        }
        private void Btok_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous l'enregistrement?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (txtnom.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez le nom ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtnom.Focus();
                        return;
                    }

                    //if (textEdit2.Text.Equals(""))
                    //{
                    //    XtraMessageBox.Show("Veuillez renseigner le prénom(s) ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //    textEdit2.Focus();
                    //    return;
                    //}
                    //if (textEdit3.Text.Equals(""))
                    //{
                    //    XtraMessageBox.Show("Veuillez renseigner l'adresse ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //    textEdit3.Focus();
                    //    return;
                    //}
                    //if (textEdit4.Text.Equals(""))
                    //{
                    //    XtraMessageBox.Show("Veuillez renseigner le numéro téléphone ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //    textEdit4.Focus();
                    //    return;
                    //}
                    else
                        try
                        {
                          //  autonum_matricule();
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = "SELECT code FROM Tcollecteur WHERE  code='" + txtcode.Text +"'";
                            connexion.connecter();
                            connexion.dr = connexion.cmd.ExecuteReader();
                            if (connexion.dr.HasRows)
                            {
                                XtraMessageBox.Show("le code  " + txtcode.Text + "  " + 0 + "   Existe déja");
                            }
                            else
                            {
                                connexion.deconnecter();
                                connexion.cmd.CommandText = @"INSERT INTO Tcollecteur (nom, prenom, sexe, datenaissance, adresse, tel1, tel2, nomp, prenomp, adressep, tel1p, tel2p, iduser, DtCreation)VALUES(@nom, @prenom, @sexe, @datenaissance, @adresse, @tel1, @tel2, @nomp, @prenomp, @adressep, @tel1p, @tel2p, @iduser, @DtCreation)";
                               // connexion.cmd.Parameters.AddWithValue("@code", txtcode.Text);
                                connexion.cmd.Parameters.AddWithValue("@nom", txtnom.Text.Replace("'", "'"));
                                connexion.cmd.Parameters.AddWithValue("@prenom", txtprenom.Text.Replace("'", "'"));
                                connexion.cmd.Parameters.AddWithValue("@sexe", cmbsexe.Text);
                                // connexion.cmd.Parameters.AddWithValue("@datenaissance", txtdatenaissance.Text.Substring(0,10));
                                if (string.IsNullOrEmpty(dateEdit1.Text))
                                {
                                    connexion.cmd.Parameters.Add(new SqlParameter("@datenaissance", DBNull.Value));
                                }
                                else
                                {
                                    connexion.cmd.Parameters.Add(new SqlParameter("@datenaissance", dateEdit1.EditValue));
                                }
                                connexion.cmd.Parameters.AddWithValue("@adresse", txtadresse.Text.Replace("'", "'"));
                                connexion.cmd.Parameters.AddWithValue("@tel1", txttel1.Text);
                                connexion.cmd.Parameters.AddWithValue("@tel2", txttel2.Text);
                                connexion.cmd.Parameters.AddWithValue("@nomp", txtnomp.Text.Replace("'", "'"));
                                connexion.cmd.Parameters.AddWithValue("@prenomp", txtprenomp.Text.Replace("'", "'"));
                                connexion.cmd.Parameters.AddWithValue("@adressep", txtadressep.Text.Replace("'", "'"));
                                connexion.cmd.Parameters.AddWithValue("@tel1p", txttel1p.Text);
                                connexion.cmd.Parameters.AddWithValue("@tel2p", txttel2p.Text);
                                connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                                connexion.cmd.Parameters.AddWithValue("@DtCreation", DateTime.Now.ToString());
                                connexion.connecter();
                                connexion.cmd.ExecuteNonQuery();
                                connexion.deconnecter();
                                menu.Displaygrid();
                                XtraMessageBox.Show("enregistrement effectuée");

                             //   Vider();
                            }
                            connexion.deconnecter();
                        }
                        catch (Exception)
                        {
                            // XtraMessageBox.Show(ex.ToString());
                            XtraMessageBox.Show("Une erreur s'est produite ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        finally { }
                }
                catch (Exception)
                {
                    //XtraMessageBox.Show(ex.ToString());
                    XtraMessageBox.Show("Une erreur s'est produite ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}

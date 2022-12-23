using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using suivibouteilles.Classes;

namespace suivibouteilles.FrmGestion
{
    public partial class Frmajouterclient : DevExpress.XtraEditors.XtraForm
    {
        FrmMenu.Menu menu;
        public Frmajouterclient(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
        }
        private void Vider()
        {
            txtnom.EditValue = "";
            txtNif.EditValue = "";
            txtville.EditValue = "";
            txtadresse.EditValue = "";

            txttel1.EditValue = "";
            txttel2.EditValue = "";
            txtsiteweb.EditValue = "";
        }
        //private void update_client()
        //{
        //    DialogResult result = XtraMessageBox.Show("Voulez vous modifiez?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        //    if (result == DialogResult.Yes)
        //        try
        //        {
        //            if (txtnom.Text.Equals(""))
        //            {
        //                XtraMessageBox.Show("Veuillez renseigner les champs ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                txtnom.Focus();
        //                return;
        //            }
        //            else
        //                try
        //                {
        //                    ClassConnexion connexion = new ClassConnexion();
        //                    connexion.connecter();
        //                    connexion.cmd.Connection = connexion.con;
        //                    connexion.deconnecter();
        //                    connexion.cmd.CommandText = @"UPDATE Tclient SET Nomclt=@Nomclt, Adresse=@Adresse, Ville=@Ville, Nif=@Nif, Telephone1=@Telephone1, Telephone2=@Telephone2, SiteWeb=@SiteWeb, DtModification=@DtModification,iduser=@iduser WHERE Codeclt='" + _Codeclt + "'";
        //                    connexion.cmd.Parameters.AddWithValue("@Nomclt", txtnom.Text);
        //                    connexion.cmd.Parameters.AddWithValue("@Adresse", txtNif.Text);
        //                    connexion.cmd.Parameters.AddWithValue("@Ville", txtville.Text);
        //                    connexion.cmd.Parameters.AddWithValue("@Nif", txtadresse.Text);
        //                    connexion.cmd.Parameters.AddWithValue("@Telephone1", txttel1.Text);
        //                    connexion.cmd.Parameters.AddWithValue("@Telephone2", txttel2.Text);
        //                    connexion.cmd.Parameters.AddWithValue("@SiteWeb", txtsiteweb.Text);
        //                    connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
        //                    connexion.cmd.Parameters.AddWithValue("@DtModification", DateTime.Now.ToString());
        //                    connexion.connecter();
        //                    connexion.cmd.ExecuteNonQuery();
        //                    connexion.deconnecter();
        //                  //  menu.Displaygrid();
        //                    XtraMessageBox.Show("Modification effectuée");
        //                    Vider();
        //                }
        //                catch (Exception ex)
        //                {
        //                    XtraMessageBox.Show(ex.ToString());
        //                }
        //                finally { }
        //        }
        //        catch (Exception ex)
        //        {
        //            XtraMessageBox.Show(ex.ToString());
        //        }
        //}
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
                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = "SELECT Nomclt FROM Tclient WHERE  Nomclt='" + txtnom.Text.Replace("'", "''") + "'";
                            connexion.connecter();
                            connexion.dr = connexion.cmd.ExecuteReader();
                            if (connexion.dr.HasRows)
                            {
                                XtraMessageBox.Show("le client  " + txtnom.Text + "  " + txtNif.Text + "   Existe déja");
                            }
                            else
                            {
                                connexion.deconnecter();
                                connexion.cmd.CommandText = @"INSERT INTO Tclient (Nomclt, Adresse, Ville, Nif, Telephone1, Telephone2, SiteWeb, DtCreation)VALUES(@Nomclt, @Adresse, @Ville, @Nif, @Telephone1, @Telephone2, @SiteWeb, @DtCreation)";
                                connexion.cmd.Parameters.AddWithValue("@Nomclt", txtnom.Text);
                                connexion.cmd.Parameters.AddWithValue("@Adresse", txtNif.Text);
                                connexion.cmd.Parameters.AddWithValue("@Ville", txtville.Text);
                                connexion.cmd.Parameters.AddWithValue("@Nif", txtadresse.Text);
                                connexion.cmd.Parameters.AddWithValue("@Telephone1", txttel1.Text);
                                connexion.cmd.Parameters.AddWithValue("@Telephone2", txttel2.Text);
                                connexion.cmd.Parameters.AddWithValue("@SiteWeb", txtsiteweb.Text);
                               // connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                                connexion.cmd.Parameters.AddWithValue("@DtCreation", DateTime.Now.ToString());
                                connexion.connecter();
                                connexion.cmd.ExecuteNonQuery();
                                connexion.deconnecter();
                               // menu.Displaygrid();
                                XtraMessageBox.Show("enregistrement effectuée");
                                Vider();
                            }
                            connexion.deconnecter();
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

        private void btupdate_Click(object sender, EventArgs e)
        {
        
        }
    }
}
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
    public partial class FrmFrsdroite : DevExpress.XtraEditors.XtraUserControl
    {
        public int _Codefrs;
        FrmGestion.FrmFrsgauche menu;
        public FrmFrsdroite(FrmGestion.FrmFrsgauche en)
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
        private void update_fournisseur()
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
                            connexion.cmd.CommandText = @"UPDATE Tfournisseur SET Nomfrs=@Nomfrs, Adresse=@Adresse, Ville=@Ville, Nif=@Nif, Telephone1=@Telephone1, Telephone2=@Telephone2, SiteWeb=@SiteWeb, DtModification=@DtModification,iduser=@iduser WHERE Codefrs='" + _Codefrs + "'";
                            connexion.cmd.Parameters.AddWithValue("@Nomfrs", txtnom.Text);
                            connexion.cmd.Parameters.AddWithValue("@Adresse", txtadresse.Text);
                            connexion.cmd.Parameters.AddWithValue("@Ville", txtville.Text);
                            connexion.cmd.Parameters.AddWithValue("@Nif", txtNif.Text);
                            connexion.cmd.Parameters.AddWithValue("@Telephone1", txttel1.Text);
                            connexion.cmd.Parameters.AddWithValue("@Telephone2", txttel2.Text);
                            connexion.cmd.Parameters.AddWithValue("@SiteWeb", txtsiteweb.Text);
                            connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                            connexion.cmd.Parameters.AddWithValue("@DtModification", DateTime.Now.ToString());
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                            menu.Displaygrid();
                            XtraMessageBox.Show("Modification effectuée");
                            Vider();
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
        private void Btok_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous l'enregistrement?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (txtnom.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez le nom du fourniseur ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtnom.Focus();
                        return;
                    }
                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = "SELECT Nomfrs FROM Tfournisseur WHERE  Nomfrs='" + txtnom.Text.Replace("'", "''") + "'";
                            connexion.connecter();
                            connexion.dr = connexion.cmd.ExecuteReader();
                            if (connexion.dr.HasRows)
                            {
                                XtraMessageBox.Show("le client  " + txtnom.Text + "  " + txtNif.Text + "   Existe déja");
                            }
                            else
                            {
                                connexion.deconnecter();
                                connexion.cmd.CommandText = @"INSERT INTO Tfournisseur (Nomfrs, Adresse, Ville, Nif, Telephone1, Telephone2, SiteWeb, DtCreation,iduser)VALUES(@Nomfrs, @Adresse, @Ville, @Nif, @Telephone1, @Telephone2, @SiteWeb, @DtCreation,@iduser)";
                                connexion.cmd.Parameters.AddWithValue("@Nomfrs", txtnom.Text);
                                connexion.cmd.Parameters.AddWithValue("@Adresse", txtNif.Text);
                                connexion.cmd.Parameters.AddWithValue("@Ville", txtville.Text);
                                connexion.cmd.Parameters.AddWithValue("@Nif", txtadresse.Text);
                                connexion.cmd.Parameters.AddWithValue("@Telephone1", txttel1.Text);
                                connexion.cmd.Parameters.AddWithValue("@Telephone2", txttel2.Text);
                                connexion.cmd.Parameters.AddWithValue("@SiteWeb", txtsiteweb.Text);
                                connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                                connexion.cmd.Parameters.AddWithValue("@DtCreation", DateTime.Now.ToString());
                                connexion.connecter();
                                connexion.cmd.ExecuteNonQuery();
                                connexion.deconnecter();
                                menu.Displaygrid();
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
            update_fournisseur();
        }
    }
}

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
    public partial class Frmarticledrt : DevExpress.XtraEditors.XtraUserControl
    {
        Frmarticlegauche menu;
        int _CodeCat, _Codesous;
        public Frmarticledrt(Frmarticlegauche en)
        {
            InitializeComponent();
            menu = en;
         
            DisplayCategorie();
            DisplaySousCategorie();
            Display_park_produits();
        
        }
        public void _Display_stock_article()
        {
            tmp_stock_articleTableAdapter.Fill(dataSetEtat.tmp_stock_article, txtcodeart.Text);
        }
        //Appel mode reglement
        public void Display_park_produits()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT codepark, libelle, mise FROM Tpark");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    string zone = connexion.dr.GetString(1);
                    cmbparkproduit.Properties.Items.Add(zone);
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
        //creation de numero autoincrement
        private void autonum_matricule()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("EXECUTE num_article");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    txtcodeart.EditValue = connexion.dr.GetString(0);
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                // XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DisplayCategorie()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT CodeCat, DesiCat FROM Tcategorie");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    string categorie = connexion.dr.GetString(1);
                    cmbcategorie.Properties.Items.Add(categorie);
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                //XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplaySousCategorie()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT Codesous, DesiSousCat FROM Tsouscat");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    string souscategorie = connexion.dr.GetString(1);
                    cmbsouscategorie.Properties.Items.Add(souscategorie);
                    this.cmbsouscategorie.SelectedIndex = 0;
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                //XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbcategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Vider()
        {
            //txtcodeart.Text = "";
            //txtdesignation.Text = "";
            //txtdescription.Text = "";
            //cmbcategorie.Text = "";
            //cmbsouscategorie.Text = "";
            ////txtcapacite.Text = "";
            ////txtnumero.Text = "";
        }
        private void fonction_Insert_article()
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous l'enregistrement?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    //if (txtcodeart.Text.Equals(""))
                    //{
                    //    XtraMessageBox.Show("Veuillez le nom ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //    txtcodeart.Focus();
                    //    return;
                    //}
                    if (string.IsNullOrEmpty(txtdesignation.Text))
                    {
                        XtraMessageBox.Show("Veuillez renseigner la Désignation de l'article ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtdesignation.Focus();
                        return;
                    }
                  
                     if (string.IsNullOrEmpty(cmbcategorie.Text))
                        {
                        XtraMessageBox.Show("Veuillez selectionner une Catégorie ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbcategorie.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(cmbsouscategorie.Text))
                    {
                        XtraMessageBox.Show("Veuillez selectionner une Sous-Catégorie ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbsouscategorie.Focus();
                        return;
                    }
                    else
                        try
                        {
                            autonum_matricule();
                               ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = "SELECT CodeArt FROM Tarticle WHERE  CodeArt='" + txtcodeart.EditValue + "'";
                            connexion.connecter();
                            connexion.dr = connexion.cmd.ExecuteReader();
                            if (connexion.dr.HasRows)
                            {
                                XtraMessageBox.Show("le code  " + txtcodeart.Text + "  Existe déja");
                            }
                            else
                            {
                                connexion.deconnecter();
                                connexion.cmd.CommandText = @"INSERT INTO Tarticle (CodeArt, Designation1, Designation2, CodeCat, Codesous,codepark,prixachat,prixvente, iduser,DtCreation)VALUES(@CodeArt,@Designation1,@Designation2,@CodeCat,@Codesous,@codepark,@prixachat,@prixvente,@iduser,@DtCreation)";
                                connexion.cmd.Parameters.AddWithValue("@CodeArt", txtcodeart.EditValue);
                                connexion.cmd.Parameters.AddWithValue("@Designation1", txtdesignation.Text);
                                connexion.cmd.Parameters.AddWithValue("@Designation2", txtdescription.Text);
                                connexion.cmd.Parameters.AddWithValue("@prixachat",Convert.ToDouble( txtprixachat.EditValue));
                                connexion.cmd.Parameters.AddWithValue("@prixvente",Convert.ToDouble( txtprixvente.EditValue));
                                connexion.cmd.Parameters.AddWithValue("@CodeCat", _CodeCat);
                                connexion.cmd.Parameters.AddWithValue("@Codesous", _Codesous);
                                connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                                connexion.cmd.Parameters.AddWithValue("@DtCreation", DateTime.Now.ToString());
                                connexion.cmd.Parameters.AddWithValue("@codepark", txtcodepark.EditValue);
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
                           // XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally { }
                }
                catch (Exception)
                {
                    //XtraMessageBox.Show(ex.ToString());
                    XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void fonction_update_article()
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous modifier?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (string.IsNullOrEmpty(txtdesignation.Text))
                    {
                        XtraMessageBox.Show("Veuillez renseigner la Désignation de l'article ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtdesignation.Focus();
                        return;
                    }

                    if (string.IsNullOrEmpty(cmbcategorie.Text))
                    {
                        XtraMessageBox.Show("Veuillez selectionner une Catégorie ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbcategorie.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(cmbsouscategorie.Text))
                    {
                        XtraMessageBox.Show("Veuillez selectionner une Sous-Catégorie ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbsouscategorie.Focus();
                        return;
                    }
                    else
                        try
                        {
                           // autonum_matricule();
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.deconnecter();
                            connexion.cmd.CommandText = @"UPDATE Tarticle SET Designation1=@Designation1, Designation2=@Designation2, CodeCat=@CodeCat, Codesous=@Codesous,codepark=@codepark,mise=@mise,prixachat=@prixachat, prixvente=@prixvente, iduser=@iduser  WHERE CodeArt='" + txtcodeart.EditValue + "'";
                            connexion.cmd.Parameters.AddWithValue("@Designation1", txtdesignation.Text.Replace("'", "'"));
                            connexion.cmd.Parameters.AddWithValue("@Designation2", txtdescription.Text.Replace("'", "'"));
                            connexion.cmd.Parameters.AddWithValue("@mise", Convert.ToDouble(txtmise.Text));
                            connexion.cmd.Parameters.AddWithValue("@prixachat", Convert.ToDouble(txtprixachat.EditValue));
                            connexion.cmd.Parameters.AddWithValue("@prixvente", Convert.ToDouble(txtprixvente.EditValue));
                           // connexion.cmd.Parameters.AddWithValue("@Designation2", txtdescription.Text.Replace("'", "'"));
                            connexion.cmd.Parameters.AddWithValue("@CodeCat", _CodeCat);
                            connexion.cmd.Parameters.AddWithValue("@Codesous", _Codesous);
                            connexion.cmd.Parameters.AddWithValue("@iduser", menu._iduser);
                            connexion.cmd.Parameters.AddWithValue("@Dtmodif", DateTime.Now.ToString());
                            connexion.cmd.Parameters.AddWithValue("@codepark", txtcodepark.EditValue);
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
                catch (Exception )
                {
                    //XtraMessageBox.Show(ex.ToString());
                    XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void Btok_Click(object sender, EventArgs e)
        {
            fonction_Insert_article();
        }

        private void Btupdate_Click(object sender, EventArgs e)
        {
            fonction_update_article();
        }

      

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            autonum_matricule();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbparkproduit_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT codepark, libelle, mise FROM Tpark WHERE  libelle='" + cmbparkproduit.EditValue + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    txtcodepark.EditValue = connexion.dr.GetInt32(0);
                    txtmise.EditValue = connexion.dr.GetDouble(2);

                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                //XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbcategorie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT CodeCat, DesiCat FROM TCategorie WHERE DesiCat='" + cmbcategorie.Text + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader(0);
                while (connexion.dr.Read())
                {
                    _CodeCat = connexion.dr.GetInt32(0);


                }
                connexion.deconnecter();

            }
            catch (Exception)
            {//XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbsouscategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT  Codesous, DesiSousCat FROM Tsouscat WHERE DesiSousCat='" + cmbsouscategorie.Text + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader(0);
                while (connexion.dr.Read())
                {
                    _Codesous = connexion.dr.GetInt32(0);
                }
                connexion.deconnecter();

            }
            catch (Exception)
            {
                //XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbsouscategorie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT  Codesous, DesiSousCat FROM Tsouscat WHERE DesiSousCat='" + cmbsouscategorie.Text + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader(0);
                while (connexion.dr.Read())
                {
                    _Codesous = connexion.dr.GetInt32(0);
                }
                connexion.deconnecter();

            }
            catch (Exception)
            {
                //XtraMessageBox.Show(ex.ToString());
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

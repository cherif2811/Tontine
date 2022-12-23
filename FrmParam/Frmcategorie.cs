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

namespace suivibouteilles.FrmParam
{
    public partial class Frmcategorie : DevExpress.XtraEditors.XtraUserControl
    {
        int _CodeCat,_idreche, i = 0;
        public Frmcategorie()
        {
            InitializeComponent();
            this.tcategorieTableAdapter.Fill(dataSet1.Tcategorie);
        }
        private void Verification_categorie()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT Count(CodeCat) AS Roun From Tarticle WHERE CodeCat='" + _CodeCat + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    _idreche = connexion.dr.GetInt32(0);
                }
                connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous l'enregistrement?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (textEdit1.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez renseigner les champs ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textEdit1.Focus();
                        return;
                    }

                    //if ((textBox1.Text == "")) { MessageBox.Show("veuillez Saisir les Champs!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = "SELECT DesiCat FROM Tcategorie where DesiCat='" + textEdit1.Text + "'";
                            connexion.connecter();
                            connexion.dr = connexion.cmd.ExecuteReader();
                            if (connexion.dr.HasRows)
                            {
                                XtraMessageBox.Show("Le Code    " + textEdit1.Text + "    Existe déja");
                            }
                            else
                            {
                                connexion.deconnecter();
                                connexion.cmd.CommandText = @"INSERT INTO Tcategorie (DesiCat)VALUES(@DesiCat)";
                                connexion.cmd.Parameters.AddWithValue("@DesiCat", textEdit1.Text);
                                connexion.connecter();
                                connexion.cmd.ExecuteNonQuery();
                                connexion.deconnecter();
                                XtraMessageBox.Show("enregistrement effectuée");
                                this.tcategorieTableAdapter.Fill(dataSet1.Tcategorie);
                                textEdit1.Text = "";

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
            DialogResult result = XtraMessageBox.Show("Voulez vous modifiez?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (textEdit1.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez renseigner les champs ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textEdit1.Focus();
                        return;
                    }
                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.deconnecter();
                            connexion.cmd.CommandText = @"UPDATE Tcategorie SET DesiCat=@DesiCat  WHERE CodeCat='" + _CodeCat + "'";
                            connexion.cmd.Parameters.AddWithValue("@DesiCat", textEdit1.Text);
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                            XtraMessageBox.Show("Modification effectuée");
                            this.tcategorieTableAdapter.Fill(dataSet1.Tcategorie);
                            textEdit1.Text = "";
                           
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           
            btOk.Enabled = false;
            if (gridView1.SelectedRowsCount == 1)
            {
                _CodeCat = Convert.ToInt32(gridView1.GetFocusedRowCellValue("CodeCat").ToString());
                textEdit1.Text = gridView1.GetFocusedRowCellValue("DesiCat").ToString();
                Verification_categorie();
            }
        }
        //fonction delete la Categorie
        private void deletecategorie()
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous supprimer  " + textEdit1.EditValue + " ", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                if (textEdit1.Text.Equals(""))
                {
                    XtraMessageBox.Show("Veuillez selectionner une ligne ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textEdit1.Focus();
                    return;
                }
                try
                {
                    ClassConnexion connexion = new ClassConnexion();
                    connexion.connecter();
                    connexion.cmd.Connection = connexion.con;
                    connexion.cmd.CommandText = ("DELETE Tcategorie WHERE CodeCat='" + _CodeCat + "'");
                    connexion.connecter();
                    connexion.cmd.ExecuteNonQuery();
                    this.tcategorieTableAdapter.Fill(dataSet1.Tcategorie);

                    textEdit1.EditValue = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void btdelete_Click(object sender, EventArgs e)
        {
            if (_idreche > i)
            {
                XtraMessageBox.Show("Impossible de supprimer la Catégorie " + textEdit1.EditValue + " car elle est déja utilser ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                deletecategorie();
            }
        }
    }
}

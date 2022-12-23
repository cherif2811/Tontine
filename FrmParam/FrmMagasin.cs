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
    public partial class FrmMagasin : DevExpress.XtraEditors.XtraUserControl
    {
        int _idmag;
        public FrmMagasin()
        {
            InitializeComponent();
            this.tmagasinTableAdapter.Fill(dataSet1.Tmagasin);
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous modifiez?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (textEdit2.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez renseigner les champs ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textEdit2.Focus();
                        return;
                    }
                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.deconnecter();
                            connexion.cmd.CommandText = @"UPDATE Tmagasin SET libelle=@libelle  WHERE idmag='" + _idmag + "'";
                            connexion.cmd.Parameters.AddWithValue("@libelle", textEdit2.Text);
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                            XtraMessageBox.Show("Modification effectuée");
                            this.tmagasinTableAdapter.Fill(dataSet1.Tmagasin);
                            textEdit2.Text = "";
                            BtSaveParametre.Visible = true;
                            BtUpdate.Visible = false;
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

        private void BtSaveParametre_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous l'enregistrement?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (textEdit2.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez renseigner les champs ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textEdit2.Focus();
                        return;
                    }
                  
                    //if ((textBox1.Text == "")) { MessageBox.Show("veuillez Saisir les Champs!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = "SELECT libelle FROM Tmagasin where libelle='" + textEdit2.Text + "'";
                            connexion.connecter();
                            connexion.dr = connexion.cmd.ExecuteReader();
                            if (connexion.dr.HasRows)
                            {
                                XtraMessageBox.Show("Le Code    " + textEdit2.Text + "    Existe déja");
                            }
                            else
                            {
                                connexion.deconnecter();
                                connexion.cmd.CommandText = @"INSERT INTO Tmagasin (libelle)VALUES(@libelle)";
                                connexion.cmd.Parameters.AddWithValue("@libelle", textEdit2.Text);
                                connexion.connecter();
                                connexion.cmd.ExecuteNonQuery();
                                connexion.deconnecter();
                                XtraMessageBox.Show("enregistrement effectuée");
                                this.tmagasinTableAdapter.Fill(dataSet1.Tmagasin);
                                textEdit2.Text = "";
                             
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            BtUpdate.Visible = true;
            BtSaveParametre.Visible = false;
            if (gridView1.SelectedRowsCount == 1)
            {
               _idmag=Convert.ToInt32(gridView1.GetFocusedRowCellValue("idmag").ToString());
                textEdit2.Text = gridView1.GetFocusedRowCellValue("libelle").ToString();
            }
        }
    }
}

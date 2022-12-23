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
    public partial class Frmparametragegeneral : DevExpress.XtraEditors.XtraUserControl
    {
        public Frmparametragegeneral()
        {
            InitializeComponent();
            this.tparamTableAdapter.Fill(dataSet1.Tparam);
        }

        private void BtSaveParametre_Click(object sender, EventArgs e)
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
                    if (textEdit2.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez renseigner les champs ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textEdit2.Focus();
                        return;
                    }
                    if (textEdit3.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez renseigner les champs ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textEdit3.Focus();
                        return;
                    }
                    //if ((textBox1.Text == "")) { MessageBox.Show("veuillez Saisir les Champs!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = "SELECT NumParam FROM TParam where NumParam='" + textEdit1.Text + "'";
                            connexion.connecter();
                            connexion.dr = connexion.cmd.ExecuteReader();
                            if (connexion.dr.HasRows)
                            {
                                XtraMessageBox.Show("Le Code    " + textEdit1.Text + "    Existe déja");
                            }
                            else
                            {
                                connexion.deconnecter();
                                connexion.cmd.CommandText = @"INSERT INTO TParam (NumParam, LibParam, Valeur)VALUES(@NumParam,@LibParam,@Valeur)";
                                connexion.cmd.Parameters.AddWithValue("@NumParam", textEdit1.Text);
                                connexion.cmd.Parameters.AddWithValue("@LibParam", textEdit2.Text);
                                connexion.cmd.Parameters.AddWithValue("@Valeur", textEdit3.Text);
                                connexion.connecter();
                                connexion.cmd.ExecuteNonQuery();
                                connexion.deconnecter();
                                XtraMessageBox.Show("enregistrement effectuée");
                                this.tparamTableAdapter.Fill(dataSet1.Tparam);
                                textEdit1.Text = "";
                                textEdit2.Text = "";
                                textEdit3.Text = "";
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

        private void BtUpdate_Click(object sender, EventArgs e)
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
                    if (textEdit2.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez renseigner les champs ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textEdit2.Focus();
                        return;
                    }
                    if (textEdit3.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez renseigner les champs ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textEdit3.Focus();
                        return;
                    }
                    //if ((textBox1.Text == "")) { MessageBox.Show("veuillez Saisir les Champs!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.deconnecter();
                            connexion.cmd.CommandText = @"UPDATE TParam SET NumParam=@NumParam,LibParam=@LibParam,Valeur=@Valeur WHERE NumParam=@NumParam";
                            connexion.cmd.Parameters.AddWithValue("@NumParam", textEdit1.Text);
                            connexion.cmd.Parameters.AddWithValue("@LibParam", textEdit2.Text);
                            connexion.cmd.Parameters.AddWithValue("@Valeur", textEdit3.Text);
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                            XtraMessageBox.Show("Modification effectuée");
                            this.tparamTableAdapter.Fill(dataSet1.Tparam);
                            textEdit1.Text = "";
                            textEdit2.Text = "";
                            textEdit3.Text = "";
                            textEdit1.Enabled = true;
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

        private void gridView1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            BtUpdate.Visible = true;
            BtSaveParametre.Visible = false;
            if (gridView1.SelectedRowsCount == 1)
            {
                textEdit1.Enabled = false;
                textEdit1.Text = gridView1.GetFocusedRowCellValue("NumParam").ToString();
                textEdit2.Text = gridView1.GetFocusedRowCellValue("LibParam").ToString();
                textEdit3.Text = gridView1.GetFocusedRowCellValue("Valeur").ToString();

            }
        }
    }
}

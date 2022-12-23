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
    public partial class FrmProfilgauche : DevExpress.XtraEditors.XtraUserControl
    {
        int _idprofil;
        public FrmProfilgauche()
        {
            InitializeComponent();
            this.tprofilTableAdapter.Fill(dataSet1.Tprofil);
        }

        private void btokprofil_Click(object sender, EventArgs e)
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
                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = "SELECT * FROM TProfil  WHERE  Libprofil='" + textEdit1.Text + "'";
                            connexion.connecter();
                            connexion.dr = connexion.cmd.ExecuteReader();
                            if (connexion.dr.HasRows)
                            {
                                XtraMessageBox.Show("Le Profil     " + textEdit1.Text + "    Existe déja");
                            }
                            else
                            {
                                connexion.deconnecter();
                                connexion.cmd.CommandText = @"INSERT INTO TProfil (Libprofil)VALUES(@Libprofil)";
                                connexion.cmd.Parameters.AddWithValue("@Libprofil", textEdit1.Text);
                                connexion.connecter();
                                connexion.cmd.ExecuteNonQuery();
                                connexion.deconnecter();
                                this.tprofilTableAdapter.Fill(dataSet1.Tprofil);
                                XtraMessageBox.Show("enregistrement effectuée");
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                _idprofil = Convert.ToInt32(gridView1.GetFocusedRowCellValue("idprofil").ToString());
                textEdit1.Text = gridView1.GetFocusedRowCellValue("Libprofil").ToString();
            }
            btokprofil.Enabled = false;
        }
    }
}

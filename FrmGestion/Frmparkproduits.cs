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
    public partial class Frmparkproduits : DevExpress.XtraEditors.XtraUserControl
    {
        int _id;
        public int _iduser, _idreche, i = 0;
        public Frmparkproduits()
        {
            InitializeComponent();
                                this.tmiseTableAdapter.Fill(dataSet1.Tmise);


        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous l'enregistrement?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (txtmise.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez renseigner la mise du pack ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtmise.Focus();
                        return;
                    }

                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = "SELECT mise FROM Tmise where mise='" + txtmise.EditValue + "'";
                            connexion.connecter();
                            connexion.dr = connexion.cmd.ExecuteReader();
                            if (connexion.dr.HasRows)
                            {
                                XtraMessageBox.Show("La mise   " + txtmise.Text + "    Existe déja ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else
                            {
                                connexion.deconnecter();
                                connexion.cmd.CommandText = @"INSERT INTO Tmise (mise)VALUES(@mise)";
                                connexion.cmd.Parameters.AddWithValue("@mise",Convert.ToDouble( txtmise.Text));
                              //  connexion.cmd.Parameters.AddWithValue("@prix", Convert.ToDouble(txtmontant.Text));
                                connexion.connecter();
                                connexion.cmd.ExecuteNonQuery();
                                connexion.deconnecter();
                                XtraMessageBox.Show("enregistrement effectuée");
                                this.tmiseTableAdapter.Fill(dataSet1.Tmise);
                                txtmise.Text = "";

                            }
                            connexion.deconnecter();
                        }
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
        
        private void _update()
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous modifiez?", " Sauvegarde ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                try
                {
                    if (txtmise.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Veuillez renseigner les champs ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtmise.Focus();
                        return;
                    }
                    else
                        try
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.deconnecter();
                            connexion.cmd.CommandText = @"UPDATE Tmise SET mise=@mise  WHERE id='" + _id + "'";
                            connexion.cmd.Parameters.AddWithValue("@mise", txtmise.Text);
                           // connexion.cmd.Parameters.AddWithValue("@prix", txtmontant.Text);
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                            XtraMessageBox.Show("Modification effectuée");
                                this.tmiseTableAdapter.Fill(dataSet1.Tmise);
                     
                           
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
        private void btupdate_Click(object sender, EventArgs e)
        {
          
            if (_idreche > i)
            {
                XtraMessageBox.Show("Impossible de supprimer la mise " + txtmise.EditValue + " car elle est déja utilser ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                _update();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //btOk.Enabled = false;
            if (gridView1.SelectedRowsCount == 1)
            {
                _id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id").ToString());
                txtmise.EditValue = gridView1.GetFocusedRowCellValue("mise").ToString();
                //txtmontant.EditValue= gridView1.GetFocusedRowCellValue("prix").ToString();
                Verification_parc();
            }
        }
        private void Verification_parc()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT Count(id) AS Roun From Taffectationmise WHERE id='" + _id + "'");
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
            catch (Exception)
            {
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void delete_parc()
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous supprimer  " + txtmise.EditValue + " ", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtmise.Text))
                {
                    XtraMessageBox.Show("Veuillez doubler clique sur une ligne ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //textEdit1.Focus();
                    return;
                }
                try
                {
                    ClassConnexion connexion = new ClassConnexion();
                    connexion.connecter();
                    connexion.cmd.Connection = connexion.con;
                    connexion.cmd.CommandText = ("DELETE Tmise WHERE id='" + _id + "'");
                    connexion.connecter();
                    connexion.cmd.ExecuteNonQuery();
                                this.tmiseTableAdapter.Fill(dataSet1.Tmise);

                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btdelete_Click(object sender, EventArgs e)
        {
            if (_idreche > i)
            {
                XtraMessageBox.Show("Impossible de supprimer la mise " +txtmise.EditValue  + " car elle est déja utilser ", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                delete_parc();
            }
        }
    }
}

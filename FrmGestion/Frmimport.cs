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
using System.Data.OleDb;
using DevExpress.XtraGrid;
using suivibouteilles.Classes;

namespace suivibouteilles.FrmGestion
{
    public partial class Frmimport : DevExpress.XtraEditors.XtraUserControl
    {
        public Frmimport()
        {
            InitializeComponent();
        }

        private void btValiderImport_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous Enregistrer l'importation?", " Enregistrement ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                if (textEdit1.Text == "")
                {
                    XtraMessageBox.Show("Veuillez choisir le fichier", " Information ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else try
                    {
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            //Progress Bar
                            //progressBarX1.Increment(50);
                            //if (progressBarX1.Value == 100)
                            //    timer1.Stop();
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = @"INSERT INTO Tclient(codeclt, nomclt, prenom, fonction, tel1, typeclt, codecol, idzone)
VALUES('" + gridView1.GetRowCellValue(i, "codeclt")+ "','" + gridView1.GetRowCellValue(i, "nomclt").ToString().Replace("'", "''") + "','" + gridView1.GetRowCellValue(i, "prenom").ToString().Replace("'", "''") + "','" + gridView1.GetRowCellValue(i, "fonction").ToString().Replace("'", "''") + "','" + gridView1.GetRowCellValue(i, "tel1") + "', '" + gridView1.GetRowCellValue(i, "typeclt") + "','" + gridView1.GetRowCellValue(i, "codecol")+ "','" + gridView1.GetRowCellValue(i, "idzone")+ "')";
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                        }
                        XtraMessageBox.Show("Importation effectuée");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.ToString());
                        //XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                    }
        }

        private void btchemin_Click(object sender, EventArgs e)
        {
            OpenFileDialog Op = new OpenFileDialog();
            Op.Filter = "Excel Documents (.xlsx)|*.xlsx|all files(*.*)|";
            if (Op.ShowDialog() == DialogResult.OK)
            {
                string nomFichier = Op.FileName.ToString();
                //déclaration et utilisation d'un OLeDBConnection 
                DataSet dat = default(DataSet);
                dat = new DataSet();
                using (OleDbConnection Conn =
                new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;"
                    + " Data Source='" + nomFichier + "';"
                    + " Extended Properties=\"Excel 12.0;\""))
                {
                    Conn.Open();
                    //déclaration du DataAdapter 
                    //notre requête sélectionne toute les cellule de la Feuil1 
                    using (OleDbDataAdapter Adap = new OleDbDataAdapter("select * from [Feuil1$]", Conn))
                    {
                        Adap.TableMappings.Add("Table", "Televe");
                        //Chargement du Dataset 
                        Adap.Fill(dat);
                        //On charge les données sur le DGV 
                        gridControl1.DataSource = dat.Tables[0];
                        textEdit1.Text = nomFichier;
                        // label1.Text = "Importation des Fournisseurs";
                    }
                    //libèrer les ressources 
                    Conn.Close();
                }
            }
        }
    }
}

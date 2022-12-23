using suivibouteilles.Classes;
using suivibouteilles.FrmConnexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using suivibouteilles.Properties;

namespace suivibouteilles.FrmConnexion
{
    public partial class BaseDonnee : DevExpress.XtraEditors.XtraForm
    {
        SqlDataReader dr;
        // SqlConnection query;
        private List<String> listServ = new List<string>();
        //private DsJob.TJobRow selectedRow;
        private String lib = "";
        private string modeAuthen;
        private string password;
        private string user;
        private FrmMenu.Menu menumere;
        private FrmConnexion.BaseDonnee menum;
        private string idline, nommachine;
        public BaseDonnee(FrmConnexion.BaseDonnee menu)
        {
            InitializeComponent();
            menum = menu;
            txtPort.Text = "1433";
            rdAuthWindows.Checked = true;
            lblUser.Visible = false; txtUser.Visible = false;
            lblPass.Visible = false; txtPass.Visible = false;
            label10.Text = Environment.MachineName;
        }
        public BaseDonnee(FrmMenu.Menu menumenf)
        {
            InitializeComponent();
            menumere = menumenf;

        }
        public String connectionString(String server, String port, String database, String user, String password)
        {

            String connectionString = "";
            if (rdAuthMsSql.Checked)
            {
                connectionString = "Data Source=" + server + "," + port + ";Initial Catalog=" + database + ";User ID=" + user + ";" + ";Password=" + password + ";";

            }
            else
            {
                connectionString = "Data Source=" + server + "," + port + ";Initial Catalog=" + database + ";Integrated Security=true;";

            }
            return connectionString;
        }

        private void rdAuthWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.Text= "";
            txtPass.Text = "";
            lblUser.Visible = false; txtUser.Visible = false;
            lblPass.Visible = false; txtPass.Visible = false;
        }

        private void rdAuthMsSql_CheckedChanged(object sender, EventArgs e)
        {
            //  rdAuthWindows.Checked = false; //quand chosie l'auth wi
            lblUser.Visible = true; txtUser.Visible = true;
            lblPass.Visible = true; txtPass.Visible = true;
            txtUser.Focus();
        }
        //Cette methode permetra de verifier si les champs sont rempli avant de d'afficher les base de donné
        public bool databaseVerifier()
        {
            //if (cbServerName.SelectedIndex<0)
            if (txtServerName.Text.Equals(""))
            {
                XtraMessageBox.Show("Veuillez saisir le nom du serveur");
                txtServerName.Focus();
                return false;
            }
            if (txtPort.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Veuillez saisir le port");
                txtPort.Focus();
                return false;
            }

            if (rdAuthMsSql.Checked && txtUser.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Veuillez saisir le nom d'utilisateur");
                txtUser.Focus();
                return false;
            }
            return true;
        }

        public bool testConnectionVerifier()
        {
            if (txtServerName.Text.Equals(""))
            {
                XtraMessageBox.Show("Veuillez saisir le nom du serveur");
                txtServerName.Focus();
                return false;
            }
            if (txtPort.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Veuillez saisir le port");
                txtPort.Focus();
                return false;
            }

            if (cbDataBase.Text.Equals(""))
            {
                XtraMessageBox.Show("Veuillez selectionner une Base!");
                txtServerName.Focus();
                return false;
            }
            if (rdAuthMsSql.Checked && txtUser.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Veuillez saisir le nom d'utilisateur");
                txtUser.Focus();
                return false;
            }

            return true;
        }
        //verification text box
        public void verificationtext()
        {
            if (txtServerName.Text.Equals(""))
            {
                XtraMessageBox.Show("Connexion reussite", "message", MessageBoxButtons.OK);
            }
        }
        // #region : Contrôle des champs de saisi et autres ...
        private void BaseDonnee_Load(object sender, EventArgs e)
        {

            label10.Text = Environment.MachineName;
            //displayParmaserver();
            txtServerName.Text = Settings.Default.NomServeur;
            txtPort.Text = Settings.Default.NumPort;
            txtUser.Text = Settings.Default.NomUser;
            txtPass.Text = Settings.Default.PassUser;
            cbDataBase.Text = Settings.Default.NomBDD;
            rdAuthWindows.Checked = Settings.Default.authwin;
            rdAuthMsSql.Checked = Settings.Default.authsql;
        }

        private void Btconnecter_Click(object sender, EventArgs e)
        {
            // if (testConnectionVerifier())
            if (testConnectionVerifier())
            {
                if (rdAuthMsSql.Checked)
                {
                    modeAuthen = "sql";
                    user = txtUser.Text.ToString();
                    password = txtPass.Text.ToString();
                }

                else
                {
                    modeAuthen = "win";
                }
                //Connexion_Dossier cnnexion = new Connexion_Dossier(this );
                //cnnexion.ShowDialog();
                string connectionString = string.Format("Data source={0};Initial Catalog={1};User ID={2};Password={3};", txtServerName.Text, cbDataBase.Text, txtUser.Text, txtPass.Text);
                try
                {
                    //ClassConnexion cnnn = new ClassConnexion(connectionString);
                    //if (cnnn.connecter())

                    // MessageBox.Show("Connexion reussite", "message", MessageBoxButtons.OK);
                    {
                        AppSetting setting = new AppSetting();
                        setting.saveconnectionstring("suivibouteilles.Properties.Settings.suivibouteillesConnectionString", connectionString);
                        XtraMessageBox.Show("Connexion reussite", "message", MessageBoxButtons.OK);
                        //SaveParamServer();
                        //updateparamserver();
                        Settings.Default.NomServeur = txtServerName.Text;
                        Settings.Default.NomBDD = cbDataBase.Text;
                        Settings.Default.NomUser = txtUser.Text;
                        Settings.Default.NumPort = txtPort.Text;
                        Settings.Default.PassUser = txtPass.Text;
                        Settings.Default.authsql = rdAuthMsSql.Checked;
                        Settings.Default.authwin = rdAuthWindows.Checked;
                        Settings.Default.Save();
                        Settings.Default.EnregistrerInfoBDD = true;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Hide();
                FrmLogin FrmReconnexionlogin = new FrmLogin(menumere);
                FrmReconnexionlogin.ShowDialog();
            }
        }
 
       
        private void cbDataBase_DropDown(object sender, EventArgs e)
        {
            if (databaseVerifier())
            {
                cbDataBase.Items.Clear();
                SqlConnection sqlConnection1 = new SqlConnection(connectionString(txtServerName.Text.ToString(), txtPort.Text.ToString(), "master", txtUser.Text.ToString(), txtPass.Text.ToString()));
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = "SELECT name FROM master..sysdatabases order by name asc";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;
                try
                {
                    sqlConnection1.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cbDataBase.Items.Add(Convert.ToString(reader.GetValue(0)));
                    }
                    sqlConnection1.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtTest_Click(object sender, EventArgs e)
        {
            if (testConnectionVerifier())
            {
                SqlConnection sqlConnection1 = new SqlConnection(connectionString(txtServerName.Text.ToString(), txtPort.Text.ToString(), cbDataBase.SelectedItem.ToString(), txtUser.Text.ToString(), txtPass.Text.ToString()));
                //MessageBox.Show(connectionString(txtServerName.Text.ToString(), txtPort.Text.ToString(), cbDataBase.SelectedItem.ToString(), txtUser.Text.ToString(), txtPass.Text.ToString()));
                try
                {
                   // sqlConnection1.Open();
                    XtraMessageBox.Show("Connection reussie!");
                    Settings.Default.NomServeur = txtServerName.Text;
                    Settings.Default.NomBDD = cbDataBase.Text;
                    Settings.Default.NomUser = txtUser.Text;
                    Settings.Default.NumPort = txtPort.Text;
                    Settings.Default.PassUser = txtPass.Text;
                    Settings.Default.authsql = rdAuthMsSql.Checked;
                    Settings.Default.authwin = rdAuthWindows.Checked;
                    Settings.Default.Save();
                    Settings.Default.EnregistrerInfoBDD = true;
                   // sqlConnection1.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Connextion échouée");

                    XtraMessageBox.Show(ex.Message.ToString());
                }
            }
        }

       
            }
        }



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
using System.IO;
using System.Data.SqlClient;

namespace suivibouteilles.FrmParam
{
    public partial class Frmsociete : DevExpress.XtraEditors.XtraUserControl
    {int _id, _idreche,i = 0;
        string _cheminlogo= "";
        public Frmsociete()
        {
            InitializeComponent();
            Idconfig();
            Verification_1er_enregistrement();
            affichesociete();
        }
        //--Afficher les champs de la societé lors du demarrage--//
        private void affichesociete()
        {
            {
                ClassConnexion connexion = new ClassConnexion();
                connexion.connecter();
                connexion.cmd.Connection = connexion.con;
                connexion.cmd.CommandText = ("SELECT * FROM Tsociete WHERE  id='" + label1.Text + "'");
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                connexion.dr.Read();
                if (connexion.dr.HasRows)
                {
                    _id = Convert.ToInt32(connexion.dr["id"].ToString());
                    TxtNom.Text = connexion.dr["NomSoc"].ToString();
                    TxtVille.Text = connexion.dr["Ville"].ToString();
                    Txtadresse.Text = connexion.dr["Adresse"].ToString();
                    TxtPB.Text = connexion.dr["Bp"].ToString();
                    TxtQartier.Text = connexion.dr["Quartier"].ToString();
                    TxtTel1.Text = connexion.dr["tel1"].ToString();
                    TxtTel2.Text = connexion.dr["tel2"].ToString();
                    Txtemail.Text = connexion.dr["mail"].ToString();
                    TxtNif.Text = connexion.dr["NIF"].ToString();
                    TxtNas.Text = connexion.dr["NAS"].ToString();
                    TxtSiteInt.Text = connexion.dr["Site"].ToString();
                    Txtentete.Text = connexion.dr["Entete"].ToString();
                    PictureBox1.Image = null;

                    if (connexion.dr["logo"] != System.DBNull.Value)
                    {
                        MemoryStream ms = new MemoryStream((byte[])connexion.dr["logo"]);
                        PictureBox1.Image = Image.FromStream(ms);
                    }
                }

            }
        }
        private void Verification_1er_enregistrement()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT Count(id) AS Roun From Tsociete");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    _idreche = connexion.dr.GetInt32(0);
                    if (_idreche > i)
                    {
                        btok.Visible = false;
                    }
                    else
                    {
                        btUpdate.Enabled = false;
                    }
                }
                connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void insertLogo()
        {
            try

            {
                ClassConnexion connacha = new ClassConnexion();
                connacha.connecter();
                connacha.cmd.Connection = connacha.con;
                byte[] ImageIserer = null;
                FileStream PU = new FileStream(_cheminlogo, FileMode.Open, FileAccess.Read);
                BinaryReader Rd = new BinaryReader(PU);
                ImageIserer = Rd.ReadBytes((Int32)PU.Length);
                connacha.cmd.CommandText = @"INSERT INTO  Tsociete(NomSoc,Adresse,Ville,Bp,Quartier,Tel1,Tel2,Nif,Nas,Mail,Site,Entete,Logo) 
                VALUES (@NomSoc,@Adresse,@Ville,@Bp,@Quartier,@Tel1,@Tel2,@Nif,@Nas,@Mail,@Site,@Entete,@Logo)";
                connacha.connecter();
                connacha.cmd.Parameters.Add(new SqlParameter("@NomSoc",TxtNom.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Adresse", Txtadresse.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Ville", TxtVille.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Quartier", TxtQartier.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Bp", TxtPB.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@tel1", TxtTel1.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@tel2", TxtTel1.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@mail", Txtemail.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@NIF", TxtNif.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@NAS", TxtNas.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Site", TxtSiteInt.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@logo", ImageIserer));
                connacha.cmd.Parameters.Add(new SqlParameter("@Entete", Txtentete.Text));
                connacha.cmd.ExecuteNonQuery();
                connacha.deconnecter();
                XtraMessageBox.Show("Enregistrement effectuer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void insertsansLogo()
        {
            try
            {
                ClassConnexion connacha = new ClassConnexion();
                connacha.connecter();
                connacha.cmd.Connection = connacha.con;
                connacha.cmd.CommandText = @"INSERT INTO  Tsociete(NomSoc,Adresse,Ville,Bp,Quartier,Tel1,Tel2, Nif,Nas,Mail,Site,Entete) 
                VALUES (@NomSoc, @Adresse, @Ville,@Bp, @Quartier, @Tel1, @Tel2, @Nif, @Nas, @Mail, @Site, @Entete)";
                connacha.connecter();
                connacha.cmd.Parameters.Add(new SqlParameter("@NomSoc", TxtNom.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Adresse", Txtadresse.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Ville", TxtVille.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Quartier", TxtQartier.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Bp", TxtPB.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@tel1", TxtTel1.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@tel2", TxtTel1.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@mail", Txtemail.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@NIF", TxtNif.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@NAS", TxtNas.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Site", TxtSiteInt.Text));
                //connacha.cmd.Parameters.Add(new SqlParameter("@logo", ImageIserer));
                connacha.cmd.Parameters.Add(new SqlParameter("@Entete", Txtentete.Text));
                connacha.cmd.ExecuteNonQuery();
                connacha.deconnecter();
                XtraMessageBox.Show("Enregistrement effectuer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //update sans logo
        private void updatlogo()
        {
            try
            {
                ClassConnexion connacha = new ClassConnexion();
                connacha.connecter();
                connacha.cmd.Connection = connacha.con;
                byte[] ImageIserer = null;
                FileStream PU = new FileStream(_cheminlogo, FileMode.Open, FileAccess.Read);
                // PU.Position = 0;
                BinaryReader Rd = new BinaryReader(PU);
                ImageIserer = Rd.ReadBytes((Int32)PU.Length);
                connacha.cmd.CommandText = @"UPDATE Tsociete SET NomSoc=@NomSoc, Ville=@Ville, BP=@BP, Tel1=@Tel1, Tel2=@Tel2, Nif=@Nif, Nas=@Nas, Mail=@Mail, Site=@Site, Entete=@Entete, Logo=@Logo WHERE id='" + label1.Text + "'";
                connacha.connecter();
                connacha.cmd.Parameters.Add(new SqlParameter("@NomSoc", TxtNom.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Adresse", Txtadresse.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Ville", TxtVille.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Quartier", TxtQartier.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Bp", TxtPB.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@tel1", TxtTel1.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@tel2", TxtTel1.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@mail", Txtemail.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@NIF", TxtNif.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@NAS", TxtNas.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Site", TxtSiteInt.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Logo", ImageIserer));
                connacha.cmd.Parameters.Add(new SqlParameter("@Entete", Txtentete.Text));
                connacha.cmd.ExecuteNonQuery();
                connacha.deconnecter();
                XtraMessageBox.Show("Enregistrement effectuer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //fonction update sans logo
        private void update_sanslogo()
        {
            try
            {
                ClassConnexion connacha = new ClassConnexion();
                connacha.connecter();
                connacha.cmd.Connection = connacha.con;
                connacha.cmd.CommandText = @"UPDATE Tsociete SET NomSoc=@NomSoc, Ville=@Ville, BP=@BP, Tel1=@Tel1, Tel2=@Tel2, Nif=@Nif, Nas=@Nas, Mail=@Mail, Site=@Site, Entete=@Entete WHERE id='" + label1.Text+ "'";
                connacha.cmd.Parameters.Add(new SqlParameter("@NomSoc", TxtNom.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Adresse", Txtadresse.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Ville", TxtVille.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Quartier", TxtQartier.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Bp", TxtPB.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@tel1", TxtTel1.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@tel2", TxtTel1.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@mail", Txtemail.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@NIF", TxtNif.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@NAS", TxtNas.Text));
                connacha.cmd.Parameters.Add(new SqlParameter("@Site", TxtSiteInt.Text));
               // connacha.cmd.Parameters.Add(new SqlParameter("@logo", ImageIserer));
                connacha.cmd.Parameters.Add(new SqlParameter("@Entete", Txtentete.Text));
                connacha.cmd.ExecuteNonQuery();
                connacha.deconnecter();
                XtraMessageBox.Show("Enregistrement effectuer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btok_Click(object sender, EventArgs e)
        {
            if (PictureBox1.ImageLocation == _cheminlogo)
            {
                insertLogo();
            }
            else
            {
                insertsansLogo();
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            if (PictureBox1.ImageLocation == _cheminlogo)
            {
                updatlogo();
            }
            else
            {
                update_sanslogo();
            }
        }

        private void btinsLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog Op = new OpenFileDialog();
            Op.Filter = "JPG Files(*.jpg)|*.jpg|all files(*.*)|*.*";
            Op.ShowDialog();
            _cheminlogo = Op.FileName.ToString();
            PictureBox1.ImageLocation = _cheminlogo;

        }
        private void Idconfig()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT Count(id) AS Roun From Tsociete WHERE id='" +_id + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    _idreche = connexion.dr.GetInt32(0);
                    if (_idreche > i)
                    {
                        label1.Text = _idreche.ToString();
                    }
                    else
                    { label1.Text = "1"; }
                }
                connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btDelLogo_Click(object sender, EventArgs e)
        {
            ClassConnexion connacha = new ClassConnexion();
            connacha.connecter();
            connacha.cmd.Connection = connacha.con;
            PictureBox1.Image = null;
            connacha.cmd.CommandText = ("UPDATE Tsociete  SET logo=NULL  WHERE id='" + _id + "'");
            connacha.cmd.Parameters.Clear();
            connacha.connecter();
            connacha.cmd.ExecuteNonQuery();
            connacha.deconnecter();
            this.PictureBox1.Refresh();
        }
    }
}

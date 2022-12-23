using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using suivibouteilles.Classes;
using System.Data.SqlClient;
using suivibouteilles.Properties;


namespace suivibouteilles.FrmConnexion
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {public int _iduser;
        string nomste;
        string ChangeBase, requete, parametres, menusociete, menuparametrage, menugestionaccess, menugestion, menuclient, menufrs, menuarticle,
            menuoperation, menubonentree, menubonsortie, menurapport, menucompteclt, menuetatstock, menujournalentree, menujournalsortie, menujournalbouteillerendu, menumvt;
        public FrmMenu.Menu menu;
        private static bool k = true;
        FrmConnexion.BaseDonnee basedon;
        public FrmLogin(FrmConnexion.BaseDonnee basedonn)
        {
            InitializeComponent();
            basedon = basedonn;
          
        }
        public FrmLogin(FrmMenu.Menu en)
        {
            InitializeComponent();
            menu = en;
        }
        //Acces pour change Base de donnee
        private void changebase()
        {

            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,ChangeBase
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                ChangeBase = connexion. dr["ChangeBase"].ToString();
            }
            if (ChangeBase == "True")
            {
                menu.BaseDonnee.Enabled = true;
            }
            if (ChangeBase == "False")
            {
                menu.BaseDonnee.Enabled = false;
            }
            connexion.deconnecter();
        }
        //requete
        private void requetes()
        {

            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,requete
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                requete = connexion.dr["requete"].ToString();
            }
            if (requete == "True")
            {
                menu.men_requeteur.Enabled = true;
            }
            if (requete == "False")
            {
                menu.men_requeteur.Enabled = false;
            }
            connexion.deconnecter();
        }
        //parametre
        private void parametre()
        {

            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,parametres
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                parametres = connexion.dr["parametres"].ToString();
            }
            if (parametres == "True")
            {
                menu.ribbonparamatre.Visible = true;
            }
            if (parametres == "False")
            {
                menu.ribbonparamatre.Visible = false;
            }
            connexion.deconnecter();
        }
        //menu societe
        private void societe()
        {

            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menusociete
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menusociete = connexion.dr["menusociete"].ToString();
            }
            if (menusociete == "True")
            {
                menu.menusociete.Enabled = true;
            }
            if (menusociete == "False")
            {
                menu.menusociete.Enabled =false;
            }
            connexion.deconnecter();
        }
        //parametre
        private void parametrages()
        {

            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menuparametrage
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menuparametrage = connexion.dr["menuparametrage"].ToString();
            }
            if (menuparametrage == "True")
            {
                menu.menuparamg.Enabled = true;
            }
            if (menuparametrage == "False")
            {
                menu.menuparamg.Enabled = false;
            }
            connexion.deconnecter();
        }
        //gestion acces
        private void gestion_acces()
        {
          ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menugestionacces
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menugestionaccess = connexion.dr["menugestionacces"].ToString();
            }
            if (menugestionaccess == "True")
            {
                menu.ribbongestiondesacces.Enabled = true;
            }
            if (menugestionaccess == "False")
            {
                menu.ribbongestiondesacces.Enabled = false;
            }
            connexion.deconnecter();
        }
        //gestion acces
        private void menu_gestion()
        {

            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menugestion
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menugestion = connexion.dr["menugestion"].ToString();
            }
            if (menugestion == "True")
            {
                menu.grpmenu_gestion.Visible = true;
            }
            if (menugestion == "False")
            {
                menu.grpmenu_gestion.Visible = false;
            }
            connexion.deconnecter();
        }
        //client
        private void menu_client()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menuclient
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menuclient = connexion.dr["menuclient"].ToString();
            }
            if (menuclient == "True")
            {
                menu.menuclient.Enabled = true;
            }
            if (menuclient == "False")
            {
                menu.menuclient.Enabled = false;
            }
            connexion.deconnecter();
        }
        //fonction ajout client
        private void ajout_client()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnajoutclient
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnajoutclient = connexion.dr["btnajoutclient"].ToString();
            }
            connexion.deconnecter();
        }
        //update
        private void update_client()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnupdateclient
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnupdateclient = connexion.dr["btnupdateclient"].ToString();
            }
            connexion.deconnecter();
        }
        //delete client
        private void delete_client()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btndeletclient
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btndeletclient = connexion.dr["btndeletclient"].ToString();
            }
            connexion.deconnecter();
        }
        //liste client
        private void liste_client()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnlisteclient
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnlisteclient = connexion.dr["btnlisteclient"].ToString();
            }
            connexion.deconnecter();
        }
        //fournisseur
        private void menu_fournisseur()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menufrs
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menufrs = connexion.dr["menufrs"].ToString();
            }
            if (menufrs == "True")
            {
                menu.menufournisseur.Enabled = true;
            }
            if (menufrs == "False")
            {
                menu.menufournisseur.Enabled = false;
            }
            connexion.deconnecter();
        }
        //fonction ajout client
        private void ajout_fournisseur()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnajoutefrs
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnajoutefrs = connexion.dr["btnajoutefrs"].ToString();
            }
            connexion.deconnecter();
        }
        //update
        private void update_fournisseur()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnupdatefrs
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnupdatefrs = connexion.dr["btnupdatefrs"].ToString();
            }
            connexion.deconnecter();
        }
        //delete client
        private void delete_fournisseur()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btndeletefrs
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btndeletefrs = connexion.dr["btndeletefrs"].ToString();
            }
            connexion.deconnecter();
        }
        //liste client
        private void liste_fournisseur()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnlistefrs
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnlistefrs = connexion.dr["btnlistefrs"].ToString();
            }
            connexion.deconnecter();
        }
        //article
        private void menu_article()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menuarticle
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menuarticle = connexion.dr["menuarticle"].ToString();
            }
            if (menuarticle == "True")
            {
                menu.menuarticles.Enabled = true;
            }
            if (menuarticle == "False")
            {
                menu.menuarticles.Enabled = false;
            }
            connexion.deconnecter();
        }
        //fonction ajout article
        private void ajout_article()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnajoutarticle
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnajoutarticle = connexion.dr["btnajoutarticle"].ToString();
            }
            connexion.deconnecter();
        }
        //update article
        private void update_article()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnupdatearticle
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnupdatearticle = connexion.dr["btnupdatearticle"].ToString();
            }
            connexion.deconnecter();
        }
        //delete article
        private void delete_article()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btndeletearticle
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btndeletearticle = connexion.dr["btndeletearticle"].ToString();
            }
            connexion.deconnecter();
        }
        //liste article
        private void liste_article()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnlistearticle
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnlistearticle = connexion.dr["btnlistearticle"].ToString();
            }
            connexion.deconnecter();
        }
        //Menu operation
        private void menu_operation()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menuoperation
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menuoperation = connexion.dr["menuoperation"].ToString();
            }
            if (menuoperation == "True")
            {
                menu.ribbonOperation.Visible = true;
            }
            if (menuoperation == "False")
            {
                menu.ribbonOperation.Visible = false;
            }
            connexion.deconnecter();
        }
        private void menu_bonEntree()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menubonentree
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menubonentree = connexion.dr["menubonentree"].ToString();
            }
            if (menubonentree == "True")
            {
                menu.menubonentree.Enabled = true;
            }
            if (menubonentree == "False")
            {
                menu.menubonentree.Enabled = false;
            }
            connexion.deconnecter();
        }
        //fonction ajout bon entree
        private void ajout_bonentree()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnajouterbe
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnajouterbe = connexion.dr["btnajouterbe"].ToString();
            }
            connexion.deconnecter();
        }
        //update bon entree
        private void update_bonentree()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnupdatebe
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnupdatebe = connexion.dr["btnupdatebe"].ToString();
            }
            connexion.deconnecter();
        }
        //delete bon entree
        private void delete_bonentree()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btndeletebe
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btndeletebe = connexion.dr["btndeletebe"].ToString();
            }
            connexion.deconnecter();
        }
        //liste bon entree
        private void liste_bonentree()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnlistebe
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnlistebe = connexion.dr["btnlistebe"].ToString();
            }
            connexion.deconnecter();
        }
        //liste print bon entree
        private void print_bonentree()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnprintbe
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnprintbe = connexion.dr["btnprintbe"].ToString();
            }
            connexion.deconnecter();
        }
        //liste histo 
        private void liste_histobonentree()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnhistobe
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnhistobe = connexion.dr["btnhistobe"].ToString();
            }
            connexion.deconnecter();
        }
        //bon sortie
        private void menu_bonsortie()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menubonsortie
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menubonsortie = connexion.dr["menubonsortie"].ToString();
            }
            if (menubonsortie == "True")
            {
                menu.menubonsortie.Enabled = true;
            }
            if (menubonsortie == "False")
            {
                menu.menubonsortie.Enabled = false;
            }
            connexion.deconnecter();
        }
        //fonction ajout bon entree
        private void ajout_bonsortie()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnajouterbs
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnajouterbs = connexion.dr["btnajouterbs"].ToString();
            }
            connexion.deconnecter();
        }
        //update bon entree
        private void update_bonsortie()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnupdatebs
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnupdatebs = connexion.dr["btnupdatebs"].ToString();
            }
            connexion.deconnecter();
        }
        //delete bon entree
        private void delete_bonsortie()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btndeletebs
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btndeletebs = connexion.dr["btndeletebs"].ToString();
            }
            connexion.deconnecter();
        }
        //liste bon entree
        private void liste_bonsortie()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnlistebs
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnlistebs = connexion.dr["btnlistebs"].ToString();
            }
            connexion.deconnecter();
        }
        //liste print bon entree
        private void print_bonsortie()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnhistobs
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnhistobs = connexion.dr["btnhistobs"].ToString();
            }
            connexion.deconnecter();
        }
        //liste histo 
        private void liste_histobonsortie()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil, btnhistobe
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menu._btnhistobe = connexion.dr["btnhistobe"].ToString();
            }
            connexion.deconnecter();
        }
        //menu rapport
        private void menu_rapport()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menurapport
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menurapport = connexion.dr["menurapport"].ToString();
            }
            if (menurapport == "True")
            {
                menu.ribbonrapports.Visible = true;
            }
            if (menurapport == "False")
            {
                menu.ribbonrapports.Visible = false;
            }
            connexion.deconnecter();
        }
        //menu compte client
        private void menu_compte_client()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menucompteclt
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menucompteclt = connexion.dr["menucompteclt"].ToString();
            }
            if (menucompteclt == "True")
            {
                menu.menurapportclient.Enabled = true;
            }
            if (menucompteclt == "False")
            {
                menu.menurapportclient.Enabled = false;
            }
            connexion.deconnecter();
        }
        //etat de stock
        private void menu_etatstock()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menuetatstock
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menuetatstock = connexion.dr["menuetatstock"].ToString();
            }
            if (menuetatstock == "True")
            {
                menu.menu_etatstock.Enabled = true;
            }
            if (menuetatstock == "False")
            {
                menu.menu_etatstock.Enabled = false;
            }
            connexion.deconnecter();
        }
        //journal entree
        private void menu_journal_entree()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menujournalentree
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menujournalentree = connexion.dr["menujournalentree"].ToString();
            }
            if (menujournalentree == "True")
            {
                menu.menuJournalBonentree.Enabled = true;
            }
            if (menujournalentree == "False")
            {
                menu.menuJournalBonentree.Enabled = false;
            }
            connexion.deconnecter();
        }
        //journal sortie
        private void menu_journal_sortie()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menujournalsortie
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menujournalsortie = connexion.dr["menujournalsortie"].ToString();
            }
            if (menujournalsortie == "True")
            {
                menu.menuJournalBonSortie.Enabled = true;
            }
            if (menujournalsortie == "False")
            {
                menu.menuJournalBonSortie.Enabled = false;
            }
            connexion.deconnecter();
        }
        //journal bouteille rendue
        private void menu_journal_bouteille_rendue()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = @"SELECT iduser, UserName, PwdName, NomLogin, PrenomLogin,Email,TProfil.idprofil, Libprofil,menujournalbouteillerendu
            FROM TLogin, TProfil WHERE TLogin.idprofil = TProfil.idprofil  and UserName ='" + TxtLogin.Text + "'";
            connexion.connecter();
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.dr.Read();
            if (connexion.dr.HasRows)
            {
                menujournalbouteillerendu = connexion.dr["menujournalbouteillerendu"].ToString();
            }
            if (menujournalbouteillerendu == "True")
            {
                menu.menujournalretour.Enabled = true;
            }
            if (menujournalbouteillerendu == "False")
            {
                menu.menujournalretour.Enabled = false;
            }
            connexion.deconnecter();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelControl1.Text = "Date : " + DateTime.Now;
            if (k)
                label37.Location = new Point(label37.Location.X + 5, label37.Location.Y);
            else
                label37.Location = new Point(label37.Location.X - 650, label37.Location.Y);
            if (label37.Location.X + label37.Width >= this.Width + 180)
                k = false;
            if (label37.Location.X <= 0)
                k = true;
        }
        private void affichesociete()
        {
            {
                ClassConnexion connex = new ClassConnexion();
                connex.connecter();
                connex.cmd.Connection = connex.con;
                connex.cmd.CommandText = (@"SELECT NomSoc FROM Tsociete");
                connex.connecter();
                connex.dr = connex.cmd.ExecuteReader();
                connex.dr.Read();
                if (connex.dr.HasRows)
                {
                    nomste = connex. dr[0].ToString();
                }
            }
        }
        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                BtValiderConxion1.PerformClick();
        }
        //avec mot de pass
        private void AvecMotdepass()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT iduser, UserName, PwdName FROM TLogin WHERE Username =@Username COLLATE SQL_Latin1_General_CP1_CS_AS 
            AND PwdName=@PwdName COLLATE SQL_Latin1_General_CP1_CS_AS");
            connexion.cmd.Parameters.AddWithValue("@Username", TxtLogin.Text);
            connexion.cmd.Parameters.AddWithValue("@PwdName", TxtPass.Text);
            SqlDataReader dbr;
            connexion.connecter();
            dbr = connexion.cmd.ExecuteReader();
            //connacha.deconnecter();
            int count = 0;
            while (dbr.Read())
            {
                count += 1;
                _iduser = dbr.GetInt32(0);
            }
            connexion.deconnecter();
            if (count == 1)
            {
                affichesociete();
                //appelIdLogin();
                var lin1 = "GESTION TONTINE";
                var Lin2 = nomste;
                //var Lin3 = "Période";
                var Lin5 = "Serveur";

                menu.Text = lin1 + "   " + Lin2 +  "   " + Lin5 + ": " + Settings.Default.NomServeur + "   Login :" + Settings.Default.Utilisateur + "";
                if (Lin5 == "CONGOBRA")
                {
                    //usermenu1.ribbonPageGroup9.Visible = true;
                    //usermenu1.ribbonPageGroup12.Visible = true;
                    //usermenu1.ribbonPageGroup11.Visible = false;
                    //usermenu1.ribbonPageGroup3.Visible = false;
                }
                else
                {
                    //usermenu1.ribbonPageGroup9.Visible = false;
                    //usermenu1.ribbonPageGroup12.Visible = false;
                    //usermenu1.ribbonPageGroup11.Visible = true;
                    //usermenu1.ribbonPageGroup3.Visible = true;
                }
            
                changebase();
                requetes();
                parametre();
                societe();
                parametrages();
                gestion_acces();
                menu_gestion();
                menu_client();
                ajout_client();
                update_client();
                delete_client();
                liste_client();
                menu_fournisseur();
                ajout_fournisseur();
                update_fournisseur();
                delete_fournisseur();
                liste_fournisseur();
                ajout_article();
                update_article();
                delete_article();
                liste_article();
                ajout_bonentree();
                update_bonentree();
                delete_bonentree();
                liste_bonentree();
                liste_histobonentree();
                ajout_bonsortie();
                update_bonsortie();
                liste_histobonsortie();
                print_bonsortie ();
                menu_rapport();
                menu_compte_client();
                menu_etatstock();
                menu_journal_entree();
                menu_journal_sortie();
                menu_journal_bouteille_rendue();
                //sauvegarde();
                //Restauration();
                //licence();
                //Entreprise();
                //Parametrage();
                //Station();
                //BtaaajouterStation();
                //ModifierStation();
                //Profil();
                //Utilisateur();
                //DroitAcces();
                //Pers();
                //Fournisseur();
                //Engin();
                //Chantier();
                //Intervention();
                //Requete();
                //commande();
                //BonEntree();
                //AchatPompe();
                //Consommation();
                //Interrogerstock();
                //PrintPersonnel();
                //PrintFournisseur();
                //PrintIntervention();
                //PrintAchatStation();
                //PrintEngin();
                //Printchantier();
                //PrintDepensechantier();
                //PrintStatistiqueDepense();
                //PrintDepensequantitéchantier();
                //ImportPersonnel();
                //ImportFournisseur();
                //ImportEngin();
                //FrmBase appelfrmbase = new FrmBase();
                //appelfrmbase.Close();
                //usermenu1.ribbonTabItem2.Visible = true;
                //usermenu1.ribbonTabItem8.Visible = true;
                // menu.ribbonPage2.Visible = true;
                //menu.ribbonPage3.Visible = true;
                //usermenu1.MenuAutre.Visible = true;
                // menu.Menudeclarannuel.Visible = true;
                menu.ribbonparamatre.Visible = true;
                menu.grpmenu_gestion.Visible = true;
               menu. ribbonOperation.Visible = true;
                menu .ribbonrapports.Visible = true;
                Settings.Default.Session = Environment.MachineName;
                //menu.labelControl1.Text = _iduser.ToString();
                menu._iduser = _iduser;
                Settings.Default.Utilisateur = TxtLogin.Text;
                Settings.Default.Save();
                Settings.Default.EnregistrerInfoBDD = true;
               // menu.Fonction_nbre_client_attente();
               // menu.Fonction_nbre_encours_cotisattoin();
               // menu.Fonction_alerte_stock();
               // menu._notification_vente_en_attente();
               // menu._notification_stock();
                this.Close();

            }
            else
            {
                XtraMessageBox.Show("Verifier le login ou password");
                {
                    TxtPass.Focus();
                    return;
                }
            }
            connexion.deconnecter();
        }
        private void BtValiderConxion1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtLogin.Text))
            {
                XtraMessageBox.Show("Veuillez entrer votre Login", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtLogin.Focus();
                return;
            }
            //vérificarion si le champs Password est vides
            if (string.IsNullOrEmpty(TxtPass.Text))
            {
                // sansMotdepass();
                XtraMessageBox.Show("Veuillez entrer votre le mot de passe ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPass.Focus();
                return;
            }
            else
            {
                AvecMotdepass();
                Settings.Default.Session = Environment.MachineName;
                Settings.Default.Utilisateur = TxtLogin.Text;
                Settings.Default.Save();
                Settings.Default.EnregistrerInfoBDD = true;
               

            }
           // changebas();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxtLogin.Text = Settings.Default.Utilisateur;
            labelControl1.Text = "Date : " + DateTime.Now;
            timer1.Start();
        }
    }
}
    

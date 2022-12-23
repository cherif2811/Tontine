using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Helpers;
using suivibouteilles.FrmConnexion;
using suivibouteilles.Classes;
using suivibouteilles.FrmMenu;
using suivibouteilles.Properties;
using DevExpress.XtraEditors;
using System.Net.Mail;
using suivibouteilles.FrmGestion;

namespace suivibouteilles.FrmMenu
{
    public partial class Menu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //public static ThreadStart Splacheshed { get; private set; }
       // int _idconfigmail;
        int _numparam = 283, nb_attente, nb_encours,nb_stock_reste;
     public   int _iduser;
        string _idreche;
        public string _btnajoutclient, _btnupdateclient, _btndeletclient, _btnlisteclient, _btnajoutefrs, _btnupdatefrs, _btndeletefrs, _btnlistefrs,
            _btnajoutarticle, _btnupdatearticle, _btndeletearticle, _btnlistearticle, _btnajouterbe, _btnupdatebe, _btndeletebe, _btnlistebe, _btnprintbe, _btnhistobe,
            _btnajouterbs, _btnupdatebs,_btndeletebs, _btnlistebs, _btnhistobs;
        DateTime date = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
        string annee = DateTime.Now.ToString("yyyy");
        string mois = DateTime.Now.ToString("MM");
        string jours = DateTime.Now.ToString("dd");
        string heure = DateTime.Now.ToString("HH");
        public string _login;
        public Menu()
        {
            InitializeComponent();
           // userbase = userb;
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1, true, true);
            SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1);
           UserLookAndFeel.Default.SkinName =suivibouteilles. Properties.Settings.Default.skin.ToString();
            timer1.Start();

        }
        
         ////Fonction send mail alerte
           //public void EnvoiMail()
           //{

            //    //verification des param vide
            //    if (string.IsNullOrEmpty(_addremail) || string.IsNullOrEmpty(_motdepass) || string.IsNullOrEmpty(_addremail))
            //    {
            //        XtraMessageBox.Show("Veuillez verifier la configuration de la boite mail", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        return;
            //    }

            //    else
            //    {
            //        try
            //        {
            //            //MontantRibruqueImposale();
            //            //MontantRibruqueFiscalSocial();
            //            //MontantRibruquenonImposable();
            //            //MontantRibruqueRetenu();
            //            //commentaireBulletin();
            //            //Etat.XtraBulletinPaie etat = new Etat.XtraBulletinPaie(matricule.Text, menumer.CmbPeriode.Text, Convert.ToInt32(menumer.CmbSequence.Text.ToString()));
            //            //etat.Parameters["MtRImposaleB"].Value = MtRImposale;
            //            //etat.Parameters["MtRFiscalSocialB"].Value = MtRFiscalSocial;
            //            //etat.Parameters["MtRnonImposableB"].Value = MtRnonImposable;
            //            //etat.Parameters["MtRRetenuB"].Value = MtRRetenu;
            //            //etat.Parameters["commentaireB"].Value = commentaire;
            //            ////documentViewer1.DocumentSource = etat;
            //            //// documentViewer1.Visible = true;
            //            //etat.CreateDocument();
            //            //MemoryStream mem = new MemoryStream();
            //            //etat.ExportToPdf(mem);
            //            //mem.Seek(0, System.IO.SeekOrigin.Begin);
            //            MailMessage Mail = new MailMessage();
            //            SmtpClient SmtpServeur = new SmtpClient(_smtpServer);
            //            Mail.From = new MailAddress(_addremail);
            //            Mail.To.Add(_addremail);
            //            Mail.Subject = _confsujet;
            //            Mail.Body = _confContenuMail;
            //            //System.Net.Mail.Attachment attachment;
            //            //string nomduFichier = "Bulletin de Paie mois" + menumer.CmbPeriode.Text;
            //            //attachment = new System.Net.Mail.Attachment(mem, nomduFichier, "application/pdf");
            //            //Mail.Attachments.Add(attachment);

            //            SmtpServeur.Port = Int16.Parse(_smtpPort);
            //            SmtpServeur.Credentials = new System.Net.NetworkCredential(_addremail, _motdepass);
            //            SmtpServeur.EnableSsl = Convert.ToBoolean(Ssl); 
            //            SmtpServeur.Send(Mail);
            //            XtraMessageBox.Show("Mail envoyé à ");
            //        }
            //        catch (Exception)
            //        {
            //            XtraMessageBox.Show("Mail non envoyé à");
            //        }
            //    }
            //}
            ////select l'idconfig 
            //private void selectidconfig()
            //{
            //    ClassConnexion connex = new ClassConnexion();
            //    connex.connecter();
            //    connex.cmd.Connection = connex.con;
            //    connex.cmd.CommandText = ("SELECT IdConfig FROM Tconfig_boite_mail");
            //    connex.connecter();
            //    connex.dr = connex.cmd.ExecuteReader();
            //    connex.dr.Read();
            //    if (connex.dr.HasRows)
            //    {
            //        _idconfigmail = connex.dr.GetInt32(0);

            //    }

            //}
            ////--Afficher les champs de mail de l'expediteur mail et passeword lors du demarrage--//
            //Boolean Ssl;
            //private void DisplayConfigmail()
            //{
            //    ClassConnexion connex = new ClassConnexion();
            //    connex.connecter();
            //    connex.cmd.Connection = connex.con;
            //    connex.cmd.CommandText = ("SELECT * FROM Tconfig_boite_mail WHERE IdConfig='" +_idconfigmail+ "'");
            //    connex.connecter();
            //    connex.dr = connex.cmd.ExecuteReader();
            //    connex.dr.Read();
            //    // SqlDataReader reader;
            //    // var Ssl1 = connex.dr.GetOrdinal("Ssl2");
            //    if (connex.dr.HasRows)
            //    {
            //        // idconfig.Text = connex.dr[0].ToString();
            //        _smtpServer = connex.dr[1].ToString();
            //        _smtpPort = connex.dr[2].ToString();
            //        _addremail = connex.dr[3].ToString();
            //        _motdepass = connex.dr[4].ToString();
            //       _confsujet = connex.dr[5].ToString();
            //       _confContenuMail = connex.dr[6].ToString();
            //        Ssl = Convert.ToBoolean(connex.dr[7]);
            //    }

            //}
        public void AddTabControldroit(UserControl userControl, string itemTabName, string icon)
        {
            bool isExists = false;

            foreach (XtraTabPage tabItem in stc_droite.TabPages)
            {
                if (tabItem.Text == itemTabName)
                {
                    isExists = true;
                    stc_droite.SelectedTabPage = tabItem;
                }
            }
            if (isExists == false)
            {
                AddTab addTab = new AddTab();
                addTab.AddTabControl(stc_droite, itemTabName, icon, userControl);
            }
        }

        public void AddTabControlgauche(UserControl userControl, string itemTabName, string icon)
        {
            bool isExists = false;

            foreach (XtraTabPage tabItem in stc_gauche.TabPages)
            {
                if (tabItem.Text == itemTabName)
                {
                    isExists = true;
                    stc_gauche.SelectedTabPage = tabItem;
                }
            }
            if (isExists == false)
            {
                AddTab addTab = new AddTab();
                addTab.AddTabControl(stc_gauche, itemTabName, icon, userControl);
            }
        }

        private void stc_droite_CloseButtonClick(object sender, EventArgs e)
        {
            stc_droite.TabPages.RemoveAt(stc_droite.SelectedTabPageIndex);
            stc_droite.SelectedTabPageIndex = stc_droite.TabPages.Count - 1;
        }

        private void stc_droite_ControlAdded(object sender, ControlEventArgs e)
        {
            stc_droite.SelectedTabPageIndex = stc_droite.TabPages.Count - 1;
        }

        private void Paramgeneral_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void Departem_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void Services_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void BaseDonnee_ItemClick(object sender, ItemClickEventArgs e)
        {
            stc_droite.TabPages.Clear();
            stc_gauche.TabPages.Clear();
            BaseDonnee Frm = new BaseDonnee(this);
            Frm.ShowDialog();
        }

        private void Reconnexion_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            ribbonparamatre.Visible = false;
            grpmenu_gestion.Visible = false;
            ribbonOperation.Visible = false;
            ribbonrapports.Visible = false;
            //Menudeclarannuel.Visible = false;
            //MenuDeclarationg.Visible = false;
            stc_droite.TabPages.Clear();
            stc_gauche.TabPages.Clear();
            FrmLogin FrmReconnexionlogin = new FrmLogin(this);
            FrmReconnexionlogin.ShowDialog();
        }
        //fonction Active Alerte Automatique
        private void activer_Alert()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT Valeur From TParam WHERE NumParam='" +_numparam+ "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    _idreche = connexion.dr.GetString(0);
                    if (_idreche.Equals("1"))
                    {
                        //FrmSalarie.FrmAlertectrat frmcontrat = new FrmSalarie.FrmAlertectrat(this);
                        //frmcontrat.Text = heure;
                        //frmcontrat.Show();
                        //frmcontrat.Visible = false;
                    }
                    else
                    {
                        
                    }
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //fonction_compte_client en attente
        public void Fonction_nbre_client_attente()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT COUNT(Taffectationpark.codeclt) as nb FROM Taffectationpark,tmp_tontine_reste_apayer WHERE etat='En attente' 
AND Taffectationpark.codeclt=tmp_tontine_reste_apayer.codeclt AND Taffectationpark.codepark=tmp_tontine_reste_apayer.codepark AND reste=0");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader(0);
                while (connexion.dr.Read())
                {
                    nb_attente= connexion.dr.GetInt32(0);
                  
                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //fonction_compte_client en cours de cotisatin
        public void Fonction_nbre_encours_cotisattoin()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT COUNT(Taffectationpark.codeclt) as nb FROM Taffectationpark,tmp_tontine_reste_apayer WHERE etat='En attente' 
AND Taffectationpark.codeclt=tmp_tontine_reste_apayer.codeclt AND Taffectationpark.codepark=tmp_tontine_reste_apayer.codepark AND reste>0");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader(0);
                while (connexion.dr.Read())
                {
                    nb_encours = connexion.dr.GetInt32(0);

                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //fonction_alerte stock
        public void Fonction_alerte_stock()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT COUNT(CodeArt) AS nb FROM tmp_etatstock WHERE Qtereste=0");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader(0);
                while (connexion.dr.Read())
                {
                    nb_stock_reste = connexion.dr.GetInt32(0);

                }
                connexion.deconnecter();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Une erreur s'est produite dans l'Application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void _notification_vente_en_attente()
        {
            
          // if (nb_attente >=1)
            {
                int indexnotification = 0;
                string[] toast = { "2fe5ae8a-e706-48e9-8f56-004d80e867fd" };
                toastNotificationsManager1.Notifications[indexnotification].Body = nb_attente + " Cotisation(s) En attente de Vente  et  " + nb_encours + " client(s) Encours de cotisation(s)";
                toastNotificationsManager1.Notifications[indexnotification].Header = "Informations";
                toastNotificationsManager1.ShowNotification(toast[indexnotification].ToString());
            
            }
        }
        //notification_stock
        public void _notification_stock()
        {
            if(nb_stock_reste>=1)
            {
                int indexnotification = 0;
                string[] toast = { "24e54218-7ad3-4bd2-9343-b43616d3e224" };
                toastNotificationsManager2.Notifications[indexnotification].Body = " Alerte Stock   " + nb_stock_reste + " article(s) en rupture de stock " +
                    " Veuillez consulter Etat des Stocks ";
                toastNotificationsManager2.Notifications[indexnotification].Header = "Alerte Stock...";
                toastNotificationsManager2.ShowNotification(toast[indexnotification].ToString());
            }
            
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            {
                Thread.Sleep(50);
            }
         
            ribbonparamatre.Visible = false;
            ribbonOperation.Visible = false;
            grpmenu_gestion.Visible = false;
            ribbonrapports.Visible = false;
            FrmLogin FrmReconnexionlogin = new FrmLogin(this);
            FrmReconnexionlogin.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
        
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void MenuDossier_ItemClick(object sender, ItemClickEventArgs e)
        {
        
        }

        private void menuSection_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void menuPeriode_ItemClick(object sender, ItemClickEventArgs e)
        {
        
        }

        private void menuBanque_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void menuEtat_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void menuPays_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void menuTypeEvenem_ItemClick(object sender, ItemClickEventArgs e)
        {
        
        }

        private void menuContrat_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void menuTypeAssuree_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void menuEmploi_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void menucodesortie_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void menuNatureSalaire_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void menuimpot_ItemClick(object sender, ItemClickEventArgs e)
        {
        
        }

        private void menucnss_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void menuNap_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void menulisevir_ItemClick(object sender, ItemClickEventArgs e)
        {
        
        }

        private void menuordrevirem_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void stc_gauche_CloseButtonClick(object sender, EventArgs e)
        {
            stc_gauche.TabPages.RemoveAt(stc_gauche.SelectedTabPageIndex);
            stc_gauche.SelectedTabPageIndex = stc_gauche.TabPages.Count - 1;
        }

        private void stc_gauche_ControlAdded(object sender, ControlEventArgs e)
        {
            stc_gauche.SelectedTabPageIndex = stc_gauche.TabPages.Count - 1;
        }

        private void menuListePret_ItemClick(object sender, ItemClickEventArgs e)
        {
        
        }

        private void menupretencours_ItemClick(object sender, ItemClickEventArgs e)
        {
       
        }

        private void menuecheancier_ItemClick(object sender, ItemClickEventArgs e)
        {
        
        }

        private void barButtonItem4_ItemClick_1(object sender, ItemClickEventArgs e)
        {
          
        }

        private void menuparamOrdreVir_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmParam.Frmsociete frmpa = new FrmParam.Frmsociete();
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControldroit(frmpa, "Societe", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menuconfigmail_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void menudeclarimpot_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void menudeclaimpotannuel_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void menuBi_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void menusendbu_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void menBIcongo_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void menuDasIcongo_ItemClick(object sender, ItemClickEventArgs e)
        {
        
        }

        private void menuDascongoII_ItemClick(object sender, ItemClickEventArgs e)
        {
       
        }

        private void menulistenomi_ItemClick(object sender, ItemClickEventArgs e)
        {
       
        }

        private void menucsscongo_ItemClick(object sender, ItemClickEventArgs e)
        {
        
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Questionnaire à la Fermeture d'application
            DialogResult Fermeture = XtraMessageBox.Show("Voulez-Vous Quitter l'Application?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (Fermeture == DialogResult.Yes)
            {
                suivibouteilles.Properties.Settings.Default.skin = UserLookAndFeel.Default.SkinName;
                suivibouteilles.Properties.Settings.Default.Save();
                // Application.Exit();
            }
            else if (Fermeture == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void menulistePer_ItemClick(object sender, ItemClickEventArgs e)
        {
       
        }

        private void menuparamg_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmParam.Frmparamgauche frmpa = new FrmParam.Frmparamgauche(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Paramètrge", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menuplancmpta_ItemClick(object sender, ItemClickEventArgs e)
        {
        
        }

        private void menu_collecteur_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmGestion.Frmcollecteurgauche frmpa = new FrmGestion.Frmcollecteurgauche(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Collecteurs", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_tontine_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmOperations.Frmtontinegauche frmpa = new FrmOperations.Frmtontinegauche(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Tontine", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void men_affectation_park_client_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmGestion.Affectationparkclients frmpa = new FrmGestion.Affectationparkclients();
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControldroit(frmpa, "Affectation pack aux clients", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_park_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmGestion.Frmparkproduits frmpa = new FrmGestion.Frmparkproduits();
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControldroit(frmpa, "Pack des produits", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_facturation_ItemClick(object sender, ItemClickEventArgs e)
        {
      
        }

        private void menu_cotisation_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void menu_liste_parc_souscrit_ItemClick(object sender, ItemClickEventArgs e)
        {
           FrmEdition.Frmliste_parc frmpa = new FrmEdition.Frmliste_parc(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Liste des souscriptions aux mises", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_vente_simple_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void menu_commission_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void menu_liste_commission_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmEdition.frmlistecommission frmpa = new FrmEdition.frmlistecommission(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Listing de commission", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_import_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmGestion.Frmimport frmpa = new FrmGestion.Frmimport();
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControldroit(frmpa, "Importation des clients", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmEdition.Frmlistetontine frmpa = new FrmEdition.Frmlistetontine(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Liste Tontine", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmEdition.Frmlisting_tontine_par_collecteur frmpa = new FrmEdition.Frmlisting_tontine_par_collecteur(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Liste Tontine par collecteur", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmEdition.Frmliste_cotisation_fin frmpa = new FrmEdition.Frmliste_cotisation_fin(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Liste de cotisatin soldé&reste", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmEdition.Frmlisting_tontine_solde_zero frmpa = new FrmEdition.Frmlisting_tontine_solde_zero(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Liste de cotisatin solde egal zéro", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_benefice_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmEdition.Frmbenefice frmpa = new FrmEdition.Frmbenefice(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Liste des Bénéfices", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_depot_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmOperations.Frmdepotgauche frm = new FrmOperations.Frmdepotgauche(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frm, "Dépot", "");
            frm.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void frm_liste_depot_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmEdition.Frmlistetontine frmpa = new FrmEdition.Frmlistetontine(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Liste Tontine", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_retrait_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmOperations.Frmretrait_gauche frm = new FrmOperations.Frmretrait_gauche(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frm, "Retrait tontine", "");
            frm.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_livre_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmEdition.Frm_livre_operations frmpa = new FrmEdition.Frm_livre_operations(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Livre des opérations depot & retrait", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_prets_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmOperations.Frmprets_gauche frm = new FrmOperations.Frmprets_gauche(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frm, "Prêts", "");
            frm.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_rembourssement_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmOperations.Frmremboursement_gauche frm = new FrmOperations.Frmremboursement_gauche();
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frm, "Remboursement", "");
            frm.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_raaport_vente_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmEdition.Frm_liste_vente frmpa = new FrmEdition.Frm_liste_vente(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Liste vente tontine", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_Etat_Stock_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frmrapports.FrmEtatstock frmpa = new Frmrapports.FrmEtatstock(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Etat Stock", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmEdition.Frmliste_cotisation_fin frmpa = new FrmEdition.Frmliste_cotisation_fin(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Liste de cotisatin soldé&reste", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            stc_droite.TabPages.Clear();
            stc_gauche.TabPages.Clear();
            //splashScreenManager1.CloseWaitForm();       
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void fermerTousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stc_droite.TabPages.Clear();
            stc_gauche.TabPages.Clear();
           
        }

      
      


        private void menuvarriat_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            //FrmGestion.FrmParamVariation frmpa = new FrmGestion.FrmParamVariation();
            XtraTabPage xtraTabPage = new XtraTabPage();
            //AddTabControldroit(frmpa, "Variation", "");
            //frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
            splashScreenManager1.CloseWaitForm();
        }

       

        private void menuclient_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmGestion.Frmcltgauche frmpa = new FrmGestion.Frmcltgauche(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Clients", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menuarticles_ItemClick(object sender, ItemClickEventArgs e)
        {

            FrmGestion.Frmarticlegauche frmpa = new FrmGestion.Frmarticlegauche(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Article", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
    }

        private void menubonentree_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void menufournisseur_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmGestion.FrmFrsgauche frmpa = new FrmGestion.FrmFrsgauche(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Fournisseur", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menubonsortie_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void menu_retour_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void menurapportclient_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frmrapports.Frmrapportclt frmpa = new Frmrapports.Frmrapportclt(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Rapport Client", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_etatstock_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frmrapports.FrmEtatstock frmpa = new Frmrapports.FrmEtatstock(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Etat Stock", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menuprofil_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frmutilisateur.FrmProfilgauche frmpa = new Frmutilisateur.FrmProfilgauche();
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Profil", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menu_utilisateur_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frmutilisateur.Frmusergauche frmpa = new Frmutilisateur.Frmusergauche(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Utilisateur", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menuaccès_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frmutilisateur.Frmacces frmpa = new Frmutilisateur.Frmacces();
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControldroit(frmpa, "Droit aux menus", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }
        private void menuJournalBonentree_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frmrapports.FrmJournalBonEntree frmpa = new Frmrapports.FrmJournalBonEntree(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Journal de Bon d'Entrée", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menuJournalBonSortie_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frmrapports.FrmJournalBonSortie frmpa = new Frmrapports.FrmJournalBonSortie(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Journal de Bon Sortie", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menujournalretour_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frmrapports.FrmJournalRetour frmpa = new Frmrapports.FrmJournalRetour(this);
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControlgauche(frmpa, "Journal des Retours", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void men_requeteur_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frmrequetes.Frmrequete frmpa = new Frmrequetes.Frmrequete();
            XtraTabPage xtraTabPage = new XtraTabPage();
            AddTabControldroit(frmpa, "Requete", "");
            frmpa.Dock = DockStyle.Fill;
            this.Cursor = Cursors.Default;
        }

        private void menucomptearticle_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barButtonItem2.Caption = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            timer1.Start();
        }
    }
}
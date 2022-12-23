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
    public partial class Frmacces : DevExpress.XtraEditors.XtraUserControl
    {
        int _idusers;
        public Frmacces()
        {
            InitializeComponent();
            Displayusers();
        }
        //Display TProfil
        public void Displayusers()
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = (@"SELECT iduser, UserName FROM TLogin");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    string profil = connexion.dr.GetString(1);
                    cmbusers.Properties.Items.Add(profil);
                    //this.cmbTypeclasse.SelectedIndex = 0;
                }
                connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void update_acces()
        {
            DialogResult result = XtraMessageBox.Show("Voulez vous Confirmer l'enregistrement des droits d'accès du profil  " + cmbusers.Text + "?", " Confirmation ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
                if ((cmbusers.Text == ""))
                {
                    XtraMessageBox.Show("veuillez Selectionner un Profil", "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbusers.Focus();
                    return;
                }
                else
                    try
                    {
                        {
                            ClassConnexion connexion = new ClassConnexion();
                            connexion.connecter();
                            connexion.cmd.Connection = connexion.con;
                            connexion.cmd.CommandText = @"UPDATE TLogin  SET ChangeBase=@ChangeBase , requete=@requete, parametres=@parametres, menusociete=@menusociete, menuparametrage=@menuparametrage, menugestionacces=@menugestionacces, menuclient=@menuclient,btnajoutclient=@btnajoutclient, btnupdateclient=@btnupdateclient, btndeletclient=@btndeletclient, btnlisteclient=@btnlisteclient, menugestion=@menugestion,
 menufrs=@menufrs, btnajoutefrs=@btnajoutefrs, btnupdatefrs=@btnupdatefrs, btndeletefrs=@btndeletefrs, btnlistefrs=@btnlistefrs, menuarticle=@menuarticle, btnajoutarticle=@btnajoutarticle, btnupdatearticle=@btnupdatearticle, btndeletearticle=@btndeletearticle, btnlistearticle=@btnlistearticle, menuoperation=@menuoperation, menubonentree=@menubonentree,btnajouterbe=@btnajouterbe, btnupdatebe=@btnupdatebe, btndeletebe=@btndeletebe, btnlistebe=@btnlistebe, btnprintbe=@btnprintbe, btnhistobe=@btnhistobe, menubonsortie=@menubonsortie, btnajouterbs=@btnajouterbs, btnupdatebs=@btnupdatebs, btndeletebs=@btndeletebs, btnlistebs=@btnlistebs, btnhistobs=@btnhistobs, menurapport=@menurapport, menucompteclt=@menucompteclt, menuetatstock=@menuetatstock, menujournalentree=@menujournalentree, 
                  menujournalsortie=@menujournalsortie, menujournalbouteillerendu=@menujournalbouteillerendu, menumvt=@menumvt
WHERE iduser='" + Convert.ToInt32(textEdit1.EditValue) + "'";
                            //base de données
                            connexion.cmd.Parameters.AddWithValue("@ChangeBase", ChangeBase.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@requete", requete.Properties.Value);
                            //parametres
                            connexion.cmd.Parameters.AddWithValue("@parametres", paramètres.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@menusociete", menusociete.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@menuparametrage", menuparametrage.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@menugestionacces", menugestionacces.Properties.Value);
                            //gestions
                            connexion.cmd.Parameters.AddWithValue("@menugestion", menugestion.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@menuclient", menuclient.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnajoutclient", btnajoutclient.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnupdateclient", menuclient.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btndeletclient", btndeletclient.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnlisteclient", btnlisteclient.Properties.Value);

                            connexion.cmd.Parameters.AddWithValue("@menufrs", menufrs.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnajoutefrs", btnajoutefrs.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnupdatefrs", btnupdatefrs.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btndeletefrs", btndeletefrs.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnlistefrs", btnlistefrs.Properties.Value);
                            //articles
                            connexion.cmd.Parameters.AddWithValue("@menuarticle", menuarticle.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnajoutarticle", btnajoutarticle.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnupdatearticle", btnupdatearticle.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btndeletearticle", btndeletearticle.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnlistearticle", btnlistearticle.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@menuoperation", menuoperation.Properties.Value);
                            //bon entree
                            connexion.cmd.Parameters.AddWithValue("@menubonentree", menubonentree.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnajouterbe", btnajouterbe.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnupdatebe", btnupdatebe.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btndeletebe", btndeletebe.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnlistebe", btnlistebe.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnprintbe", btnprintbe.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnhistobe", btnhistobe.Properties.Value);
                            //bon sortie
                            connexion.cmd.Parameters.AddWithValue("@menubonsortie", menubonsortie.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnajouterbs", btnajouterbs.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnupdatebs", btnupdatebs.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btndeletebs", btndeletebs.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnlistebs", btnlistebs.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@btnhistobs", btnhistobs.Properties.Value);
                            //menu rapport
                            connexion.cmd.Parameters.AddWithValue("@menurapport", menurapport.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@menucompteclt", menucompteclt.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@menuetatstock", menuetatstock.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@menujournalentree", menujournalentree.Properties.Value);

                            connexion.cmd.Parameters.AddWithValue("@menujournalsortie", menujournalsortie.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@menujournalbouteillerendu", menujournalbouteillerendu.Properties.Value);
                            connexion.cmd.Parameters.AddWithValue("@menumvt", menumvts.Properties.Value);
                            connexion.connecter();
                            connexion.cmd.ExecuteNonQuery();
                            connexion.deconnecter();
                            XtraMessageBox.Show("Enregistrement effectuée");
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    finally
                    {
                    }
        }
        private void cmbusers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassConnexion connexion = new ClassConnexion();
            connexion.connecter();
            connexion.cmd.Connection = connexion.con;
            connexion.cmd.CommandText = ("SELECT iduser FROM TLogin WHERE UserName='" + cmbusers.EditValue + "'");
            try
            {
                connexion.connecter();
                connexion.dr = connexion.cmd.ExecuteReader();
                while (connexion.dr.Read())
                {
                    _idusers = connexion.dr.GetInt32(0);
                    textEdit1.EditValue = _idusers.ToString();
                    //checkEdit1.EditValue = connexion.dr.GetBoolean(2);
                    //checkEdit2.EditValue = connexion.dr.GetBoolean(3);
                    //checkEdit3.EditValue = connexion.dr.GetBoolean(4);
                    //checkEdit4.EditValue = connexion.dr.GetBoolean(5);
                    this.tmpAccesTableAdapter.Fill(dataSet1.tmpAcces, Convert.ToInt32(textEdit1.EditValue));
                }
                connexion.deconnecter();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            update_acces();
        }
    }
}

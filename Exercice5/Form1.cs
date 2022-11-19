/**
 * titre: BeautyShop projet
 * description: ajouter la list client avec les beautés produits classifiés
 * auteur: Khanh NGUYEN
 * date: 19/11/2022
 */
using System;
using System.Windows.Forms;

namespace Exercice5
{
    public partial class frmBeautyShop : Form
    {
        /// <summary>
        /// créer la classe mère Clients
        /// </summary>
        public abstract class Clients
        {
            // propriétés
            protected string login = "inconnu";
            protected int quantites;

            /// <summary>
            /// constructeur simple (inconnu)
            /// </summary>
            public Clients() { }

            /// <summary>
            /// constructeur de la class Clients
            /// </summary>
            /// <param name="login"></param>
            public Clients(string login)
            {
                this.login = login;
                
            }

            public int getQuantites()
            {
                return quantites;
            }
         
            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public abstract string info();

        }

        /// <summary>
        /// créer la classe fille de la class Clients
        /// </summary>
        public class SoinVisage : Clients
        {
            // déclaration
            string besoins;

            /// <summary>
            /// constructeur pour initialisation les besoins
            /// </summary>
            public SoinVisage(string besoins)
            {
                this.besoins = besoins;
            }

            /// <summary>
            /// constructeur pour initialisation le login et les besoins
            /// </summary>
            /// <param name="login"></param>
            /// <param name="besoins"></param>
            public SoinVisage(string login, string besoins, int quantites): base(login)
            {
                this.besoins = besoins;
                this.quantites = quantites;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override string info()
            {
                return "Soin Visage : " + login + " (" + besoins + ", quantité(s) : " + quantites + ")";
            }
        }

        /// <summary>
        /// cr
        /// </summary>
        public class Maquillage : Clients
        {
            // déclaration
            string marques;

            /// <summary>
            /// constructeur pour initialisation la marque
            /// </summary>
            /// <param name="marques"></param>
            public Maquillage(string marques)
            {
                this.marques = marques;
            }

            /// <summary>
            /// constructeur pour initialisation le login et la marque
            /// </summary>
            /// <param name="login"></param>
            /// <param name="marques"></param>
            public Maquillage(string login, string marques, int quantites): base (login)
            {
                this.marques = marques;
                this.quantites = quantites;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override string info()
            {
                return "Maquillage : " + login + " (" + marques + ", quantité(s) : " + quantites + ")";
            }
        }

        /// <summary>
        /// initialisation des components graphics
        /// </summary>
        public frmBeautyShop()
        {
            InitializeComponent();
        }

        // créer un tableau des clients
        Clients[] lesClients = new Clients[100];
        private int nbClient = 0;

        /// <summary>
        /// changement de la visible de la zone besoin et la zone marque
        /// </summary>
        /// <param name="visage"></param>
        private void changeVisible(bool visage)
        {
            // visible les besoins et son combo box
            lblBesoins.Visible = visage;
            cboBesoins.Visible = visage;

            // invisible les marques et son combo box
            lblMarques.Visible = !visage;
            cboMarques.Visible = !visage;
        }

        /// <summary>
        /// chargement de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBeautyShop_Load(object sender, EventArgs e)
        {
            rdbSoinVisage.Checked = true;
            changeVisible(true);
            cboBesoins.SelectedIndex = 0;
            cboMarques.SelectedIndex = 0;
            txtLogin.Text = "";
            txtLogin.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbSoinVisage_CheckedChanged(object sender, EventArgs e)
        {
            changeVisible(true);
        }

        private void rdbMaquillage_CheckedChanged(object sender, EventArgs e)
        {
            changeVisible(false);
        }

        /// <summary>
        /// mis à jour la list client
        /// </summary>
        private void MisAJourListClient()
        {
            // vider la list
            lstClients.Items.Clear();

            // remplir la list client
            for (int k = 0; k < nbClient; k++)
            {
                lstClients.Items.Add(lesClients[k].info());
            }
                
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // ajout un client dans la list
            nbClient++;

            // si clic sur le bouton radio Soin Visage
            if (rdbSoinVisage.Checked)
            {
                // si le text dans login est vidé (inconnu)
                if (txtLogin.Text == "") 
                {
                    lesClients[nbClient - 1] = new SoinVisage(cboBesoins.SelectedItem.ToString());
                }
                else
                {
                    lesClients[nbClient - 1] = new SoinVisage(txtLogin.Text.ToUpper(), cboBesoins.SelectedItem.ToString(), (int)nudQuantités.Value);
                }
            }
            else
            {
                // si le text dans login est vidé (inconnu)
                if (txtLogin.Text == "")
                {
                    lesClients[nbClient - 1] = new Maquillage(cboMarques.SelectedItem.ToString());
                }
                else
                {
                    lesClients[nbClient - 1] = new Maquillage(txtLogin.Text.ToUpper(), cboMarques.SelectedItem.ToString(), (int)nudQuantités.Value);
                }
            }
            // mis à jour la list
            MisAJourListClient();

            // vider le login et reposition sur le login
            txtLogin.Text = "";
            txtLogin.Focus();
        }
    }
}

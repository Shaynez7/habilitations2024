using Habilitations2024.controller;
using Habilitations2024.model;
using Habilitations2024.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Habilitations2024.view
{
    /// <summary>
    /// Fenêtre d'authentification (seuls les developpeurs profil "admin" peuvent accéder à l'application)
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmAuthentificationController controller;

        /// <summary>
        /// Conrtuction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations : 
        /// Création du controleur
        /// </summary>
        private void Init()
        {
            controller = new FrmAuthentificationController();
        }

        /// <summary>
        /// Demande au controleur de controler l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            String nom = txtNom.Text;
            String prenom = txtPrenom.Text;
            String pwd = txtPwd.Text;
            if (String.IsNullOrEmpty(nom) || String.IsNullOrEmpty(prenom) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Admin admin = new Admin(nom, prenom, pwd);
                if (controller.ControleAuthentification(admin))
                {
                    FrmHabilitations frm = new FrmHabilitations();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte");
                }
            }
        }

    }
}
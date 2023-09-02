using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HangmanGame
{
    public partial class frm_Accueil : Form
    {

        frm_ListeMots fenetre_listeMots;
        frm_ZoneJeu fenetre_zoneJeu;
        List<String> listeMotsATrouver;
        List<String> listeIndice;

        public frm_Accueil()
        {
            InitializeComponent();
            listeMotsATrouver = new List<String>() { "MAIALE","CANE", "GATTO", "ELEFANTE", "MAMMA", "NONNO", "PONY", "PECORA", "TRENO", "ZEBRA", "PALLONE"};
            listeIndice = new List<String>() { "MAIALE", "CANE", "GATTO", "ELEFANTE", "MAMMA", "NONNO", "PONY", "PECORA", "TRENO", "ZEBRA", "PALLONE" };
            //timer1.Start();
            panelBienvenue.Visible = false;
            //Play Peppa Pig Theme
            
            //SoundPlayer peppa_theme = new SoundPlayer(Properties.Resources.intro);
            //peppa_theme.PlaySync();
        }



        private void buttonClick(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
           
            switch (button.Name)
            {
                case "btnJouer":
                    if (listeMotsATrouver.Count == 0)
                    {
                        MessageBox.Show("Please Add Words", "Warning");
                    }
                    else
                    {
                        fenetre_zoneJeu = new frm_ZoneJeu(listeMotsATrouver, listeIndice);
                        fenetre_zoneJeu.ShowDialog();
                    }
                    break;
                case "btnMots":
                    fenetre_listeMots = new frm_ListeMots(ref listeMotsATrouver, ref listeIndice);
                    fenetre_listeMots.ShowDialog();
                    break;
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            panelBienvenue.Visible = false;
        }
    }
}

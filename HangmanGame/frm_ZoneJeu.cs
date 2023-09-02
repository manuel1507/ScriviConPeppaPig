using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class frm_ZoneJeu : Form
    {
        List<String> listeMotsATrouver; //List of words to find
        List<String> listeIndice;  //List of suggestions
        List<Label> labelName; //List for the labels
        List<Image> imageHangman; //List for images
        Random random;
        String motChoisi;
        int countWin;
        int countImage;
        int countTime;
        int countLabel;

        public frm_ZoneJeu(List<String> listeMotsATrouver, List<String> listeIndice)
        {
            InitializeComponent();
            this.listeMotsATrouver = new List<String>();
            this.listeIndice = new List<String>();
            labelName = new List<Label>();
            imageHangman = new List<Image>()
            {
                Properties.Resources.peppa,
                Properties.Resources.danny_cane,
                Properties.Resources.candy_gatto,
                Properties.Resources.emily_elefante,
                Properties.Resources.mamma_pig,
                Properties.Resources.nonno_pig,
                Properties.Resources.pedro_poni,
                Properties.Resources.susy_pecora,
                Properties.Resources.treno,
                Properties.Resources.zoe_zebra,
                Properties.Resources.pallone
            };
            random = new Random();
            countWin = 0;
            countImage = 0;
            countTime = 0;
            countLabel = 0;

            this.listeMotsATrouver = listeMotsATrouver;
            this.listeIndice = listeIndice;
            this.KeyDown += form_KeyDown;
            this.Select();
       
            initialise();
        }

       
        private void initialise()
        {
            //countImage = 0;
            countWin = 0;
            countTime = 0;
            countLabel= 0;
            //picImagePendu.BackgroundImage = imageHangman[countImage];
            picImagePendu.BackgroundImage = null;
            foreach (Button ctrl in table.Controls)
            {
                ctrl.BackColor = Color.White;
                ctrl.ForeColor = Color.DimGray;
            }

            //timer1.Start();

            deleteLabel();
            motChoisi = motSelectionner(listeMotsATrouver);
            instantationLabel(motChoisi.Length);
            lblIndice.Text = listeIndice[listeMotsATrouver.IndexOf(motChoisi)];
           
        }

        private String motSelectionner(List<String> listeMotsATrouver)
        {
            //return listeMotsATrouver[random.Next(0, listeMotsATrouver.Count)];
            return listeMotsATrouver[countImage];
        }

        private void createLabel(int largeur, int hauteur)
        {
            Label lbl = new Label();
            lbl.Text = "_";
            lbl.Location = new Point(largeur, hauteur);
            lbl.Size = new Size(39, 41);
            lbl.Font = new Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl.ForeColor = Color.White;
            labelName.Add(lbl);
            panel.Controls.Add(lbl);
        }

        private void deleteLabel()
        {
            foreach (Label lbl in labelName)
            {
                panel.Controls.Remove(lbl);
            }
            labelName.Clear();
        }
        private void instantationLabel(int nbreLettre)
        {
            int nombrePairImpair = 0;
            int hauteur = 323;

            if (nbreLettre % 2 == 1)
            {
                nombrePairImpair = 1;
            }
            int largeur = panel.Width / 2 - (((nbreLettre / 2)+ nombrePairImpair) * 45);
            
            for (int i = 0; i < this.motChoisi.Length; i++)
            {
                largeur += 40;
                createLabel(largeur, hauteur);
            }
        }

        private void buttonCaractere(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Char tagBtn = Convert.ToChar(button.Tag);
            bool trouver = verifierBtnCaractere(Char.ToUpper(tagBtn), ref button, ref countWin);
            if (!trouver)
            {
                //countImage++;
                button.BackColor = Color.Red;
                //picImagePendu.BackgroundImage = imageHangman[countImage];
            }
            verifierGagnant(countImage, ref countWin);

        }

        private bool verifierBtnCaractere(Char caractere, ref Button button, ref int count)
        {
            bool trouver = false;
            /*
            for (int i = 0; i < this.motChoisi.Length; i++)
            {
                if (caractere.Equals(motChoisi[i]))
                {
                    labelName[i].Text = caractere.ToString();
                    button.BackColor = Color.Gold;
                    button.ForeColor = Color.White;
                    trouver = true;
                    count++;
                }
            }
            */

            // From here it's new
            if (caractere.Equals(motChoisi[countLabel]))
                {
                    labelName[countLabel].Text = caractere.ToString();
                    button.BackColor = Color.Gold;
                    button.ForeColor = Color.White;
                    trouver = true;
                    count++;
                    countLabel++;
                }
            return trouver;
        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            Keys code = e.KeyCode;
            switch (code)
            {
                case Keys.A:
                    button2.PerformClick();
                    // code block
                    break;
                case Keys.B:
                    button1.PerformClick();
                    // code block
                    break;
                case Keys.C:
                    button3.PerformClick();
                    // code block
                    break;
                case Keys.D:
                    button4.PerformClick();
                    // code block
                    break;
                case Keys.E:
                    button5.PerformClick();
                    // code block
                    break;
                case Keys.F:
                    button6.PerformClick();
                    // code block
                    break;
                case Keys.G:
                    button7.PerformClick();
                    // code block
                    break;
                case Keys.H:
                    button8.PerformClick();
                    // code block
                    break;
                case Keys.I:
                    button9.PerformClick();
                    // code block
                    break;
                case Keys.J:
                    button10.PerformClick();
                    // code block
                    break;
                case Keys.K:
                    button11.PerformClick();
                    // code block
                    break;
                case Keys.L:
                    button12.PerformClick();
                    // code block
                    break;
                case Keys.M:
                    button13.PerformClick();
                    // code block
                    break;
                case Keys.N:
                    button14.PerformClick();
                    // code block
                    break;
                case Keys.O:
                    button15.PerformClick();
                    // code block
                    break;
                case Keys.P:
                    button16.PerformClick();
                    // code block
                    break;
                case Keys.Q:
                    button17.PerformClick();
                    // code block
                    break;
                case Keys.R:
                    button28.PerformClick();
                    // code block
                    break;
                case Keys.S:
                    button29.PerformClick();
                    // code block
                    break;
                case Keys.T:
                    button30.PerformClick();
                    // code block
                    break;
                case Keys.U:
                    button31.PerformClick();
                    // code block
                    break;
                case Keys.V:
                    button32.PerformClick();
                    // code block
                    break;
                case Keys.W:
                    button33.PerformClick();
                    // code block
                    break;
                case Keys.X:
                    button34.PerformClick();
                    // code block
                    break;
                case Keys.Y:
                    button35.PerformClick();
                    // code block
                    break;
                case Keys.Z:
                    button36.PerformClick();
                    // code block
                    break;
                case Keys.D0:
                    button37.PerformClick();
                    // code block
                    break;
                case Keys.D1:
                    button25.PerformClick();
                    // code block
                    break;
                case Keys.D2:
                    button24.PerformClick();
                    // code block
                    break;
                case Keys.D3:
                    button19.PerformClick();
                    // code block
                    break;
                case Keys.D4:
                    button26.PerformClick();
                    // code block
                    break;
                case Keys.D5:
                    button23.PerformClick();
                    // code block
                    break;
                case Keys.D6:
                    button20.PerformClick();
                    // code block
                    break;
                case Keys.D7:
                    button18.PerformClick();
                    // code block
                    break;
                case Keys.D8:
                    button22.PerformClick();
                    // code block
                    break;
                case Keys.D9:
                    button21.PerformClick();
                    // code block
                    break;
                 default:
                    // code block
                    break;
            }
        }

        private void verifierGagnant(int compteur, ref int compteurGagnant)
        {
            if (compteurGagnant == this.motChoisi.Length)
            {
                picImagePendu.BackgroundImage = imageHangman[countImage];
                rejouer("HAI VINTO, BRAVO", "VINTO");
                lblPoint.Text = (int.Parse(lblPoint.Text)+100).ToString();
                
               

            }
            /*
            if (compteur >= imageHangman.Count - 1)
            {
                rejouer("OH HAI PERSO, PECCATO!!", "PERSO");
            }
            */
        }

        private void rejouer(String phrase, String titre)
        {
            timer1.Stop();
            DialogResult message = MessageBox.Show(phrase, titre, MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
            {
                if(imageHangman.Count > countImage+1)
                {
                    countImage++;
                }
                else
                {
                    countImage--;
                    this.Close();
                }
                initialise();
            }
            else if (message == DialogResult.No)
            {
                this.Close();
            }
            lblGames.Text = (int.Parse(lblGames.Text) + 1).ToString();
        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countTime++;
            lblTime.Text = countTime.ToString();

            if(countTime == 200)
            {
                rejouer("Le temps est écoulé, Dommage!!", "Perdu");
            }
        }

    }
}

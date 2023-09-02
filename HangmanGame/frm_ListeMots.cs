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
    public partial class frm_ListeMots : Form
    {
        List<String> listeMotsATrouver;
        List<String> listeIndice;

        public frm_ListeMots(ref List<String> listeMotsATrouver, ref List<String> listeIndice)
        {
            InitializeComponent();
            this.listeMotsATrouver = new List<String>();
            this.listeIndice = new List<String>();
            this.listeMotsATrouver = listeMotsATrouver;
            this.listeIndice = listeIndice;
            RempListView();
        }

        public void RempListView()
        {
            liste.Items.Clear();
            foreach (String mot in listeMotsATrouver)
            {
                liste.Items.Add(mot);
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
            String err = "";

            switch (button.Tag.ToString())
            {
                case "add":
                    err = addWord(ref listeMotsATrouver, ref listeIndice);
                    break;
                case "delete":
                    err = deleteWord(ref listeMotsATrouver, ref listeIndice);
                    break;
            }
            RempListView();
            labelErreur.Text = err;
        }


        private bool verifWordList(String word)
        {
            bool verif = false;
            foreach (String e in listeMotsATrouver)
            {
                if (word.Equals(e))
                {
                    verif = true;
                }
            }
            return verif;
        }
        private bool numberCharacter(String text)
        {
            bool verif = false;
            if(text != "" && text.Length <=10)
            {
                verif = true;
            }
            return verif;
        }

        private String deleteWord(ref List<string> listeMotsATrouver, ref List<string> listeIndice)
        {
            String wordDelete = txtDelete.Text.ToLower();
            String err = "The word written is not in the list";


            if (numberCharacter(txtDelete.Text))
            {
                for (int i = 0; i < listeMotsATrouver.Count; i++)
                {
                    if (wordDelete.Equals(listeMotsATrouver[i]))
                    {
                        int position = listeMotsATrouver.IndexOf(wordDelete);
                        listeMotsATrouver.RemoveAt(position);
                        listeIndice.RemoveAt(position);
                        err = "The word has been deleted";
                    }
                }
            }
            else
            {
                err = "Please fill in the textBox";
            }
            txtDelete.Text = "";
            return err;
        }

        private String addWord(ref List<string> listeMotsATrouver, ref List<string> listeIndice)
        {
            String wordAdd = txtAdd.Text.ToUpper();
            String indice = txtIndice.Text.ToUpper();
            String err = "The word is in the list";
            bool verif = true;

            if (!numberCharacter(txtAdd.Text) || !numberCharacter(txtIndice.Text))
            {
                verif = false;
                err = "Text field is empty or greater than 10";
            }
            else if (verifWordList(wordAdd))
            {
                err = "The word is already in the list";
                verif = false;
            }
            if (verif)
            {
                listeMotsATrouver.Add(wordAdd);
                listeIndice.Add(indice);
            }

            txtAdd.Text = "";
            txtIndice.Text = "";
            return err;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}

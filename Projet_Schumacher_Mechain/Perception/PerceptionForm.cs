using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerceptionForm
{
    public partial class PerceptionForm : Form
    {
        Random rnd = new Random();
        string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" };
        string[][] imagesExo = new string[4][]; 
        public perception exo = new perception();
        int cpt = 0;
        double score = 0;
        int[] repUser = new int[3];
        int fig = 0;
        string []consigne = new string []
        {"Memorisez puis retranscrivez les chiffres présents dans les ronds jaunes. \nAttention, la position des formes est importante.",
            "Memorisez puis retranscrivez les chiffres présents dans les ronds bleus. \nAttention, la position des formes est importante.",
            "Memorisez puis retranscrivez les chiffres présents dans les carrés jaunes. \nAttention, la position des formes est importante.",
            "Memorisez puis retranscrivez les chiffres présents dans les carrés bleus. \nAttention, la position des formes est importante."};
        int c = 0;
        int[] reponses = new int[12];
        int[] bonneRep = new int[3];

        public PerceptionForm(int difficulte)
        {
            InitializeComponent();
            exo.difficulte = difficulte;
            imagesExo[0] = new string[] { "RJ0.png", "RJ1.png", "RJ2.png", "RJ3.png", "RJ4.png", "RJ5.png", "RJ6.png", "RJ7.png", "RJ8.png", "RJ9.png" };
            imagesExo[1] = new string[] { "RB0.png", "RB1.png", "RB2.png", "RB3.png", "RB4.png", "RB5.png", "RB6.png", "RB7.png", "RB8.png", "RB9.png" };
            imagesExo[2] = new string[] { "CJ0.png", "CJ1.png", "CJ2.png", "CJ3.png", "CJ4.png", "CJ5.png", "CJ6.png", "CJ7.png", "CJ8.png", "CJ9.png" };
            imagesExo[3] = new string[] { "CB0.png", "CB1.png", "CB2.png", "CB3.png", "CB4.png", "CB5.png", "CB6.png", "CB7.png", "CB8.png", "CB9.png" };     
        }

        private void Perception_Load(object sender, EventArgs e)
        {
            //exo.deserialiserPerception();
            string message = "Le but de cet exercice est de mémoriser des formes colorées dans un ensemble de formes ainsi que les chiffres qu'elles contiennent afin de les retranscrire. Le temps d'affichage des formes est limité, mais pas le temps de réponse.";
            MessageBox.Show(message,"Consigne de l'exercice");
 

            if (exo.difficulte == 0)
            {
                timer1.Interval = 4000;
            }
            else if (exo.difficulte == 1)
            {
                timer1.Interval = 2000;

            }

            //Sélection de la consigne
            c = rnd.Next(0, 3);
            EnonceLbl.ResetText();
            EnonceLbl.Visible = false;
            EnonceLbl.Text = consigne[c];
            EnonceLbl.Visible = true;

            //Affichage des images
            fig = rnd.Next(0, 9);
            PB1.ImageLocation = imagesExo[3][fig];
            PB1.Show();
            reponses[0] = fig;

            fig = rnd.Next(0, 9);
            PB2.ImageLocation = imagesExo[0][fig];
            PB2.Show();
            reponses[1] = fig;

            fig = rnd.Next(0, 9);
            PB3.ImageLocation = imagesExo[2][fig];
            PB3.Show();
            reponses[2] = fig;

            fig = rnd.Next(0, 9);
            PB4.ImageLocation = imagesExo[1][fig];
            PB4.Show();
            reponses[3] = fig;

            fig = rnd.Next(0, 9);
            PB5.ImageLocation = imagesExo[3][fig];
            PB5.Show();
            reponses[4] = fig;

            fig = rnd.Next(0, 9);
            PB6.ImageLocation = imagesExo[1][fig];
            PB6.Show();
            reponses[5] = fig;

            fig = rnd.Next(0, 9);
            PB7.ImageLocation = imagesExo[2][fig];
            PB7.Show();
            reponses[6] = fig;

            fig = rnd.Next(0, 9);
            PB8.ImageLocation = imagesExo[0][fig];
            PB8.Show();
            reponses[7] = fig;

            fig = rnd.Next(0, 9);
            PB9.ImageLocation = imagesExo[3][fig];
            PB9.Show();
            reponses[8] = fig;

            fig = rnd.Next(0, 9);
            PB10.ImageLocation = imagesExo[2][fig];
            PB10.Show();
            reponses[9] = fig;

            fig = rnd.Next(0, 9);
            PB11.ImageLocation = imagesExo[1][fig];
            PB11.Show();
            reponses[10] = fig;

            fig = rnd.Next(0, 9);
            PB12.ImageLocation = imagesExo[0][fig];
            PB12.Show();
            reponses[11] = fig;


                if (c == 0)
                {
                    lettre1Lbl.Text = alphabet[1];
                    lettre2Lbl.Text = alphabet[7];
                    lettre3Lbl.Text = alphabet[11];
                    bonneRep[0] = reponses[1];
                    bonneRep[1] = reponses[7];
                    bonneRep[2] = reponses[11];
                    
                }
                if (c == 1)
                {
                    lettre1Lbl.Text = alphabet[3];
                    lettre2Lbl.Text = alphabet[5];
                    lettre3Lbl.Text = alphabet[10];
                    bonneRep[0] = reponses[3];
                    bonneRep[1] = reponses[5];
                    bonneRep[2] = reponses[10];
                }
                if (c == 2)
                {
                    lettre1Lbl.Text = alphabet[2];
                    lettre2Lbl.Text = alphabet[6];
                    lettre3Lbl.Text = alphabet[9];
                    bonneRep[0] = reponses[2];
                    bonneRep[1] = reponses[6];
                    bonneRep[2] = reponses[9];
                }
                if (c == 3)
                {
                    lettre1Lbl.Text = alphabet[0];
                    lettre2Lbl.Text = alphabet[4];
                    lettre3Lbl.Text = alphabet[8];
                    bonneRep[0] = reponses[0];
                    bonneRep[1] = reponses[4];
                    bonneRep[2] = reponses[8];
                }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            PB1.Hide();
            PB2.Hide();
            PB3.Hide();
            PB4.Hide();
            PB5.Hide();
            PB6.Hide();
            PB7.Hide();
            PB8.Hide();
            PB9.Hide();
            PB10.Hide();
            PB11.Hide();
            PB12.Hide();

            ALbl.Hide();
            BLbl.Hide();
            CLbl.Hide();
            DLbl.Hide();
            ELbl.Hide();
            FLbl.Hide();
            GLbl.Hide();
            HLbl.Hide();
            ILbl.Hide();
            JLbl.Hide();
            KLbl.Hide();
            LLbl.Hide();

            consigneRep_Lbl.Show();
            lettre1Lbl.Show();
            lettre1TB.Show();
            lettre2Lbl.Show();
            lettre2TB.Show();
            lettre3Lbl.Show();
            lettre3TB.Show();
            ValiderBtn.Show();                      
        }

        private void ValiderBtn_Click(object sender, EventArgs e)
        {
            if (cpt < 9)
            {
                if (lettre1TB.Text != "")
                {
                    if (lettre2TB.Text != "")
                    {
                        if (lettre3TB.Text != "")
                        {
                            cpt++;
                            repUser[0] = int.Parse(lettre1TB.Text);
                            repUser[1] = int.Parse(lettre2TB.Text);
                            repUser[2] = int.Parse(lettre3TB.Text);
                            score = exo.calculeScore(repUser,bonneRep);

                            consigneRep_Lbl.Hide();
                            lettre1Lbl.Hide();
                            lettre1TB.Hide();
                            lettre2Lbl.Hide();
                            lettre2TB.Hide();
                            lettre3Lbl.Hide();
                            lettre3TB.Hide();
                            ValiderBtn.Hide();

                            lettre1Lbl.Text = "";
                            lettre2Lbl.Text = "";
                            lettre3Lbl.Text = "";
                            lettre1TB.Text = "";
                            lettre2TB.Text = "";
                            lettre3TB.Text = "";

                            c = rnd.Next(0, 3);
                            EnonceLbl.ResetText();
                            EnonceLbl.Visible = false;
                            EnonceLbl.Text = consigne[c];
                            EnonceLbl.Visible = true;

                            fig = rnd.Next(0, 9);
                            PB1.ImageLocation = imagesExo[3][fig];
                            PB1.Show();
                            reponses[0] = fig;

                            fig = rnd.Next(0, 9);
                            PB2.ImageLocation = imagesExo[0][fig];
                            PB2.Show();
                            reponses[1] = fig;

                            fig = rnd.Next(0, 9);
                            PB3.ImageLocation = imagesExo[2][fig];
                            PB3.Show();
                            reponses[2] = fig;

                            fig = rnd.Next(0, 9);
                            PB4.ImageLocation = imagesExo[1][fig];
                            PB4.Show();
                            reponses[3] = fig;

                            fig = rnd.Next(0, 9);
                            PB5.ImageLocation = imagesExo[3][fig];
                            PB5.Show();
                            reponses[4] = fig;

                            fig = rnd.Next(0, 9);
                            PB6.ImageLocation = imagesExo[1][fig];
                            PB6.Show();
                            reponses[5] = fig;

                            fig = rnd.Next(0, 9);
                            PB7.ImageLocation = imagesExo[2][fig];
                            PB7.Show();
                            reponses[6] = fig;

                            fig = rnd.Next(0, 9);
                            PB8.ImageLocation = imagesExo[0][fig];
                            PB8.Show();
                            reponses[7] = fig;

                            fig = rnd.Next(0, 9);
                            PB9.ImageLocation = imagesExo[3][fig];
                            PB9.Show();
                            reponses[8] = fig;

                            fig = rnd.Next(0, 9);
                            PB10.ImageLocation = imagesExo[2][fig];
                            PB10.Show();
                            reponses[9] = fig;

                            fig = rnd.Next(0, 9);
                            PB11.ImageLocation = imagesExo[1][fig];
                            PB11.Show();
                            reponses[10] = fig;

                            fig = rnd.Next(0, 9);
                            PB12.ImageLocation = imagesExo[0][fig];
                            PB12.Show();
                            reponses[11] = fig;


                            if (c == 0)
                            {
                                lettre1Lbl.Text = alphabet[1];
                                lettre2Lbl.Text = alphabet[7];
                                lettre3Lbl.Text = alphabet[11];
                                bonneRep[0] = reponses[1];
                                bonneRep[1] = reponses[7];
                                bonneRep[2] = reponses[11];

                            }
                            if (c == 1)
                            {
                                lettre1Lbl.Text = alphabet[3];
                                lettre2Lbl.Text = alphabet[5];
                                lettre3Lbl.Text = alphabet[10];
                                bonneRep[0] = reponses[3];
                                bonneRep[1] = reponses[5];
                                bonneRep[2] = reponses[10];
                            }
                            if (c == 2)
                            {
                                lettre1Lbl.Text = alphabet[2];
                                lettre2Lbl.Text = alphabet[6];
                                lettre3Lbl.Text = alphabet[9];
                                bonneRep[0] = reponses[2];
                                bonneRep[1] = reponses[6];
                                bonneRep[2] = reponses[9];
                            }
                            if (c == 3)
                            {
                                lettre1Lbl.Text = alphabet[0];
                                lettre2Lbl.Text = alphabet[4];
                                lettre3Lbl.Text = alphabet[8];
                                bonneRep[0] = reponses[0];
                                bonneRep[1] = reponses[4];
                                bonneRep[2] = reponses[8];
                            }


                            PB1.Show();
                            PB2.Show();
                            PB3.Show();
                            PB4.Show();
                            PB5.Show();
                            PB6.Show();
                            PB7.Show();
                            PB8.Show();
                            PB9.Show();
                            PB10.Show();
                            PB11.Show();
                            PB12.Show();

                            ALbl.Show();
                            BLbl.Show();
                            CLbl.Show();
                            DLbl.Show();
                            ELbl.Show();
                            FLbl.Show();
                            GLbl.Show();
                            HLbl.Show();
                            ILbl.Show();
                            JLbl.Show();
                            KLbl.Show();
                            LLbl.Show();

                            timer1.Start();
                        }
                        else
                        {
                            string message = "Veuillez remplir tous les champs !";
                            MessageBox.Show(message, "Erreur");
                        }
                    }
                    else
                    {
                        string message = "Veuillez remplir tous les champs !";
                        MessageBox.Show(message, "Erreur");
                    }

                }
                else
                {
                    string message = "Veuillez remplir tous les champs !";
                    MessageBox.Show(message, "Erreur");
                }   
            }
           else
           {
                score = (score / 30) * 100;
                string message = "Vous avez " + score + "% de bonnes réponses !";
                MessageBox.Show(message, "Score");
                this.Close();
           }
        }

        private void DLbl_Click(object sender, EventArgs e)
        {

        }

        private void PB6_Click(object sender, EventArgs e)
        {

        }

        private void lettre1Lbl_Click(object sender, EventArgs e)
        {

        }

        private void ILbl_Click(object sender, EventArgs e)
        {

        }

        private void consigneRep_Lbl_Click(object sender, EventArgs e)
        {

        }


    }
}

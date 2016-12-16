using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pb_Mathematique
{
    public partial class Pb_Mathematique : Form
    {
        
        pb_maths exo = new pb_maths();
        probleme pb = new probleme();
        int nbPb = 0;
        double score = 0;
        bool verif = false;

        public Pb_Mathematique(int difficulte)
        {
            InitializeComponent();
            exo.difficulte = difficulte;
            //exo.deserialiserPbMaths();           
        }

        private void ok_Btn_Click(object sender, EventArgs e)
        {
            if (nbPb < 9)
            {
                string repUser = "";
                if (choix1_RB.Checked)
                {
                    repUser = choix1_RB.Text;
                }
                else if (choix2_RB.Checked)
                {
                    repUser = choix2_RB.Text;
                }
                else if (choix3_RB.Checked)
                {
                    repUser = choix3_RB.Text;
                }
                else
                {
                    repUser = choix4_RB.Text;
                }

                verif = exo.verificationReponse(repUser, pb);
                if (verif == true)
                {
                    reponseLbl.Text = "Bonne réponse !";
                }
                else
                {
                    reponseLbl.Text = "Mauvaise réponse !";
                }
                score = exo.calculeScore(repUser, pb);
                nbPb++;

                reponseLbl.Visible = true;
                timer1.Start();

                enonce_Pb_Lbl.Hide();
                imagePb_PB.Hide();
                choix1_RB.Hide();
                choix2_RB.Hide();
                choix3_RB.Hide();
                choix4_RB.Hide();

                enonce_Pb_Lbl.Text = "";
                choix1_RB.Text = "";
                choix2_RB.Text = "";
                choix3_RB.Text = "";
                choix4_RB.Text = "";

                pb = exo.selectionItem();
                enonce_Pb_Lbl.Text = pb.enonce;
                if (pb == exo.problemes_difficiles[7])
                {
                    imagePb_PB.Image = Image.FromFile("ImagePb8Difficile.png");
                }
                else if (pb == exo.problemes_difficiles[0])
                {
                    imagePb_PB.Image = Image.FromFile("Pb_difficile0.png");
                }
                else
                {
                    imagePb_PB.Image = Image.FromFile("ImageNeutre.png");
                }
                choix1_RB.Text = pb.choix1;
                choix2_RB.Text = pb.choix2;
                choix3_RB.Text = pb.choix3;
                choix4_RB.Text = pb.choix4;

                enonce_Pb_Lbl.Show();
                imagePb_PB.Show();
                choix1_RB.Show();
                choix2_RB.Show();
                choix3_RB.Show();
                choix4_RB.Show();
            }
            else
            {
                string message = "Votre score est de " + score + "/10 !";
                MessageBox.Show(message);
                this.Close();
            }   
        }      

        private void Pb_Mathematique_Load(object sender, EventArgs e)
        {
            consigne_Lbl.Text = exo.consigne;

            pb = exo.selectionItem();

            enonce_Pb_Lbl.Text = pb.enonce;
            if (pb == exo.problemes_difficiles[7])
            {
                imagePb_PB.Image = Image.FromFile("ImagePb8Difficile.png");
            }
            else if (pb == exo.problemes_difficiles[0])
            {
                imagePb_PB.Image = Image.FromFile("Pb_difficile0.png");
            }
            else
            {
                imagePb_PB.Image = Image.FromFile("ImageNeutre.png");
            }
            choix1_RB.Text = pb.choix1;
            choix2_RB.Text = pb.choix2;
            choix3_RB.Text = pb.choix3;
            choix4_RB.Text = pb.choix4;

            

        }

        private void imagePb_PB_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reponseLbl.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pb_Physique
{
    public partial class Pb_Physique : Form
    {
        pb_phys exo = new pb_phys();
        probleme pb = new probleme();
        int nbPb = 0;
        double score = 0;
        bool verif = false;

        public Pb_Physique(int difficulte)
        {
            InitializeComponent();
            exo.difficulte = difficulte;
            //exo.deserialiserPbPhysique();
        }

        private void Valider_Btn_Click(object sender, EventArgs e)
        {
            if(nbPb < 9)
            {

                string repUser = "";
                if (Choix1_RB.Checked)
                {
                    repUser = Choix1_RB.Text;
                }
                else if (Choix2_RB.Checked)
                {
                    repUser = Choix2_RB.Text;
                }
                else if (Choix3_RB.Checked)
                {
                    repUser = Choix3_RB.Text;
                }
                else
                {
                    repUser = Choix4_RB.Text;
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


                enonce_Lbl.Hide();
                ImagePbPhysique_PB.Hide();
                Choix1_RB.Hide();
                Choix2_RB.Hide();
                Choix3_RB.Hide();
                Choix4_RB.Hide();

                enonce_Lbl.ResetText();
                Choix2_RB.ResetText();
                Choix3_RB.ResetText();
                Choix4_RB.ResetText();
                Choix1_RB.ResetText();

                pb = exo.selectionItem();

                enonce_Lbl.Text = pb.enonce;
                if (pb == exo.problemes[7])
                {
                    ImagePbPhysique_PB.Image = Image.FromFile("pb_physique8.png");
                }
                else if (pb == exo.problemes[1])
                {
                    ImagePbPhysique_PB.Image = Image.FromFile("pb_physique2.png");
                }
                else if (pb == exo.problemes[0])
                {
                    ImagePbPhysique_PB.Image = Image.FromFile("Image_pb_physique_1.png");
                }
                else
                {
                    ImagePbPhysique_PB.Image = Image.FromFile("ImageNeutre.png");
                }           
                Choix1_RB.Text = pb.choix1;
                Choix2_RB.Text = pb.choix2;
                Choix3_RB.Text = pb.choix3;
                Choix4_RB.Text = pb.choix4;

                enonce_Lbl.Show();
                ImagePbPhysique_PB.Show();
                Choix1_RB.Show();
                Choix2_RB.Show();
                Choix3_RB.Show();
                Choix4_RB.Show();
            }
            else
            {
                string message = "Votre score est de " + score + "/10.";
                MessageBox.Show(message);
                this.Close();
            }           
        }

        private void Pb_Physique_Load(object sender, EventArgs e)
        {
            consigne_Lbl.Text = exo.consigne;

            enonce_Lbl.ResetText();
            Choix2_RB.ResetText();
            Choix3_RB.ResetText();
            Choix4_RB.ResetText();
            Choix1_RB.ResetText();

            pb = exo.selectionItem();

            enonce_Lbl.Text = pb.enonce;
            if (pb == exo.problemes[7])
            {
                ImagePbPhysique_PB.Image = Image.FromFile("pb_physique8.png");
            }
            else if (pb == exo.problemes[1])
            {
                ImagePbPhysique_PB.Image = Image.FromFile("pb_physique2.png");
            }
            else if (pb == exo.problemes[0])
            {
                ImagePbPhysique_PB.Image = Image.FromFile("Image_pb_physique_1.png");
            }
            else
            {
                ImagePbPhysique_PB.Image = Image.FromFile("ImageNeutre.png");
            }           
            Choix1_RB.Text = pb.choix1;
            Choix2_RB.Text = pb.choix2;
            Choix3_RB.Text = pb.choix3;
            Choix4_RB.Text = pb.choix4;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reponseLbl.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attention
{
    public partial class Attention : Form
    {
        attention Att = new attention();
        int num_seq = 1;
        int num_im = 0;
        int rep;
        int nb_bonneRep;
        int sec_FormeSuiv=0;
        int compteur = 0;
        int sec_difficult = 0;

        public Attention()
        {
            InitializeComponent();
        }

        private void Btn_Validation_Click(object sender, EventArgs e)
        {
            Btn_Validation.Visible = false;
            Att.Selection_Cons();
            Lbl_Consigne.Text = " Bouton 1: " + Att.Consigne_Select[0] +"\n Bouton 2: " + Att.Consigne_Select[1];
            Btn_Depart.Visible = true;
        }

        private void Btn_Depart_Click(object sender, EventArgs e)
        {
            num_im = 0;
            compteur = 0;
            Lbl_Consigne.Visible = false;
            Btn_Depart.Visible = false;
            switch(num_seq)
            {
                case 1:
                    Forme.Image = Image.FromFile(Att.seq1[0]);
                    Forme.Visible = true;
                    Btn3.Visible = true;
                    Btn1.Visible = true;
                    Btn2.Visible = true;
                    Btn2.Enabled = false;
                    Btn1.Enabled = false;
                    break;
                case 2:
                    Forme.Image = Image.FromFile(Att.seq2[0]);
                    Forme.Visible = true;
                    Btn3.Visible = true;
                    Btn1.Visible = true;
                    Btn2.Visible = true;
                    Btn2.Enabled = false;
                    Btn1.Enabled = false;
                    Btn3.Enabled = true;
                    break;
                case 3:
                    Forme.Image = Image.FromFile(Att.seq3[0]);
                    Forme.Visible = true;
                    Btn3.Visible = true;
                    Btn1.Visible = true;
                    Btn2.Visible = true;
                    Btn2.Enabled = false;
                    Btn1.Enabled = false;
                    Btn3.Enabled = true;
                    break;
            }
            Timer_Difficile.Start();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Timer_Difficile.Stop();
            sec_difficult = 0;
            rep = 3;
            switch(num_seq)
            {
                case 1:
                    if (compteur < 4)
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;
                        

                        if (rep == Att.bonne_rep1[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep1[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();

                        num_im++;
                        compteur++;
                        Forme.Image = Image.FromFile(Att.seq1[num_im]);
                    }
                    else
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;
                        

                        if (rep == Att.bonne_rep1[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep1[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();
                        
                        compteur++;
                    }
                    break;
                case 2:
                    if (compteur < 4)
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;


                        if (rep == Att.bonne_rep2[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep2[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();

                        num_im++;
                        compteur++;
                        Forme.Image = Image.FromFile(Att.seq2[num_im]);
                    }
                    else
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;


                        if (rep == Att.bonne_rep2[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep2[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();

                        compteur++;
                    }
                    break;
                case 3:
                    if (compteur < 4)
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;
                        

                        if (rep == Att.bonne_rep3[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep1[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();

                        num_im++;
                        compteur++;
                        Forme.Image = Image.FromFile(Att.seq3[num_im]);
                    }
                    else
                    {
                        Btn1.Visible = false;
                        Btn2.Visible = false;
                        Btn3.Visible = false;
                        Forme.Visible = false;
                        

                        if (rep == Att.bonne_rep1[num_im])
                            nb_bonneRep++;

                        nb_bonneRep = nb_bonneRep * 100 / 15;

                        string fin = "L'épreuve est terminée ! \n Vous avez " + nb_bonneRep + "%  de bonnes réponses";
                        MessageBox.Show(fin, "fin de l'exercice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }

        private void Timer_FormeSuiv_Tick(object sender, EventArgs e)
        {
            if (sec_FormeSuiv < 2)
                sec_FormeSuiv++;
            else
            {
                Timer_FormeSuiv.Stop();

                if (compteur < 5)
                {
                    Forme.Visible = true;
                    Btn1.Enabled = true;
                    Btn2.Enabled = true;
                    Btn3.Enabled = true;
                    Lbl_Validation.Visible = false;
                }
                else
                {
                    Lbl_Validation.Visible = false;
                    Lbl_Consigne.Visible = true;
                    Btn_Depart.Visible = true;
                    num_seq++;
                }
                sec_FormeSuiv = 0;
                Timer_Difficile.Stop();
                sec_difficult = 0;
                Timer_Difficile.Start();
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Timer_Difficile.Start();
            sec_difficult = 0;
            rep = 1;
            switch (num_seq)
            {
                case 1:
                    if (compteur < 4)
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;


                        if (rep == Att.bonne_rep1[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep1[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();

                        num_im++;
                        compteur++;
                        Forme.Image = Image.FromFile(Att.seq1[num_im]);
                    }
                    else
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;


                        if (rep == Att.bonne_rep1[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep1[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();

                        compteur++;
                    }
                    break;
                case 2:
                    if (compteur < 4)
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;


                        if (rep == Att.bonne_rep2[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep2[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();

                        num_im++;
                        compteur++;
                        Forme.Image = Image.FromFile(Att.seq2[num_im]);
                    }
                    else
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;


                        if (rep == Att.bonne_rep2[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep2[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();

                        compteur++;
                    }
                    break;
                case 3:
                    if (compteur < 4)
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;


                        if (rep == Att.bonne_rep3[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep1[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();

                        num_im++;
                        compteur++;
                        Forme.Image = Image.FromFile(Att.seq3[num_im]);
                    }
                    else
                    {
                        Btn1.Visible = false;
                        Btn2.Visible = false;
                        Btn3.Visible = false;
                        Forme.Visible = false;


                        if (rep == Att.bonne_rep1[num_im])
                            nb_bonneRep++;

                        nb_bonneRep = nb_bonneRep * 100 / 15;

                        string fin = "L'épreuve est terminée ! \n Vous avez " + nb_bonneRep + "%  de bonnes réponses";
                        MessageBox.Show(fin, "fin de l'exercice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Timer_Difficile.Start();
            sec_difficult = 0;
            rep = 2;

            switch (num_seq)
            {
                case 1:
                    if (compteur < 4)
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;


                        if (rep == Att.bonne_rep1[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep1[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();

                        num_im++;
                        compteur++;
                        Forme.Image = Image.FromFile(Att.seq1[num_im]);
                    }
                    else
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;


                        if (rep == Att.bonne_rep1[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep1[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();

                        compteur++;
                    }
                    break;
                case 2:
                    if (compteur < 4)
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;


                        if (rep == Att.bonne_rep2[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep2[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();

                        num_im++;
                        compteur++;
                        Forme.Image = Image.FromFile(Att.seq2[num_im]);
                    }
                    else
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;


                        if (rep == Att.bonne_rep2[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep2[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();

                        compteur++;
                    }
                    break;
                case 3:
                    if (compteur < 4)
                    {
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Forme.Visible = false;


                        if (rep == Att.bonne_rep3[num_im])
                        {
                            Lbl_Validation.Text = "OK";
                            nb_bonneRep++;
                        }
                        else
                            Lbl_Validation.Text = "Mauvaise réponse ! La bonne réponse était : " + Att.bonne_rep1[num_im];


                        Lbl_Validation.Visible = true;
                        Timer_FormeSuiv.Start();

                        num_im++;
                        compteur++;
                        Forme.Image = Image.FromFile(Att.seq3[num_im]);
                    }
                    else
                    {
                        Btn1.Visible = false;
                        Btn2.Visible = false;
                        Btn3.Visible = false;
                        Forme.Visible = false;


                        if (rep == Att.bonne_rep1[num_im])
                            nb_bonneRep++;

                        nb_bonneRep = nb_bonneRep * 100 / 15;

                        string fin = "L'épreuve est terminée ! \n Vous avez " + nb_bonneRep + "%  de bonnes réponses";
                        MessageBox.Show(fin, "fin de l'exercice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }

        private void Timer_Difficile_Tick(object sender, EventArgs e)
        {
            if (sec_difficult < 5)
                sec_difficult++;
            else
            {
                Btn1.Enabled = false;
                Btn2.Enabled = false;
                Btn3.Enabled = false;
                Forme.Visible = false;

                switch (num_seq)
                {
                    case 1:
                        Timer_FormeSuiv.Start();

                        Lbl_Validation.Text = "Trop tard !";
                        Lbl_Validation.Visible = true;
                        if (compteur < 4)
                        {
                            num_im++;
                            compteur++;

                            Forme.Image = Image.FromFile(Att.seq1[num_im]);
                        }
                        else
                            compteur++;
                        break;
                    case 2:
                        Timer_FormeSuiv.Start();

                        Lbl_Validation.Text = "Trop tard !";
                        Lbl_Validation.Visible = true;
                        if (compteur < 4)
                        {
                            num_im++;
                            compteur++;

                            Forme.Image = Image.FromFile(Att.seq2[num_im]);
                        }
                        else
                            compteur++;
                        break;
                    case 3:
                        Timer_FormeSuiv.Start();

                        Lbl_Validation.Text = "Trop tard !";
                        Lbl_Validation.Visible = true;
                        if (compteur < 4)
                        {
                            num_im++;
                            compteur++;

                            Forme.Image = Image.FromFile(Att.seq3[num_im]);
                        }
                        else
                        {
                            string fin = "L'épreuve est terminée ! \n Vous avez " + nb_bonneRep + "%  de bonnes réponses";
                            MessageBox.Show(fin, "fin de l'exercice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                }
            }
        }

        private void Lbl_Consigne_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul_Mental
{
    public partial class calculMental : Form
    {
        int Compteur_Operation = 0;
        int Bonne_Rep;
        int sec_OpSuiv = 0;
        int sec_difficile = 0;
        calcul operations = new calcul();
        int nb_Bonne_Rep = 0;
        Boolean Difficile = true;

        public calculMental()
        {
            InitializeComponent();
        }

        private void Btn_Multiplication_Click(object sender, EventArgs e)
        {
            Btn_Addition.Enabled = false;
            Btn_Division.Enabled = false;
            Btn_Multiplication.Enabled = false;
            Btn_Soustraction.Enabled = false;

            Lbl_Calcul.Visible = true;
            Lbl_Egal.Visible = true;
            TextB_Reponse.Visible = true;
            Btn_Validation.Visible = true;

            if (Difficile == true)
                Timer_Difficulte.Start();

            operations.Multiplication();
            Lbl_Calcul.Text = operations.tabCalcul[Compteur_Operation];
            Bonne_Rep = operations.tabRep[Compteur_Operation];
        }

        private void Btn_Soustraction_Click(object sender, EventArgs e)
        {
            Btn_Addition.Enabled = false;
            Btn_Division.Enabled = false;
            Btn_Multiplication.Enabled = false;
            Btn_Soustraction.Enabled = false;

            Lbl_Calcul.Visible = true;
            Lbl_Egal.Visible = true;
            TextB_Reponse.Visible = true;
            Btn_Validation.Visible = true;

            if (Difficile == true)
                Timer_Difficulte.Start();

            operations.Soustraction();
            Lbl_Calcul.Text = operations.tabCalcul[Compteur_Operation];
            Bonne_Rep = operations.tabRep[Compteur_Operation];
        }

        private void Btn_Addition_Click(object sender, EventArgs e)
        {
            Btn_Addition.Enabled = false;
            Btn_Division.Enabled = false;
            Btn_Multiplication.Enabled = false;
            Btn_Soustraction.Enabled = false;

            Lbl_Calcul.Visible = true;
            Lbl_Egal.Visible = true;
            TextB_Reponse.Visible = true;
            Btn_Validation.Visible = true;

            if (Difficile == true)
                Timer_Difficulte.Start();


            operations.Addition();
            Lbl_Calcul.Text = operations.tabCalcul[Compteur_Operation];
            Bonne_Rep = operations.tabRep[Compteur_Operation];
        }

        private void Btn_Division_Click(object sender, EventArgs e)
        {
            Btn_Addition.Enabled = false;
            Btn_Division.Enabled = false;
            Btn_Multiplication.Enabled = false;
            Btn_Soustraction.Enabled = false;

            Lbl_Calcul.Visible = true;
            Lbl_Egal.Visible = true;
            TextB_Reponse.Visible = true;
            Btn_Validation.Visible = true;
            Lbl_Consigne_div.Visible = true;

            if (Difficile == true)
                Timer_Difficulte.Start();

            operations.Division();
            Lbl_Calcul.Text = operations.tabCalcul[Compteur_Operation];
            Bonne_Rep = operations.tabRep[Compteur_Operation];
        }

        private void Btn_Validation_Click(object sender, EventArgs e)
        {
            Timer_Difficulte.Stop();
            sec_difficile = 0;
            Btn_Validation.Enabled = false;

            if (Compteur_Operation < 9)
            {
                string bonne_rep = "" + Bonne_Rep;
                if (TextB_Reponse.Text == bonne_rep)
                {
                    Lbl_Info_Rep.Text = "OK";
                    nb_Bonne_Rep++;
                }
                else
                    Lbl_Info_Rep.Text = "Mauvaise réponse, la bonne réponse était " + bonne_rep;

                Lbl_Info_Rep.Visible = true;
                Timer_OpSuiv.Start();

                Lbl_Calcul.Text = "";
                TextB_Reponse.Text = "";

                Lbl_Calcul.Visible = false;
                Lbl_Egal.Visible = false;
                TextB_Reponse.Visible = false;

                Compteur_Operation++;
                Timer_Difficulte.Start();
                Lbl_Calcul.Text = operations.tabCalcul[Compteur_Operation];
                Bonne_Rep = operations.tabRep[Compteur_Operation];
            }
            else
            {
                string bonne_rep = "" + Bonne_Rep;
                if (TextB_Reponse.Text == bonne_rep)
                {
                    nb_Bonne_Rep++;
                }
                string fin = "L'épreuve est terminée ! \n Vous avez " + nb_Bonne_Rep * 10 + "%  de bonnes réponses";
                MessageBox.Show(fin, "fin de l'exercice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Timer_OpSuiv_Tick(object sender, EventArgs e)
        {
            if (sec_OpSuiv < 3)
                sec_OpSuiv++;
            else
            {
                Timer_OpSuiv.Stop();

                Lbl_Info_Rep.Visible = false;
                Lbl_Calcul.Visible = true;
                Lbl_Egal.Visible = true;
                TextB_Reponse.Visible = true;
                Btn_Validation.Enabled = true;
            }
        }

        private void Timer_Difficulte_Tick(object sender, EventArgs e)
        {
            if (sec_difficile < 5)
                sec_difficile++;
            else
            {
                Timer_Difficulte.Stop();
                Lbl_Calcul.Visible = false;
                Lbl_Egal.Visible = false;
                TextB_Reponse.Visible = false;
                Btn_Validation.Enabled = false;

                if (Compteur_Operation < 9)
                {
                    Lbl_Info_Rep.Text = "Trop tard !";
                    TextB_Reponse.Text = "";
                    Lbl_Info_Rep.Visible = true;
                    Timer_OpSuiv.Start();

                    Lbl_Calcul.Text = "";
                    TextB_Reponse.Text = "";

                    Lbl_Calcul.Visible = false;
                    Lbl_Egal.Visible = false;
                    TextB_Reponse.Visible = false;

                    Compteur_Operation++;
                    Lbl_Calcul.Text = operations.tabCalcul[Compteur_Operation];
                    Bonne_Rep = operations.tabRep[Compteur_Operation];
                    sec_difficile = 0;
                    Timer_Difficulte.Start();
                }
                else
                {
                    string fin = "L'épreuve est terminée ! \n Vous avez " + nb_Bonne_Rep * 10 + "%  de bonnes réponses";
                    MessageBox.Show(fin, "fin de l'exercice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sec_difficile = 0;
            }
        }

        private void calculMental_Load(object sender, EventArgs e)
        {

        }
    }
}

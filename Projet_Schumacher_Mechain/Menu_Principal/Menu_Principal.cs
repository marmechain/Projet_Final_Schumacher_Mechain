using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerceptionForm;

namespace Menu_Principal
{
    public partial class Menu_Principal : Form
    {
        public int difficulte = 0;
        
        

        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void facileRBtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void difficileRBtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void PerceptionBtn_Click(object sender, EventArgs e)
        {
                       
            PerceptionForm.PerceptionForm frm = new PerceptionForm.PerceptionForm(difficulte);
            frm.Show();

            PerceptionBtn.Enabled = false;
            AttentionBtn.Enabled = false;
            pb_mathematique_Btn.Enabled = false;
            pb_physique_Btn.Enabled = false;
            calcul_mental_Btn.Enabled = false;

        }

        private void AttentionBtn_Click(object sender, EventArgs e)
        {
            Attention.Attention frm = new Attention.Attention();
            frm.Show();

            PerceptionBtn.Enabled = false;
            AttentionBtn.Enabled = false;
            pb_mathematique_Btn.Enabled = false;
            pb_physique_Btn.Enabled = false;
            calcul_mental_Btn.Enabled = false;
        }

        private void calcul_mental_Btn_Click(object sender, EventArgs e)
        {
            
                Calcul_Mental.calculMental frm = new Calcul_Mental.calculMental();
                frm.Show();

                PerceptionBtn.Enabled = false;
                AttentionBtn.Enabled = false;
                pb_mathematique_Btn.Enabled = false;
                pb_physique_Btn.Enabled = false;
                calcul_mental_Btn.Enabled = false;

        }

        private void pb_mathematique_Btn_Click(object sender, EventArgs e)
        {
            
                Pb_Mathematique.Pb_Mathematique frm = new Pb_Mathematique.Pb_Mathematique(difficulte);
                frm.Show();

                PerceptionBtn.Enabled = false;
                AttentionBtn.Enabled = false;
                pb_mathematique_Btn.Enabled = false;
                pb_physique_Btn.Enabled = false;
                calcul_mental_Btn.Enabled = false;
            
        }

        private void pb_physique_Btn_Click(object sender, EventArgs e)
        {
           
                difficulte = 1;
                Pb_Physique.Pb_Physique frm = new Pb_Physique.Pb_Physique(difficulte);
                frm.Show();

                PerceptionBtn.Enabled = false;
                AttentionBtn.Enabled = false;
                pb_mathematique_Btn.Enabled = false;
                pb_physique_Btn.Enabled = false;
                calcul_mental_Btn.Enabled = false;


            
        }

        private void validerBtn_Click(object sender, EventArgs e)
        {
            if (difficileRBtn.Checked)
            {
                difficulte = 1;
            }
            else if (facileRBtn.Checked)
            {
                difficulte = 0;
            }

            PerceptionBtn.Enabled = true;
            AttentionBtn.Enabled = true;
            pb_mathematique_Btn.Enabled = true;
            pb_physique_Btn.Enabled = true;
            calcul_mental_Btn.Enabled = true;
        }

        private void pres_Lbl_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        


    }
}

namespace Calcul_Mental
{
    partial class calculMental
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Lbl_Calcul = new System.Windows.Forms.Label();
            this.Lbl_Info_Rep = new System.Windows.Forms.Label();
            this.Btn_Validation = new System.Windows.Forms.Button();
            this.TextB_Reponse = new System.Windows.Forms.TextBox();
            this.Lbl_Egal = new System.Windows.Forms.Label();
            this.Lbl_Consigne_div = new System.Windows.Forms.Label();
            this.Btn_Division = new System.Windows.Forms.Button();
            this.Btn_Multiplication = new System.Windows.Forms.Button();
            this.Btn_Soustraction = new System.Windows.Forms.Button();
            this.Btn_Addition = new System.Windows.Forms.Button();
            this.Lbl_Choix_Calcul = new System.Windows.Forms.Label();
            this.Timer_OpSuiv = new System.Windows.Forms.Timer(this.components);
            this.Timer_Difficulte = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Lbl_Calcul
            // 
            this.Lbl_Calcul.AutoSize = true;
            this.Lbl_Calcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Calcul.Location = new System.Drawing.Point(371, 335);
            this.Lbl_Calcul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Calcul.Name = "Lbl_Calcul";
            this.Lbl_Calcul.Size = new System.Drawing.Size(99, 32);
            this.Lbl_Calcul.TabIndex = 24;
            this.Lbl_Calcul.Text = "label1";
            this.Lbl_Calcul.Visible = false;
            // 
            // Lbl_Info_Rep
            // 
            this.Lbl_Info_Rep.AutoSize = true;
            this.Lbl_Info_Rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Info_Rep.Location = new System.Drawing.Point(667, 494);
            this.Lbl_Info_Rep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Info_Rep.Name = "Lbl_Info_Rep";
            this.Lbl_Info_Rep.Size = new System.Drawing.Size(64, 25);
            this.Lbl_Info_Rep.TabIndex = 23;
            this.Lbl_Info_Rep.Text = "label1";
            this.Lbl_Info_Rep.Visible = false;
            // 
            // Btn_Validation
            // 
            this.Btn_Validation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Btn_Validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Validation.Location = new System.Drawing.Point(522, 488);
            this.Btn_Validation.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Validation.Name = "Btn_Validation";
            this.Btn_Validation.Size = new System.Drawing.Size(100, 37);
            this.Btn_Validation.TabIndex = 22;
            this.Btn_Validation.Text = "Valider";
            this.Btn_Validation.UseVisualStyleBackColor = true;
            this.Btn_Validation.Visible = false;
            this.Btn_Validation.Click += new System.EventHandler(this.Btn_Validation_Click);
            // 
            // TextB_Reponse
            // 
            this.TextB_Reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextB_Reponse.Location = new System.Drawing.Point(635, 335);
            this.TextB_Reponse.Margin = new System.Windows.Forms.Padding(4);
            this.TextB_Reponse.Name = "TextB_Reponse";
            this.TextB_Reponse.Size = new System.Drawing.Size(125, 30);
            this.TextB_Reponse.TabIndex = 21;
            this.TextB_Reponse.Visible = false;
            // 
            // Lbl_Egal
            // 
            this.Lbl_Egal.AutoSize = true;
            this.Lbl_Egal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Egal.Location = new System.Drawing.Point(578, 335);
            this.Lbl_Egal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Egal.Name = "Lbl_Egal";
            this.Lbl_Egal.Size = new System.Drawing.Size(32, 32);
            this.Lbl_Egal.TabIndex = 20;
            this.Lbl_Egal.Text = "=";
            this.Lbl_Egal.Visible = false;
            // 
            // Lbl_Consigne_div
            // 
            this.Lbl_Consigne_div.AutoSize = true;
            this.Lbl_Consigne_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Consigne_div.Location = new System.Drawing.Point(89, 197);
            this.Lbl_Consigne_div.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Consigne_div.Name = "Lbl_Consigne_div";
            this.Lbl_Consigne_div.Size = new System.Drawing.Size(1020, 25);
            this.Lbl_Consigne_div.TabIndex = 19;
            this.Lbl_Consigne_div.Text = "Si le résultat n\'est pas un nombre entier, donnez le résultat entier arrondi au p" +
    "lus proche (ex: 37 ÷ 9 = 4;  98 ÷ 4 = 25)";
            this.Lbl_Consigne_div.Visible = false;
            // 
            // Btn_Division
            // 
            this.Btn_Division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Btn_Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Division.Location = new System.Drawing.Point(797, 107);
            this.Btn_Division.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Division.Name = "Btn_Division";
            this.Btn_Division.Size = new System.Drawing.Size(146, 59);
            this.Btn_Division.TabIndex = 18;
            this.Btn_Division.Text = "Division";
            this.Btn_Division.UseVisualStyleBackColor = true;
            this.Btn_Division.Click += new System.EventHandler(this.Btn_Division_Click);
            // 
            // Btn_Multiplication
            // 
            this.Btn_Multiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Btn_Multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Multiplication.Location = new System.Drawing.Point(598, 107);
            this.Btn_Multiplication.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Multiplication.Name = "Btn_Multiplication";
            this.Btn_Multiplication.Size = new System.Drawing.Size(146, 59);
            this.Btn_Multiplication.TabIndex = 17;
            this.Btn_Multiplication.Text = "Multiplication";
            this.Btn_Multiplication.UseVisualStyleBackColor = true;
            this.Btn_Multiplication.Click += new System.EventHandler(this.Btn_Multiplication_Click);
            // 
            // Btn_Soustraction
            // 
            this.Btn_Soustraction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Btn_Soustraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Soustraction.Location = new System.Drawing.Point(404, 107);
            this.Btn_Soustraction.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Soustraction.Name = "Btn_Soustraction";
            this.Btn_Soustraction.Size = new System.Drawing.Size(147, 59);
            this.Btn_Soustraction.TabIndex = 16;
            this.Btn_Soustraction.Text = "Soustraction";
            this.Btn_Soustraction.UseVisualStyleBackColor = true;
            this.Btn_Soustraction.Click += new System.EventHandler(this.Btn_Soustraction_Click);
            // 
            // Btn_Addition
            // 
            this.Btn_Addition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Btn_Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Addition.Location = new System.Drawing.Point(203, 107);
            this.Btn_Addition.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Addition.Name = "Btn_Addition";
            this.Btn_Addition.Size = new System.Drawing.Size(141, 59);
            this.Btn_Addition.TabIndex = 15;
            this.Btn_Addition.Text = "Addition";
            this.Btn_Addition.UseVisualStyleBackColor = true;
            this.Btn_Addition.Click += new System.EventHandler(this.Btn_Addition_Click);
            // 
            // Lbl_Choix_Calcul
            // 
            this.Lbl_Choix_Calcul.AutoSize = true;
            this.Lbl_Choix_Calcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Choix_Calcul.Location = new System.Drawing.Point(302, 23);
            this.Lbl_Choix_Calcul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Choix_Calcul.Name = "Lbl_Choix_Calcul";
            this.Lbl_Choix_Calcul.Size = new System.Drawing.Size(547, 29);
            this.Lbl_Choix_Calcul.TabIndex = 14;
            this.Lbl_Choix_Calcul.Text = "Quel type de calcul souhaitez-vous effectuer ?";
            // 
            // Timer_OpSuiv
            // 
            this.Timer_OpSuiv.Interval = 1000;
            this.Timer_OpSuiv.Tick += new System.EventHandler(this.Timer_OpSuiv_Tick);
            // 
            // Timer_Difficulte
            // 
            this.Timer_Difficulte.Interval = 1000;
            this.Timer_Difficulte.Tick += new System.EventHandler(this.Timer_Difficulte_Tick);
            // 
            // calculMental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1166, 556);
            this.Controls.Add(this.Lbl_Calcul);
            this.Controls.Add(this.Lbl_Info_Rep);
            this.Controls.Add(this.Btn_Validation);
            this.Controls.Add(this.TextB_Reponse);
            this.Controls.Add(this.Lbl_Egal);
            this.Controls.Add(this.Lbl_Consigne_div);
            this.Controls.Add(this.Btn_Division);
            this.Controls.Add(this.Btn_Multiplication);
            this.Controls.Add(this.Btn_Soustraction);
            this.Controls.Add(this.Btn_Addition);
            this.Controls.Add(this.Lbl_Choix_Calcul);
            this.Name = "calculMental";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.calculMental_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Calcul;
        private System.Windows.Forms.Label Lbl_Info_Rep;
        private System.Windows.Forms.Button Btn_Validation;
        private System.Windows.Forms.TextBox TextB_Reponse;
        private System.Windows.Forms.Label Lbl_Egal;
        private System.Windows.Forms.Label Lbl_Consigne_div;
        private System.Windows.Forms.Button Btn_Division;
        private System.Windows.Forms.Button Btn_Multiplication;
        private System.Windows.Forms.Button Btn_Soustraction;
        private System.Windows.Forms.Button Btn_Addition;
        private System.Windows.Forms.Label Lbl_Choix_Calcul;
        private System.Windows.Forms.Timer Timer_OpSuiv;
        private System.Windows.Forms.Timer Timer_Difficulte;
    }
}


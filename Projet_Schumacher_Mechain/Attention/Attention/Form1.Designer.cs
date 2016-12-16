namespace Attention
{
    partial class Attention
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attention));
            this.Forme = new System.Windows.Forms.PictureBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Lbl_Consigne = new System.Windows.Forms.Label();
            this.Btn_Validation = new System.Windows.Forms.Button();
            this.Btn_Depart = new System.Windows.Forms.Button();
            this.Lbl_Validation = new System.Windows.Forms.Label();
            this.Timer_FormeSuiv = new System.Windows.Forms.Timer(this.components);
            this.Timer_Difficile = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Forme)).BeginInit();
            this.SuspendLayout();
            // 
            // Forme
            // 
            this.Forme.Location = new System.Drawing.Point(323, 324);
            this.Forme.Margin = new System.Windows.Forms.Padding(4);
            this.Forme.Name = "Forme";
            this.Forme.Size = new System.Drawing.Size(457, 232);
            this.Forme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Forme.TabIndex = 0;
            this.Forme.TabStop = false;
            this.Forme.Visible = false;
            // 
            // Btn1
            // 
            this.Btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(856, 324);
            this.Btn1.Margin = new System.Windows.Forms.Padding(4);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(125, 43);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "Bouton 1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Visible = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(856, 421);
            this.Btn2.Margin = new System.Windows.Forms.Padding(4);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(125, 42);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "Bouton 2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Visible = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(856, 514);
            this.Btn3.Margin = new System.Windows.Forms.Padding(4);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(125, 42);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "Bouton 3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Visible = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Lbl_Consigne
            // 
            this.Lbl_Consigne.AutoSize = true;
            this.Lbl_Consigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Consigne.Location = new System.Drawing.Point(72, 25);
            this.Lbl_Consigne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Consigne.Name = "Lbl_Consigne";
            this.Lbl_Consigne.Size = new System.Drawing.Size(1049, 150);
            this.Lbl_Consigne.TabIndex = 4;
            this.Lbl_Consigne.Text = resources.GetString("Lbl_Consigne.Text");
            this.Lbl_Consigne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Consigne.Click += new System.EventHandler(this.Lbl_Consigne_Click);
            // 
            // Btn_Validation
            // 
            this.Btn_Validation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Btn_Validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Validation.Location = new System.Drawing.Point(386, 231);
            this.Btn_Validation.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Validation.Name = "Btn_Validation";
            this.Btn_Validation.Size = new System.Drawing.Size(100, 39);
            this.Btn_Validation.TabIndex = 5;
            this.Btn_Validation.Text = "OK";
            this.Btn_Validation.UseVisualStyleBackColor = true;
            this.Btn_Validation.Click += new System.EventHandler(this.Btn_Validation_Click);
            // 
            // Btn_Depart
            // 
            this.Btn_Depart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Btn_Depart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Depart.Location = new System.Drawing.Point(626, 231);
            this.Btn_Depart.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Depart.Name = "Btn_Depart";
            this.Btn_Depart.Size = new System.Drawing.Size(100, 39);
            this.Btn_Depart.TabIndex = 6;
            this.Btn_Depart.Text = "Prêt";
            this.Btn_Depart.UseVisualStyleBackColor = true;
            this.Btn_Depart.Visible = false;
            this.Btn_Depart.Click += new System.EventHandler(this.Btn_Depart_Click);
            // 
            // Lbl_Validation
            // 
            this.Lbl_Validation.AutoSize = true;
            this.Lbl_Validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Validation.Location = new System.Drawing.Point(329, 421);
            this.Lbl_Validation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Validation.Name = "Lbl_Validation";
            this.Lbl_Validation.Size = new System.Drawing.Size(70, 25);
            this.Lbl_Validation.TabIndex = 7;
            this.Lbl_Validation.Text = "label1";
            this.Lbl_Validation.Visible = false;
            // 
            // Timer_FormeSuiv
            // 
            this.Timer_FormeSuiv.Interval = 1000;
            this.Timer_FormeSuiv.Tick += new System.EventHandler(this.Timer_FormeSuiv_Tick);
            // 
            // Timer_Difficile
            // 
            this.Timer_Difficile.Interval = 1000;
            this.Timer_Difficile.Tick += new System.EventHandler(this.Timer_Difficile_Tick);
            // 
            // Attention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1252, 640);
            this.Controls.Add(this.Lbl_Validation);
            this.Controls.Add(this.Btn_Depart);
            this.Controls.Add(this.Btn_Validation);
            this.Controls.Add(this.Lbl_Consigne);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Forme);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Attention";
            this.Text = "Attention et Concentration";
            ((System.ComponentModel.ISupportInitialize)(this.Forme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Forme;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Label Lbl_Consigne;
        private System.Windows.Forms.Button Btn_Validation;
        private System.Windows.Forms.Button Btn_Depart;
        private System.Windows.Forms.Label Lbl_Validation;
        private System.Windows.Forms.Timer Timer_FormeSuiv;
        private System.Windows.Forms.Timer Timer_Difficile;
    }
}



namespace Memory_Game
{
    partial class UserControlMenuAccueil
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitreAccueil = new System.Windows.Forms.Label();
            this.pictureBoxTitreAccueil = new System.Windows.Forms.PictureBox();
            this.pictureBoxImageAccueil = new System.Windows.Forms.PictureBox();
            this.buttonReprendrePartie = new System.Windows.Forms.Button();
            this.labelJoueur2 = new System.Windows.Forms.Label();
            this.textBoxJoueur2 = new System.Windows.Forms.TextBox();
            this.labelJoueur1 = new System.Windows.Forms.Label();
            this.textBoxJoueur1 = new System.Windows.Forms.TextBox();
            this.buttonCommencer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonNouvellePartie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitreAccueil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageAccueil)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitreAccueil
            // 
            this.labelTitreAccueil.AutoSize = true;
            this.labelTitreAccueil.Font = new System.Drawing.Font("Abduction2002", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreAccueil.ForeColor = System.Drawing.Color.Orange;
            this.labelTitreAccueil.Location = new System.Drawing.Point(279, 459);
            this.labelTitreAccueil.Name = "labelTitreAccueil";
            this.labelTitreAccueil.Size = new System.Drawing.Size(134, 19);
            this.labelTitreAccueil.TabIndex = 127;
            this.labelTitreAccueil.Text = "Memory Game";
            // 
            // pictureBoxTitreAccueil
            // 
            this.pictureBoxTitreAccueil.Image = global::Memory_Game.Properties.Resources.random1;
            this.pictureBoxTitreAccueil.Location = new System.Drawing.Point(172, 352);
            this.pictureBoxTitreAccueil.Name = "pictureBoxTitreAccueil";
            this.pictureBoxTitreAccueil.Size = new System.Drawing.Size(259, 104);
            this.pictureBoxTitreAccueil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitreAccueil.TabIndex = 126;
            this.pictureBoxTitreAccueil.TabStop = false;
            // 
            // pictureBoxImageAccueil
            // 
            this.pictureBoxImageAccueil.Image = global::Memory_Game.Properties.Resources.Accueil1;
            this.pictureBoxImageAccueil.Location = new System.Drawing.Point(75, 15);
            this.pictureBoxImageAccueil.Name = "pictureBoxImageAccueil";
            this.pictureBoxImageAccueil.Size = new System.Drawing.Size(454, 343);
            this.pictureBoxImageAccueil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageAccueil.TabIndex = 125;
            this.pictureBoxImageAccueil.TabStop = false;
            // 
            // buttonReprendrePartie
            // 
            this.buttonReprendrePartie.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonReprendrePartie.FlatAppearance.BorderSize = 0;
            this.buttonReprendrePartie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReprendrePartie.Font = new System.Drawing.Font("Abduction2002", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReprendrePartie.ForeColor = System.Drawing.Color.Black;
            this.buttonReprendrePartie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReprendrePartie.Location = new System.Drawing.Point(160, 534);
            this.buttonReprendrePartie.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReprendrePartie.Name = "buttonReprendrePartie";
            this.buttonReprendrePartie.Size = new System.Drawing.Size(284, 32);
            this.buttonReprendrePartie.TabIndex = 123;
            this.buttonReprendrePartie.Text = "Reprendre la sauvegarde";
            this.buttonReprendrePartie.UseVisualStyleBackColor = false;
            this.buttonReprendrePartie.Click += new System.EventHandler(this.buttonReprendrePartie_Click);
            // 
            // labelJoueur2
            // 
            this.labelJoueur2.AutoSize = true;
            this.labelJoueur2.Font = new System.Drawing.Font("Abduction2002", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoueur2.ForeColor = System.Drawing.Color.Orange;
            this.labelJoueur2.Location = new System.Drawing.Point(158, 555);
            this.labelJoueur2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJoueur2.Name = "labelJoueur2";
            this.labelJoueur2.Size = new System.Drawing.Size(112, 13);
            this.labelJoueur2.TabIndex = 122;
            this.labelJoueur2.Text = "Pseudo Joueur 2";
            // 
            // textBoxJoueur2
            // 
            this.textBoxJoueur2.BackColor = System.Drawing.Color.Black;
            this.textBoxJoueur2.Font = new System.Drawing.Font("Abduction2002", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJoueur2.ForeColor = System.Drawing.Color.White;
            this.textBoxJoueur2.Location = new System.Drawing.Point(161, 570);
            this.textBoxJoueur2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJoueur2.Name = "textBoxJoueur2";
            this.textBoxJoueur2.Size = new System.Drawing.Size(283, 22);
            this.textBoxJoueur2.TabIndex = 121;
            this.textBoxJoueur2.Text = "Joueur2";
            // 
            // labelJoueur1
            // 
            this.labelJoueur1.AutoSize = true;
            this.labelJoueur1.Font = new System.Drawing.Font("Abduction2002", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoueur1.ForeColor = System.Drawing.Color.Orange;
            this.labelJoueur1.Location = new System.Drawing.Point(158, 504);
            this.labelJoueur1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJoueur1.Name = "labelJoueur1";
            this.labelJoueur1.Size = new System.Drawing.Size(110, 13);
            this.labelJoueur1.TabIndex = 120;
            this.labelJoueur1.Text = "Pseudo Joueur 1";
            // 
            // textBoxJoueur1
            // 
            this.textBoxJoueur1.BackColor = System.Drawing.Color.Black;
            this.textBoxJoueur1.Font = new System.Drawing.Font("Abduction2002", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJoueur1.ForeColor = System.Drawing.Color.White;
            this.textBoxJoueur1.Location = new System.Drawing.Point(160, 519);
            this.textBoxJoueur1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJoueur1.Name = "textBoxJoueur1";
            this.textBoxJoueur1.Size = new System.Drawing.Size(284, 22);
            this.textBoxJoueur1.TabIndex = 119;
            this.textBoxJoueur1.Text = "Joueur1";
            // 
            // buttonCommencer
            // 
            this.buttonCommencer.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonCommencer.FlatAppearance.BorderSize = 0;
            this.buttonCommencer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCommencer.Font = new System.Drawing.Font("Abduction2002", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCommencer.ForeColor = System.Drawing.Color.Black;
            this.buttonCommencer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCommencer.Location = new System.Drawing.Point(161, 635);
            this.buttonCommencer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCommencer.Name = "buttonCommencer";
            this.buttonCommencer.Size = new System.Drawing.Size(284, 32);
            this.buttonCommencer.TabIndex = 113;
            this.buttonCommencer.Text = "Commencer";
            this.buttonCommencer.UseVisualStyleBackColor = false;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonAnnuler.FlatAppearance.BorderSize = 0;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Abduction2002", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.Color.Black;
            this.buttonAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnnuler.Location = new System.Drawing.Point(161, 671);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(284, 32);
            this.buttonAnnuler.TabIndex = 128;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            // 
            // buttonNouvellePartie
            // 
            this.buttonNouvellePartie.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonNouvellePartie.FlatAppearance.BorderSize = 0;
            this.buttonNouvellePartie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNouvellePartie.Font = new System.Drawing.Font("Abduction2002", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNouvellePartie.ForeColor = System.Drawing.Color.Black;
            this.buttonNouvellePartie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNouvellePartie.Location = new System.Drawing.Point(160, 570);
            this.buttonNouvellePartie.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNouvellePartie.Name = "buttonNouvellePartie";
            this.buttonNouvellePartie.Size = new System.Drawing.Size(284, 32);
            this.buttonNouvellePartie.TabIndex = 129;
            this.buttonNouvellePartie.Text = "Nouvelle partie";
            this.buttonNouvellePartie.UseVisualStyleBackColor = false;
            // 
            // UserControlMenuAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.buttonNouvellePartie);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonCommencer);
            this.Controls.Add(this.labelTitreAccueil);
            this.Controls.Add(this.pictureBoxTitreAccueil);
            this.Controls.Add(this.pictureBoxImageAccueil);
            this.Controls.Add(this.buttonReprendrePartie);
            this.Controls.Add(this.labelJoueur2);
            this.Controls.Add(this.textBoxJoueur2);
            this.Controls.Add(this.labelJoueur1);
            this.Controls.Add(this.textBoxJoueur1);
            this.Name = "UserControlMenuAccueil";
            this.Size = new System.Drawing.Size(606, 790);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitreAccueil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageAccueil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitreAccueil;
        private System.Windows.Forms.PictureBox pictureBoxTitreAccueil;
        private System.Windows.Forms.PictureBox pictureBoxImageAccueil;
        private System.Windows.Forms.Button buttonReprendrePartie;
        private System.Windows.Forms.Label labelJoueur2;
        private System.Windows.Forms.TextBox textBoxJoueur2;
        private System.Windows.Forms.Label labelJoueur1;
        private System.Windows.Forms.TextBox textBoxJoueur1;
        private System.Windows.Forms.Button buttonCommencer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonNouvellePartie;
    }
}

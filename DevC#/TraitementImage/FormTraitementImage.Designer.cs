namespace traitementImage2
{
    partial class FormTraitementImage
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
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.imageOrigine = new System.Windows.Forms.PictureBox();
            this.imageRetouche = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            this.noir = new System.Windows.Forms.Button();
            this.noRed = new System.Windows.Forms.Button();
            this.noBlue = new System.Windows.Forms.Button();
            this.noGreen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grey = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.binarisation = new System.Windows.Forms.Button();
            this.nvScrollBar = new System.Windows.Forms.Label();
            this.negative = new System.Windows.Forms.Button();
            this.flou = new System.Windows.Forms.Button();
            this.LumUp = new System.Windows.Forms.Button();
            this.contrasteUp = new System.Windows.Forms.Button();
            this.hScrollBarContraste = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hScrollBarLum = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageOrigine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageRetouche)).BeginInit();
            this.SuspendLayout();
            // 
            // textFilePath
            // 
            this.textFilePath.Location = new System.Drawing.Point(50, 21);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(155, 20);
            this.textFilePath.TabIndex = 0;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(129, 48);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Ouvrir";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click_1);
            // 
            // imageOrigine
            // 
            this.imageOrigine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageOrigine.Location = new System.Drawing.Point(50, 260);
            this.imageOrigine.Name = "imageOrigine";
            this.imageOrigine.Size = new System.Drawing.Size(309, 178);
            this.imageOrigine.TabIndex = 2;
            this.imageOrigine.TabStop = false;
            // 
            // imageRetouche
            // 
            this.imageRetouche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageRetouche.Location = new System.Drawing.Point(442, 260);
            this.imageRetouche.Name = "imageRetouche";
            this.imageRetouche.Size = new System.Drawing.Size(309, 178);
            this.imageRetouche.TabIndex = 3;
            this.imageRetouche.TabStop = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(129, 78);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // noir
            // 
            this.noir.Location = new System.Drawing.Point(662, 4);
            this.noir.Name = "noir";
            this.noir.Size = new System.Drawing.Size(99, 23);
            this.noir.TabIndex = 5;
            this.noir.Text = "Tout Noir";
            this.noir.UseVisualStyleBackColor = true;
            this.noir.Click += new System.EventHandler(this.noir_Click);
            // 
            // noRed
            // 
            this.noRed.Location = new System.Drawing.Point(662, 33);
            this.noRed.Name = "noRed";
            this.noRed.Size = new System.Drawing.Size(98, 23);
            this.noRed.TabIndex = 6;
            this.noRed.Text = "Sans Rouge";
            this.noRed.UseVisualStyleBackColor = true;
            this.noRed.Click += new System.EventHandler(this.noRed_Click);
            // 
            // noBlue
            // 
            this.noBlue.Location = new System.Drawing.Point(662, 62);
            this.noBlue.Name = "noBlue";
            this.noBlue.Size = new System.Drawing.Size(98, 23);
            this.noBlue.TabIndex = 7;
            this.noBlue.Text = "Sans Bleu";
            this.noBlue.UseVisualStyleBackColor = true;
            this.noBlue.Click += new System.EventHandler(this.noBlue_Click);
            // 
            // noGreen
            // 
            this.noGreen.Location = new System.Drawing.Point(662, 92);
            this.noGreen.Name = "noGreen";
            this.noGreen.Size = new System.Drawing.Size(97, 23);
            this.noGreen.TabIndex = 8;
            this.noGreen.Text = "Sans Vert";
            this.noGreen.UseVisualStyleBackColor = true;
            this.noGreen.Click += new System.EventHandler(this.noGreen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Image Originale : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Image Retouché :";
            // 
            // grey
            // 
            this.grey.Location = new System.Drawing.Point(662, 122);
            this.grey.Name = "grey";
            this.grey.Size = new System.Drawing.Size(96, 23);
            this.grey.TabIndex = 11;
            this.grey.Text = "Noir et Blanc";
            this.grey.UseVisualStyleBackColor = true;
            this.grey.Click += new System.EventHandler(this.grey_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(442, 175);
            this.hScrollBar1.Maximum = 255;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(272, 19);
            this.hScrollBar1.TabIndex = 12;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // binarisation
            // 
            this.binarisation.Location = new System.Drawing.Point(364, 171);
            this.binarisation.Name = "binarisation";
            this.binarisation.Size = new System.Drawing.Size(75, 23);
            this.binarisation.TabIndex = 13;
            this.binarisation.Text = "Binarisation";
            this.binarisation.UseVisualStyleBackColor = true;
            this.binarisation.Click += new System.EventHandler(this.binarisation_Click);
            // 
            // nvScrollBar
            // 
            this.nvScrollBar.AutoSize = true;
            this.nvScrollBar.Location = new System.Drawing.Point(717, 205);
            this.nvScrollBar.MaximumSize = new System.Drawing.Size(30, 20);
            this.nvScrollBar.MinimumSize = new System.Drawing.Size(30, 20);
            this.nvScrollBar.Name = "nvScrollBar";
            this.nvScrollBar.Size = new System.Drawing.Size(30, 20);
            this.nvScrollBar.TabIndex = 14;
            // 
            // negative
            // 
            this.negative.Location = new System.Drawing.Point(364, 33);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(75, 23);
            this.negative.TabIndex = 15;
            this.negative.Text = "Negatif";
            this.negative.UseVisualStyleBackColor = true;
            this.negative.Click += new System.EventHandler(this.negative_Click);
            // 
            // flou
            // 
            this.flou.Location = new System.Drawing.Point(364, 92);
            this.flou.Name = "flou";
            this.flou.Size = new System.Drawing.Size(75, 23);
            this.flou.TabIndex = 16;
            this.flou.Text = "Floutage";
            this.flou.UseVisualStyleBackColor = true;
            this.flou.Click += new System.EventHandler(this.flou_Click);
            // 
            // LumUp
            // 
            this.LumUp.Location = new System.Drawing.Point(364, 142);
            this.LumUp.Name = "LumUp";
            this.LumUp.Size = new System.Drawing.Size(75, 23);
            this.LumUp.TabIndex = 17;
            this.LumUp.Text = "Luminosité";
            this.LumUp.UseVisualStyleBackColor = true;
            this.LumUp.Click += new System.EventHandler(this.LumUp_Click_1);
            // 
            // contrasteUp
            // 
            this.contrasteUp.Location = new System.Drawing.Point(364, 200);
            this.contrasteUp.Name = "contrasteUp";
            this.contrasteUp.Size = new System.Drawing.Size(75, 23);
            this.contrasteUp.TabIndex = 18;
            this.contrasteUp.Text = "Contraste++";
            this.contrasteUp.UseVisualStyleBackColor = true;
            this.contrasteUp.Click += new System.EventHandler(this.contrasteUp_Click);
            // 
            // hScrollBarContraste
            // 
            this.hScrollBarContraste.LargeChange = 1;
            this.hScrollBarContraste.Location = new System.Drawing.Point(442, 205);
            this.hScrollBarContraste.Maximum = 255;
            this.hScrollBarContraste.Name = "hScrollBarContraste";
            this.hScrollBarContraste.Size = new System.Drawing.Size(272, 17);
            this.hScrollBarContraste.TabIndex = 12;
            this.hScrollBarContraste.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarContraste_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Val : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Val :";
            // 
            // hScrollBarLum
            // 
            this.hScrollBarLum.LargeChange = 1;
            this.hScrollBarLum.Location = new System.Drawing.Point(445, 148);
            this.hScrollBarLum.Maximum = 255;
            this.hScrollBarLum.Name = "hScrollBarLum";
            this.hScrollBarLum.Size = new System.Drawing.Size(269, 17);
            this.hScrollBarLum.TabIndex = 21;
            this.hScrollBarLum.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarLum_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(716, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Val : ";
            // 
            // FormTraitementImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hScrollBarLum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hScrollBarContraste);
            this.Controls.Add(this.contrasteUp);
            this.Controls.Add(this.LumUp);
            this.Controls.Add(this.flou);
            this.Controls.Add(this.negative);
            this.Controls.Add(this.nvScrollBar);
            this.Controls.Add(this.binarisation);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.grey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noGreen);
            this.Controls.Add(this.noBlue);
            this.Controls.Add(this.noRed);
            this.Controls.Add(this.noir);
            this.Controls.Add(this.save);
            this.Controls.Add(this.imageRetouche);
            this.Controls.Add(this.imageOrigine);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textFilePath);
            this.Name = "FormTraitementImage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageOrigine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageRetouche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFilePath;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.PictureBox imageOrigine;
        private System.Windows.Forms.PictureBox imageRetouche;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button noir;
        private System.Windows.Forms.Button noRed;
        private System.Windows.Forms.Button noBlue;
        private System.Windows.Forms.Button noGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button grey;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button binarisation;
        private System.Windows.Forms.Label nvScrollBar;
        private System.Windows.Forms.Button negative;
        private System.Windows.Forms.Button flou;
        private System.Windows.Forms.Button LumUp;
        private System.Windows.Forms.Button contrasteUp;
        private System.Windows.Forms.HScrollBar hScrollBarContraste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar hScrollBarLum;
        private System.Windows.Forms.Label label5;
    }
}


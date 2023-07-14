namespace Form1
{
    partial class MasterMind
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
            this.btModifColorOk = new System.Windows.Forms.Button();
            this.BloquerColor = new System.Windows.Forms.Button();
            this.btafficher = new System.Windows.Forms.Button();
            this.numUDBlack = new System.Windows.Forms.NumericUpDown();
            this.numUDWhite = new System.Windows.Forms.NumericUpDown();
            this.RendreJouableRang = new System.Windows.Forms.Button();
            this.desactiverRang = new System.Windows.Forms.Button();
            this.affSecret = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWhite)).BeginInit();
            this.SuspendLayout();
            // 
            // btModifColorOk
            // 
            this.btModifColorOk.Location = new System.Drawing.Point(634, 61);
            this.btModifColorOk.Name = "btModifColorOk";
            this.btModifColorOk.Size = new System.Drawing.Size(75, 23);
            this.btModifColorOk.TabIndex = 0;
            this.btModifColorOk.Text = "Modif Color";
            this.btModifColorOk.UseVisualStyleBackColor = true;
            this.btModifColorOk.Click += new System.EventHandler(this.btModifColorOk_Click);
            // 
            // BloquerColor
            // 
            this.BloquerColor.Location = new System.Drawing.Point(634, 120);
            this.BloquerColor.Name = "BloquerColor";
            this.BloquerColor.Size = new System.Drawing.Size(75, 23);
            this.BloquerColor.TabIndex = 1;
            this.BloquerColor.Text = "Bloquer Color";
            this.BloquerColor.UseVisualStyleBackColor = true;
            this.BloquerColor.Click += new System.EventHandler(this.BloquerColor_Click);
            // 
            // btafficher
            // 
            this.btafficher.Location = new System.Drawing.Point(634, 263);
            this.btafficher.Name = "btafficher";
            this.btafficher.Size = new System.Drawing.Size(75, 23);
            this.btafficher.TabIndex = 2;
            this.btafficher.Text = "afficher";
            this.btafficher.UseVisualStyleBackColor = true;
            this.btafficher.Click += new System.EventHandler(this.btafficher_Click);
            // 
            // numUDBlack
            // 
            this.numUDBlack.Location = new System.Drawing.Point(588, 293);
            this.numUDBlack.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUDBlack.Name = "numUDBlack";
            this.numUDBlack.Size = new System.Drawing.Size(120, 20);
            this.numUDBlack.TabIndex = 3;
            // 
            // numUDWhite
            // 
            this.numUDWhite.Location = new System.Drawing.Point(587, 320);
            this.numUDWhite.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUDWhite.Name = "numUDWhite";
            this.numUDWhite.Size = new System.Drawing.Size(120, 20);
            this.numUDWhite.TabIndex = 4;
            // 
            // RendreJouableRang
            // 
            this.RendreJouableRang.Location = new System.Drawing.Point(588, 447);
            this.RendreJouableRang.Name = "RendreJouableRang";
            this.RendreJouableRang.Size = new System.Drawing.Size(123, 23);
            this.RendreJouableRang.TabIndex = 5;
            this.RendreJouableRang.Text = "Rendre Jouable Rang";
            this.RendreJouableRang.UseVisualStyleBackColor = true;
            this.RendreJouableRang.Click += new System.EventHandler(this.RendreJouableRang_Click);
            // 
            // desactiverRang
            // 
            this.desactiverRang.Location = new System.Drawing.Point(588, 477);
            this.desactiverRang.Name = "desactiverRang";
            this.desactiverRang.Size = new System.Drawing.Size(123, 23);
            this.desactiverRang.TabIndex = 6;
            this.desactiverRang.Text = "DesactiverRang";
            this.desactiverRang.UseVisualStyleBackColor = true;
            this.desactiverRang.Click += new System.EventHandler(this.desactiverRang_Click);
            // 
            // affSecret
            // 
            this.affSecret.Location = new System.Drawing.Point(664, 163);
            this.affSecret.Name = "affSecret";
            this.affSecret.Size = new System.Drawing.Size(75, 23);
            this.affSecret.TabIndex = 7;
            this.affSecret.Text = "affiche secret";
            this.affSecret.UseVisualStyleBackColor = true;
            this.affSecret.Click += new System.EventHandler(this.affSecret_Click);
            // 
            // MasterMind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 668);
            this.Controls.Add(this.affSecret);
            this.Controls.Add(this.desactiverRang);
            this.Controls.Add(this.RendreJouableRang);
            this.Controls.Add(this.numUDWhite);
            this.Controls.Add(this.numUDBlack);
            this.Controls.Add(this.btafficher);
            this.Controls.Add(this.BloquerColor);
            this.Controls.Add(this.btModifColorOk);
            this.Name = "MasterMind";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUDBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWhite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btModifColorOk;
        private System.Windows.Forms.Button BloquerColor;
        private System.Windows.Forms.Button btafficher;
        private System.Windows.Forms.NumericUpDown numUDBlack;
        private System.Windows.Forms.NumericUpDown numUDWhite;
        private System.Windows.Forms.Button RendreJouableRang;
        private System.Windows.Forms.Button desactiverRang;
        private System.Windows.Forms.Button affSecret;
    }
}


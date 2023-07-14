namespace DémineurPro
{
    partial class FormDemineurPro
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
            this.button1 = new System.Windows.Forms.Button();
            this.Relancer = new System.Windows.Forms.Button();
            this.compteur = new System.Windows.Forms.Label();
            this.nombreMines = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nombreMines)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "triche";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Relancer
            // 
            this.Relancer.Location = new System.Drawing.Point(533, 12);
            this.Relancer.Name = "Relancer";
            this.Relancer.Size = new System.Drawing.Size(89, 27);
            this.Relancer.TabIndex = 1;
            this.Relancer.Text = "Relancer";
            this.Relancer.UseVisualStyleBackColor = true;
            this.Relancer.Click += new System.EventHandler(this.Relancer_Click);
            // 
            // compteur
            // 
            this.compteur.AutoSize = true;
            this.compteur.Location = new System.Drawing.Point(445, 120);
            this.compteur.MaximumSize = new System.Drawing.Size(500, 50);
            this.compteur.MinimumSize = new System.Drawing.Size(100, 10);
            this.compteur.Name = "compteur";
            this.compteur.Size = new System.Drawing.Size(100, 13);
            this.compteur.TabIndex = 2;
            // 
            // nombreMines
            // 
            this.nombreMines.Location = new System.Drawing.Point(537, 45);
            this.nombreMines.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nombreMines.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nombreMines.Name = "nombreMines";
            this.nombreMines.Size = new System.Drawing.Size(45, 20);
            this.nombreMines.TabIndex = 3;
            this.nombreMines.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Relancer avec : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "mines";
            // 
            // FormDemineurPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreMines);
            this.Controls.Add(this.compteur);
            this.Controls.Add(this.Relancer);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(650, 490);
            this.MinimumSize = new System.Drawing.Size(650, 490);
            this.Name = "FormDemineurPro";
            this.Text = "DemineurPro";
            ((System.ComponentModel.ISupportInitialize)(this.nombreMines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Relancer;
        private System.Windows.Forms.Label compteur;
        private System.Windows.Forms.NumericUpDown nombreMines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


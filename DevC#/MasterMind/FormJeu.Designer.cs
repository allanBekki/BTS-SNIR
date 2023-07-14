namespace Form1
{
    partial class FormJeu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btDemarrer = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.btDecouvrir = new System.Windows.Forms.Button();
            this.labelVictoire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDemarrer
            // 
            this.btDemarrer.Location = new System.Drawing.Point(622, 564);
            this.btDemarrer.Name = "btDemarrer";
            this.btDemarrer.Size = new System.Drawing.Size(100, 35);
            this.btDemarrer.TabIndex = 0;
            this.btDemarrer.Text = "Demarrer";
            this.btDemarrer.UseVisualStyleBackColor = true;
            this.btDemarrer.Click += new System.EventHandler(this.btDemarrer_Click);
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(320, 505);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(56, 30);
            this.btValider.TabIndex = 1;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btDecouvrir
            // 
            this.btDecouvrir.Location = new System.Drawing.Point(638, 48);
            this.btDecouvrir.Name = "btDecouvrir";
            this.btDecouvrir.Size = new System.Drawing.Size(84, 36);
            this.btDecouvrir.TabIndex = 2;
            this.btDecouvrir.Text = "Decouvrir";
            this.btDecouvrir.UseVisualStyleBackColor = true;
            this.btDecouvrir.Click += new System.EventHandler(this.btDecouvrir_Click);
            // 
            // labelVictoire
            // 
            this.labelVictoire.AutoSize = true;
            this.labelVictoire.Location = new System.Drawing.Point(463, 245);
            this.labelVictoire.Name = "labelVictoire";
            this.labelVictoire.Size = new System.Drawing.Size(0, 13);
            this.labelVictoire.TabIndex = 3;
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.labelVictoire);
            this.Controls.Add(this.btDecouvrir);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.btDemarrer);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "FormJeu";
            this.Text = "FormJeu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDemarrer;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btDecouvrir;
        private System.Windows.Forms.Label labelVictoire;
    }
}
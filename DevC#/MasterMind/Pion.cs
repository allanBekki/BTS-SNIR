using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    internal class Pion : Button
    {
        
        //ATTRIBUT

        public bool modifable = false;

        private Color[] couleur;
        private int numCouleur = 0;

        public Pion()
        {
            //this.SetBounds(x, y, 20, 20);
            this.Enabled = false;

            //Initialisation des couleurs
            couleur = new Color[8];
            couleur[0] = Color.White;
            couleur[1] = Color.Red;
            couleur[2] = Color.Blue;
            couleur[3] = Color.Green;
            couleur[4] = Color.Yellow;
            couleur[5] = Color.Pink;
            couleur[6] = Color.Purple;
            couleur[7] = Color.Orange;
            this.Click += this.onPionClick;
        }






        //FONCTIONS

        public Pion(int x, int y)
        {
            this.SetBounds(x, y, 40, 40);
            this.Click += this.onPionClick;

            //Boutton non actif
            this.Enabled = false;

            //Initialisation des couleurs
            couleur = new Color[8];
            couleur[0] = Color.White;
            couleur[1] = Color.Red;
            couleur[2] = Color.Blue;
            couleur[3] = Color.Green;
            couleur[4] = Color.Yellow;
            couleur[5] = Color.Pink;
            couleur[6] = Color.Purple;
            couleur[7] = Color.Orange;
        }

        public void autoriserModifCouleur()
        {
            if(modifable == false)
            {
                this.Enabled = true;
                modifable = true;
                this.BackColor = couleur[numCouleur];
            }
           
        }

        public void bloquerCouleur()
        {
            if (modifable == true)
            {
                this.Enabled = false;
                modifable = false;
            }


        }

        private void onPionClick(object sender, EventArgs e)
        {
            numCouleur++;
            if (numCouleur >= 8)
            {
                numCouleur = 0;
                BackColor = couleur[numCouleur];
            }
            else                          
                BackColor = couleur[numCouleur];               
            
                
            
            
        }

        public int getNumCouleur()
        {
            return numCouleur;
        }
       

        public void setNumCouleur(int color)
        {
            numCouleur = color;
        }
    }
}

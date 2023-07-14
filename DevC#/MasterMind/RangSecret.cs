using MasterMind;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    internal class RangSecret : Rang
    {
        //ATTRIBUTS
        private Random r;
        

        //METHODES

        public RangSecret(int x, int y)
        {
            r = new Random();

            this.Location = new Point(x, y);            //donne la localisation
            this.Size = new Size(163, 42);                 //donne la taille
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            genererSecret();


        }

        public void genererSecret()
        {
            for(int i = 0; i<4; i++)
            {
                int couleur = r.Next(8);
                //int couleur = 1;
                tabPion[i].setNumCouleur(couleur);
            }
        }

        
    }
}

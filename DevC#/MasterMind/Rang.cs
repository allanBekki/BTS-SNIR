using MasterMind;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    internal class Rang : Panel
    {
        //ATTRIBUTS
        public Resultat resultat;
        public Pion[] tabPion;


        public Rang()
        {
            tabPion = new Pion[4];

            //Propriete Panel
            this.Location = new Point(100, 150);            //donne la localisation
            this.Size = new Size(200, 42);                 //donne la taille
            this.BorderStyle = BorderStyle.Fixed3D;

            //Propriété des Pions à la créations
            for (int i = 0; i <= 3; i++)
            {
                tabPion[i] = new Pion();     //instencie les pions          
            }
            tabPion[0].Location = new Point(0, 0);
            tabPion[0].Size = new Size(40,40);

            tabPion[1].Location = new Point(40, 0);
            tabPion[1].Size = new Size(40, 40);

            tabPion[2].Location = new Point(80,0);
            tabPion[2].Size = new Size(40, 40);

            tabPion[3].Location = new Point(120, 0);
            tabPion[3].Size = new Size(40, 40);

            for (int i = 0; i <= 3; i++)
            {
                this.Controls.Add(tabPion[i]);      //permet de les affichers 
            }


            //Propriete Resultat
            resultat = new Resultat();

            resultat.Location = new Point(165, 5);
            resultat.Size = new Size(40, 40);
            resultat.BorderStyle = BorderStyle.None;
            this.Controls.Add(resultat);

        }

        public Rang(int x, int y)
        {
            tabPion = new Pion[4];

            this.Location = new Point(x, y);
            this.Size = new Size(200, 42);
            this.BorderStyle = BorderStyle.Fixed3D;

            int posX = 0;
            //Propriété des Pions à la créations
            for (int i = 0; i <= 3; i++)
            {
                
                tabPion[i] = new Pion(0+posX,0);     //instencie les pions               
                posX = posX + 40;
                this.Controls.Add(tabPion[i]);      //permet de les affichers 
            }           


            //Propriete Resultat
            resultat = new Resultat();

            resultat.Location = new Point(165, 5);
            resultat.Size = new Size(40, 40);
            resultat.BorderStyle = BorderStyle.None;
            this.Controls.Add(resultat);
        }

        public void bloquerCouleurRang()
        {
            this.Enabled = false;
        }

        public int getCodeCouleurPion(int numeroPion)
        {
            int coul = 0;

            for(int i = 0; i<8; i++)
            {
                if (i == tabPion[numeroPion].getNumCouleur())
                {
                    coul = i;
                }
            }

            return coul;
        }

        public void rendreRangJouable()
        {
            for (int i = 0; i < 4; i++)
            {
                tabPion[i].autoriserModifCouleur();
                
            }
        }
    }
}

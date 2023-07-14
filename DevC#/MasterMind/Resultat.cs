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
    internal class Resultat : Panel
    {
        //ATTRIBUT
        public int nbBlancs;
        public int nbNoirs;

        Pion[] tabPion;


        //FONCTION

        public Resultat()
        {
            tabPion = new Pion[4];

            //Propriete Panel
            this.Location = new Point(100, 100);            //donne la localisation
            this.Size = new Size(33, 33);                 //donne la taille
            this.BorderStyle = BorderStyle.Fixed3D;



            //Desactiver les modifications des buttons et caracteristique           

         for( int i =0; i<4; i++)
            {
                tabPion[i] = new Pion();     //instencie les pions
            }
                
                    
                    

                
                      

            
            tabPion[0].Location = new Point(0, 0);
            tabPion[0].Size = new Size(15, 15);

            tabPion[1].Location = new Point(15, 0);
            tabPion[1].Size = new Size(15, 15);

            tabPion[2].Location = new Point(0, 15);
            tabPion[2].Size = new Size(15, 15);

            tabPion[3].Location = new Point(15, 15);
            tabPion[3].Size = new Size(15, 15);





            for (int i =0; i<=3; i++)
            {
                this.Controls.Add(tabPion[i]);      //permet de les affichers 
            }
            
        }


        public void afficher( int nbNoir, int nbBlancs)
        {
                     
               

                for(int i =0; i<nbNoir; i++)
                {
                    tabPion[i].BackColor = Color.Black;
                }

                for(int i = nbNoir; i<nbNoir+nbBlancs; i++ )
                {
                    tabPion[i].BackColor = Color.White;
                }
                for(int i = nbBlancs+nbNoir; i<4; i++)
                {
                tabPion[i].BackColor = Color.Gray;
                }



           
        }
    }
}

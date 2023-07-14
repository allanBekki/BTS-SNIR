using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DémineurPro
{
    internal class ButtonDemineur : Button    //herite de la classe button
    {
        public int line;            //numero de ligne
        public int column;         //numero de colonne
        public bool flag = false;   //drapeau qui indique la probabilité des mines
        public bool mine = false;   //MINE
        public bool AlreadyPlayed = false; //deja joué

        public ButtonDemineur(int ligne, int colonne)   //constructeur
        {
            line = ligne;
            column = colonne;
            this.SetBounds(20+line * 40, 20 +colonne * 40, 40, 40);    //taille et position
        }
        
    }
}

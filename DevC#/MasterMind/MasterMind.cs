using MasterMind;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class MasterMind : Form
    {
        Pion pionTest;
        Resultat resultTest;
        Rang[] rang;
        RangSecret secret;

        public MasterMind()
        {
            InitializeComponent();

            /*//definition du pion
            pionTest = new Pion(40,40);
            this.Controls.Add(pionTest);

            //definition des resultats
            resultTest = new Resultat();
            this.Controls.Add(resultTest);

            //definition du rang
            rang = new Rang();
            this.Controls.Add(rang);

            //definition du rang secret
            secret = new RangSecret();
            this.Controls.Add(secret);
            */


            
            //definition du rang
            rang = new Rang[10];
            int y = 0;
            for (int i = 0; i < 10; i++)
            {
                rang[i] = new Rang(50, 350 - y);
                this.Controls.Add(rang[i]);

                y = y + 50;
            }


        }

        private void btModifColorOk_Click(object sender, EventArgs e)
        {
            pionTest.autoriserModifCouleur();
        }

        private void BloquerColor_Click(object sender, EventArgs e)
        {
            pionTest.bloquerCouleur();
        }

        private void btafficher_Click(object sender, EventArgs e)
        {
            resultTest.afficher((int)numUDBlack.Value,(int)numUDWhite.Value);
        }

        private void RendreJouableRang_Click(object sender, EventArgs e)
        {
           // rang.rendreRangJouable();
            
        }

        private void desactiverRang_Click(object sender, EventArgs e)
        {
         //   rang.bloquerCouleurRang();
        }

        private void affSecret_Click(object sender, EventArgs e)
        {
            secret.rendreRangJouable();
            secret.bloquerCouleurRang();
        }
    }
}

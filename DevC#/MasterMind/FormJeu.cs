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
    public partial class FormJeu : Form
    {
        RangSecret secret;
        Rang[] rang = new Rang[10];
        int[] tabCopieSecret = new int[4];
        int[] tabCopieRang = new int[4];

        int cpt = 0;
        int y = 0;
        public FormJeu()
        {
            InitializeComponent();
            btValider.Visible = false;
            btDecouvrir.Visible = false;
        }

        private void btDemarrer_Click(object sender, EventArgs e)
        {
            
            //INITIALISATION
            //RANG
            int y = 0;
            for (int i = 0; i < 10; i++)
            {
                rang[i] = new Rang(100, 500 - y);
                this.Controls.Add(rang[i]);

                y = y + 50;
            }
            //SECRET           
            secret = new RangSecret(400,50);
            this.Controls.Add(secret);


            rang[0].rendreRangJouable();
            btValider.Visible = true;
            btDecouvrir.Visible = true;
            btValider.Location = new Point(320, 505);

            

            
            
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            


            //RESULTAT
            int nbBon = 0;
            int nbMauvais = 0;

            for (int i = 0; i < 4; i++)
            {
                tabCopieSecret[i] = secret.getCodeCouleurPion(i);
                tabCopieRang[i] = rang[cpt].getCodeCouleurPion(i);
            }

            int fin = 0;
            for (int f = 0; f < 4; f++)
            {
                if (tabCopieRang[f] == tabCopieSecret[f])
                {
                    fin++;
                    if (fin == 4)
                    {
                        rang[cpt].bloquerCouleurRang();
                        labelVictoire.Text = "VICTOIRE !!";
                    }
                }
            }



            for (int i = 0; i<4; i++)
            {
                if (tabCopieRang[i] == tabCopieSecret[i])
                {
                    nbBon++;
                    tabCopieRang[i] = -1520389420;
                    tabCopieSecret[i] = -100;
                }
                else
                {
                    for(int j=0; j<4;j++)
                    {
                        if (tabCopieSecret[i] == tabCopieRang[j])
                        {
                            nbMauvais++;
                            tabCopieRang[j] = -1520389420;
                            tabCopieSecret[i] = -100;

                        }
                    }
                }
            }


            rang[cpt].resultat.afficher(nbBon,nbMauvais);
            rang[cpt].bloquerCouleurRang();

            cpt++;
            //RANG
            rang[cpt].rendreRangJouable();
            

            //BUTTON
            if(y<450)
            {
                y = y + 50;
            }
            else
            {
                labelVictoire.Text = "DEFAITE !!!";
            }
                
            btValider.Location = new Point(320, 505 - y);

            

            
        }

        private void btDecouvrir_Click(object sender, EventArgs e)
        {
            secret.rendreRangJouable();
            secret.bloquerCouleurRang();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DémineurPro
{
    public partial class FormDemineurPro : Form
    {
        //creation des widgets & variables utile partout
        ButtonDemineur[,] tabMine;
        Label LabelMessage;
        int count =  0;


        public FormDemineurPro()
        {
            InitializeComponent();

            tabMine = new ButtonDemineur[10,10];
            //completer l'init de formDemineur

            initTabMine();
            installMine();

            //completer init du label
            LabelMessage = new Label();
            LabelMessage.SetBounds(445, 100, 400, 400);
            this.Controls.Add(LabelMessage);
        }




        private void initTabMine()
        {
            for (int i= 0; i<10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tabMine[i, j] = new ButtonDemineur(i,j);            //creer le tableau tt seul via le constructeur de la classe buttondemineur
                    tabMine[i, j].Click += this.ButtonDemineur_Click;
                    tabMine[i, j].Tag = "0";
                    this.Controls.Add(tabMine[i, j]);
                }
            }
        }





        private void installMine()
        {
            Random alea = new Random();
            int x, y;
            string tag;

            for (int i = 0; i<=nombreMines.Value; i++)
            {
                x = alea.Next(10);          //genere un nm aleatoire compris entre 0 et 9
                y = alea.Next(10);
                tag = tabMine[x, y].ToString();

                if(tag != "M")              //si le tag !=M alors il place une mine, sinon il refera un tour de boucle
                {
                    tabMine[x, y].Tag = "M";     //Tag permet de donner une valeur au bouton; ici M est une mine
                }
                else
                {
                    i--;
                }          
            }               
        }






        int CompteMines(ButtonDemineur buttonDemineur)
        {
            //agit seulement lors d'un click
            //int nbMines;
            int ligne, colonne;
            int cptMine = 0;

            if (buttonDemineur.Tag.ToString() != "M")
            {
                if (buttonDemineur.line == 0 && buttonDemineur.column == 0)         //BUTTON COIN haut-gauche
                {
                    ligne = buttonDemineur.line;                                    //recup des coordonnées du bouton
                    colonne = buttonDemineur.column;

                    if (tabMine[ligne + 1, colonne].Tag.ToString() == "M")           //case droite
                    {
                        cptMine++;
                    }

                    if (tabMine[ligne, colonne + 1].Tag.ToString() == "M")           //case en bas
                    {
                        cptMine++;
                    }

                    if (tabMine[ligne + 1, colonne + 1].Tag.ToString() == "M")           //case en bas-droit
                    {
                        cptMine++;
                    }

                }

                if (buttonDemineur.line == 0 && buttonDemineur.column == 9)         //BUTTON COIN bas-gauche
                {
                    ligne = buttonDemineur.line;                                    //recup des coordonnées du bouton
                    colonne = buttonDemineur.column;

                    if (tabMine[ligne + 1, colonne].Tag.ToString() == "M")           //case droite
                    {
                        cptMine++;
                    }

                    if (tabMine[ligne, colonne - 1].Tag.ToString() == "M")           //case en haut
                    {
                        cptMine++;
                    }

                    if (tabMine[ligne + 1, colonne - 1].Tag.ToString() == "M")           //case en haut-droit
                    {
                        cptMine++;
                    }

                }

                if (buttonDemineur.line == 9 && buttonDemineur.column == 0)         //BUTTON COIN haut-droit
                {
                    ligne = buttonDemineur.line;                                    //recup des coordonnées du bouton
                    colonne = buttonDemineur.column;

                    if (tabMine[ligne - 1, colonne].Tag.ToString() == "M")           //case gauche
                    {
                        cptMine++;
                    }

                    if (tabMine[ligne, colonne + 1].Tag.ToString() == "M")           //case en bas
                    {
                        cptMine++;
                    }

                    if (tabMine[ligne - 1, colonne + 1].Tag.ToString() == "M")           //case en bas-droit
                    {
                        cptMine++;
                    }

                }

                if (buttonDemineur.line == 9 && buttonDemineur.column == 9)         //BUTTON COIN bas-gauche
                {
                    ligne = buttonDemineur.line;                                    //recup des coordonnées du bouton
                    colonne = buttonDemineur.column;

                    if (tabMine[ligne - 1, colonne].Tag.ToString() == "M")           //case gauche
                    {
                        cptMine++;
                    }

                    if (tabMine[ligne, colonne - 1].Tag.ToString() == "M")           //case en haut
                    {
                        cptMine++;
                    }

                    if (tabMine[ligne - 1, colonne - 1].Tag.ToString() == "M")           //case en bas-droit
                    {
                        cptMine++;
                    }

                }
            }

                
                
            if(buttonDemineur.column == 0 && buttonDemineur.line != 0 && buttonDemineur.line != 9 )         //si colonne = 0 pour la ligne 1 && si ce ne sont pas le 1er ni le dernier button ( en gros 1ere ligne)
            {
                ligne = buttonDemineur.line;                                    //recup des coordonnées du bouton
                colonne = buttonDemineur.column;

                if (tabMine[ligne-1, colonne].Tag.ToString() == "M")           //case en gauche
                {
                        cptMine++;
                }

                if (tabMine[ligne +1, colonne].Tag.ToString() == "M")           //case en droite
                {
                    cptMine++;
                }

                if (tabMine[ligne , colonne+1].Tag.ToString() == "M")           //case en bas
                {
                    cptMine++;
                }

                if (tabMine[ligne-1, colonne + 1].Tag.ToString() == "M")           //case en bas-gauche
                {
                    cptMine++;
                }

                if (tabMine[ligne+1, colonne + 1].Tag.ToString() == "M")           //case en bas-droite
                {
                    cptMine++;
                }


            }

            if (buttonDemineur.column == 9 && buttonDemineur.line != 0 && buttonDemineur.line != 9)         //ligne en bas (exclu 1ere et derniere case)
            {
                ligne = buttonDemineur.line;                                    //recup des coordonnées du bouton
                colonne = buttonDemineur.column;

                if (tabMine[ligne - 1, colonne].Tag.ToString() == "M")           //case en gauche
                {
                    cptMine++;
                }

                if (tabMine[ligne + 1, colonne].Tag.ToString() == "M")           //case en droite
                {
                    cptMine++;
                }

                if (tabMine[ligne, colonne - 1].Tag.ToString() == "M")           //case en haut
                {
                    cptMine++;
                }

                if (tabMine[ligne - 1, colonne - 1].Tag.ToString() == "M")           //case en haut-gauche
                {
                    cptMine++;
                }

                if (tabMine[ligne + 1, colonne - 1].Tag.ToString() == "M")           //case en haut-droite
                {
                    cptMine++;
                }


            }

            if (buttonDemineur.line == 0 && buttonDemineur.column != 0 && buttonDemineur.column != 9)         //colonne gauche (exclu 1ere et derniere case)
            {
                ligne = buttonDemineur.line;                                    //recup des coordonnées du bouton
                colonne = buttonDemineur.column;               

                if (tabMine[ligne + 1, colonne].Tag.ToString() == "M")           //case en droite
                {
                    cptMine++;
                }

                if (tabMine[ligne, colonne - 1].Tag.ToString() == "M")           //case en haut
                {
                    cptMine++;
                }

                if (tabMine[ligne, colonne + 1].Tag.ToString() == "M")           //case en bas
                {
                    cptMine++;
                }

                if (tabMine[ligne + 1, colonne - 1].Tag.ToString() == "M")           //case en haut-droite
                {
                    cptMine++;
                }

                if (tabMine[ligne + 1, colonne + 1].Tag.ToString() == "M")           //case en bas-droite
                {
                    cptMine++;
                }


            }

            if (buttonDemineur.line == 9 && buttonDemineur.column != 0 && buttonDemineur.column != 9)         //colonne droite (exclu 1ere et derniere case)
            {
                ligne = buttonDemineur.line;                                    //recup des coordonnées du bouton
                colonne = buttonDemineur.column;

                if (tabMine[ligne - 1, colonne].Tag.ToString() == "M")           //case en gauche
                {
                    cptMine++;
                }

                if (tabMine[ligne, colonne - 1].Tag.ToString() == "M")           //case en haut
                {
                    cptMine++;
                }

                if (tabMine[ligne, colonne + 1].Tag.ToString() == "M")           //case en bas
                {
                    cptMine++;
                }

                if (tabMine[ligne - 1, colonne - 1].Tag.ToString() == "M")           //case en haut-gauche
                {
                    cptMine++;
                }

                if (tabMine[ligne - 1, colonne + 1].Tag.ToString() == "M")           //case en bas-gauche
                {
                    cptMine++;
                }


            }

            if(buttonDemineur.line > 0 && buttonDemineur. line < 9 && buttonDemineur.column > 0 && buttonDemineur.column < 9)   //cas generale
            {
                ligne = buttonDemineur.line;                                    //recup des coordonnées du bouton
                colonne = buttonDemineur.column;

                if (tabMine[ligne - 1, colonne].Tag.ToString() == "M")           //case en gauche
                {
                    cptMine++;
                }

                if (tabMine[ligne + 1, colonne].Tag.ToString() == "M")           //case en droite
                {
                    cptMine++;
                }

                if (tabMine[ligne, colonne - 1].Tag.ToString() == "M")           //case en haut
                {
                    cptMine++;
                }

                if (tabMine[ligne, colonne + 1].Tag.ToString() == "M")           //case en bas
                {
                    cptMine++;
                }

                if (tabMine[ligne - 1, colonne - 1].Tag.ToString() == "M")           //case en haut-gauche
                {
                    cptMine++;
                }

                if (tabMine[ligne + 1, colonne - 1].Tag.ToString() == "M")           //case en haut-droite
                {
                    cptMine++;
                }

                if (tabMine[ligne - 1, colonne + 1].Tag.ToString() == "M")           //case en bas-gauche
                {
                    cptMine++;
                }

                if (tabMine[ligne + 1, colonne + 1].Tag.ToString() == "M")           //case en bas-droite
                {
                    cptMine++;
                }


            }

            return cptMine;
            
        }

        private void ButtonDemineur_Click(object sender, EventArgs e)
        {
            ButtonDemineur ButtonClicked = (ButtonDemineur)sender; //sender est le button clicker        
            string tag = ButtonClicked.Tag.ToString();      //recuperation de la valeur tag en string



            if (tag == "0")
            {
                string nbmine = CompteMines(ButtonClicked).ToString();      
                ButtonClicked.Text = nbmine;
                

                if (ButtonClicked.Text == "0")
                {
                    ButtonClicked.BackColor = Color.Green;
                }

                if (ButtonClicked.Text == "1")
                {
                    ButtonClicked.BackColor = Color.LightGreen;
                }

                if (ButtonClicked.Text == "2")
                {
                    ButtonClicked.BackColor = Color.Yellow;
                }

                if (ButtonClicked.Text == "3")
                {
                    ButtonClicked.BackColor = Color.Orange;
                }

                if (ButtonClicked.Text == "4" || ButtonClicked.Text == "5")
                {
                    ButtonClicked.BackColor = Color.OrangeRed;
                }

                if ( ButtonClicked.Text == "6" || ButtonClicked.Text == "7" || ButtonClicked.Text == "8")
                {
                    ButtonClicked.BackColor = Color.IndianRed;
                }





                count += 1;            
                
                ButtonClicked.Tag = "1";                                        //pour eviter d'incrementer le compteur à nouveau sur le bouton
                LabelMessage.Text = "Il y a : " + nbmine +" mines autour de cette cases !!"  ;    
            }
            else if (tag == "M")
            {
                ButtonClicked.Text = "M";
                count += 1;
                ButtonClicked.BackColor = Color.Red;
                ButtonClicked.Tag = "1";
                LabelMessage.Text = "Perdu ! Vous êtes tombé sur une mine !!";


                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        tabMine[i, j].Enabled = false;              //desactive tt les boutons en cas de defaite

                        if (tabMine[i,j].Tag.ToString() =="M")      //afficher que les mines lors d'une defaite
                        {
                            tabMine[i, j].Text = "M";
                        }


                    }

                }

                button1.Enabled = false;        //desactive le button triche car inutile si perdu

            }

            compteur.Text = "Nombre de click : " + count; 

        }


        private void triche()
        {
            int triche;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (tabMine[i, j].Tag.ToString() != "M")
                    {
                        triche = CompteMines(tabMine[i, j]);            //pour tout les bouttons, je recup le nbmine
                        tabMine[i, j].Text = triche.ToString();         //je le met dans le text de tab mine.
                    }
                    else
                    {
                        tabMine[i, j].Text = "M";
                    }


                    if (tabMine[i,j].BackColor== Color.Red)             //quand la case est une mine mais que sont tag != M
                    {
                        tabMine[i, j].Text = "M";
                    }


                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            triche();
        }

        private void Relancer_Click(object sender, EventArgs e)
        {
            for (int i =0; i<10; i++)
            {
                for(int j=0;j<10;j++)
                {
                    this.Controls.Remove(tabMine[i,j]);             //je detruit tt les buttons
                }
            }

            initTabMine();
            installMine();
            count = 0;
            compteur.Text = "Nombre de click : " + count;
            button1.Enabled = true;     //reactive le boutton triche

        }
    }
}

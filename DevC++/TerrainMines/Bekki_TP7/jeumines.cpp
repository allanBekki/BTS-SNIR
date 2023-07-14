#include "jeumines.h"


JeuMines::JeuMines()
{

}

void JeuMines::presentationJeu()
{
    color(9,0);
    gotoxy(39,1);
    cout<<"=========================================";
    gotoxy(40,2);
    color(11,0);
    cout<<"|| Terrain Mine   |   By Bekki Allan ||";
    color(9,0);
    gotoxy(39,3);
    cout<<"=========================================";
    color(15,0);

    champMines.taille=25;
    while ( (champMines.taille>20) || (champMines.taille<6))
    {
        gotoxy(20,10);
        color(11,0);
        cout<<"Taille du terrain(entre 6 et 20): ";
        color(2,0);
        cin>>champMines.taille;        
    }
    color(15,0);
    champMines.initTerrain();

}

void JeuMines::affichePlateauJeu()
{

    champMines.afficheTerrain();

    gotoxy(offsetX + champMines.taille*2 +8, 5);
    color(2,0);
    cout<<"Touches: "<<endl;
    gotoxy(offsetX + champMines.taille*2 +8,6);
    color(9,0);
    cout<<"-------------------------"<<endl;
    color(11,0);
    gotoxy(offsetX + champMines.taille*2 +8,7);
    cout<<"[7]        [8]        [9]"<<endl;
    gotoxy(offsetX + champMines.taille*2 +8,9);
    cout<<"[4]                   [6]";
    gotoxy(offsetX + champMines.taille*2 +8,11);
    cout<<"[1]        [2]        [3]"<<endl;
    gotoxy(offsetX + champMines.taille*2 +8,12);
    color(9,0);
    cout<<"-------------------------";



}


void JeuMines::afficheInfoJoueur()
{
  champMines.afficheCaseTerrain(posX,posY);

  gotoxy(offsetX + champMines.taille*2 +12, 9);
  if(champMines.terrain[posX][posY]!=9)
  {
      if(champMines.terrain[posX][posY]!=0)
      {
          color(6,0);
      } else (color(2,0));

      cout<<champMines.terrain[posX][posY];
      cout<<" Bombes autours";


      if(champMines.terrain[posX][posY]==0)
          color(2,0);
      if(champMines.terrain[posX][posY]>0 && champMines.terrain[posX][posY]<9)
          color(6,0);
      gotoxy(offsetX + champMines.taille*2+1 +8,18);
      cout<<"           __/";
      gotoxy(offsetX + champMines.taille*2+1 +8,19);
      cout<<"          / ";
      gotoxy(offsetX + champMines.taille*2+1 +8,20);
      cout<<"         /  ";
      gotoxy(offsetX + champMines.taille*2+1 +8,21);
      cout<<"   ----------------";
      gotoxy(offsetX + champMines.taille*2+1 +8,22);
      cout<<" \57                  \134";
      gotoxy(offsetX + champMines.taille*2+1 +8,23);
      cout<<"|                    | ";
      gotoxy(offsetX + champMines.taille*2+1 +8,24);
      cout<<"|  \57!\134 BOOOOOM \57!\134   | ";
      gotoxy(offsetX + champMines.taille*2+1 +8,25);
      cout<<"|                    | ";
      gotoxy(offsetX + champMines.taille*2+1 +8,26);
      cout<<" \134                  \57 ";
      gotoxy(offsetX + champMines.taille*2+1 +8,27);
      cout<<"  ------------------ ";
      color(15,0);

  }
  else
  {
    color(4,0);
    cout<<" ***** BOOM *****";
    color(15,0);
  }


  gotoxy(offsetX + posX*2, offsetY + posY);

}

void JeuMines::afficheNbCoups()
{
    gotoxy(offsetX + champMines.taille*2 +8,15);
    color(9,0);
    cout<<"Nombres de coups realise: ";
    color(2,0);
    cout<<nbCoups;
    gotoxy(offsetX + posX*2, offsetY + posY);
    color(15,0);

}


void JeuMines::jouerJeuMines()
{
        presentationJeu();
        affichePlateauJeu();
        posX=0;
        posY=champMines.taille-1;
        nbCoups=0;
        afficheInfoJoueur();
        afficheNbCoups();

        do
        {
            int clavier=getch();
            nbCoups++;

            if(clavier=='1')
            {
                if (posX>0 && posY<champMines.taille-1)
                {
                    posX--;
                    posY++;

                    gotoxy(offsetX + posX*2+2, offsetY + posY-1);       //je me deplace a la position d'avant pour y remettre un "." dans l'affichage. +2 ou -2 en x pcq les points sont distancé en *2 et +1 ou -1 en y pcq la disantance des y est de 1 pixel

                    if(champMines.terrain[posX+1][posY-1]!=0 && posX<champMines.taille-1 && posY>0)
                    {
                        color(6,0);
                        cout<<champMines.terrain[posX+1][posY-1];
                    }
                    else
                    {
                        color(11,0);
                        cout<<"+";
                        color(15,0);
                    }

                }

            }

            if(clavier=='2')
            {
                if(posY<champMines.taille-1)
                {
                    posY++;

                    gotoxy(offsetX + posX*2, offsetY + posY-1);

                    if(champMines.terrain[posX][posY-1]!=0)
                    {
                        color(6,0);
                        cout<<champMines.terrain[posX][posY-1];
                    }
                    else
                    {
                        color(11,0);
                        cout<<"+";
                        color(15,0);
                    }

                }
            }

            if(clavier=='3')
            {
                if(posX<champMines.taille-1 && posY<champMines.taille-1)    //pas sur des tests vis a vis des deplacements  -> UPDATE -> c'est bon
                {
                    posX++;               
                    posY++;

                    gotoxy(offsetX + posX*2-2, offsetY + posY-1);

                    if(champMines.terrain[posX-1][posY-1]!=0 && posX>0 && posY>0)
                    {
                        color(6,0);
                        cout<<champMines.terrain[posX-1][posY-1];
                    }
                    else
                    {
                        color(11,0);
                        cout<<"+";
                        color(15,0);
                    }
                }
            }


             if(clavier=='4')
             {
                 if(posX>0)
                 {
                     posX--;

                    gotoxy(offsetX + posX*2+2, offsetY + posY);

                    if(champMines.terrain[posX+1][posY]!=0)
                    {
                        color(6,0);
                        cout<<champMines.terrain[posX+1][posY];
                    }
                    else
                    {
                        color(11,0);
                        cout<<"+";
                        color(15,0);
                    }
                 }
             }




             if(clavier=='6')
             {
                 if(posX<champMines.taille-1)
                 {
                     posX++;

                     gotoxy(offsetX + posX*2-2, offsetY + posY);

                     if(champMines.terrain[posX-1][posY]!=0)
                     {
                         color(6,0);
                         cout<<champMines.terrain[posX-1][posY];
                     }
                     else
                     {
                         color(11,0);
                         cout<<"+";
                         color(15,0);
                     }
                 }
             }




             if(clavier=='7')
             {
                 if(posX>0 && posY>0)
                 {
                   posX--;
                   posY--;

                   gotoxy(offsetX + posX*2+2, offsetY + posY+1);

                   if(champMines.terrain[posX+1][posY+1]!=0 && posX<champMines.taille-1 && posY<champMines.taille-1)
                   {
                       color(6,0);
                       cout<<champMines.terrain[posX+1][posY+1];
                   }
                   else
                   {
                       color(11,0);
                       cout<<"+";
                       color(15,0);
                   }
                 }
             }



             if(clavier=='8')
             {
                 if(posY>0)
                 {
                     posY--;

                     gotoxy(offsetX + posX*2, offsetY + posY+1);

                     if(champMines.terrain[posX][posY+1]!=0)
                     {
                         color(6,0);
                         cout<<champMines.terrain[posX][posY+1];
                     }
                     else
                     {
                         color(11,0);
                         cout<<"+";
                         color(15,0);
                     }
                 }
             }


             if(clavier=='9')
             {
                 if(posX<champMines.taille-1 && posY>0)
                 {
                    posX++;                                  
                    posY--;

                    gotoxy(offsetX + posX*2-2, offsetY + posY+1);

                    if(champMines.terrain[posX-1][posY+1]!=0 && posX>0 && posY<champMines.taille-1)
                    {
                        color(6,0);
                        cout<<champMines.terrain[posX-1][posY+1];
                    }
                    else
                    {
                        color(11,0);
                        cout<<"+";
                        color(15,0);
                    }
                 }
             }

            afficheInfoJoueur();
            afficheNbCoups();


        }while( ( (posX!=champMines.taille-1)  || (posY!=0) )  && (champMines.terrain[posX][posY]!=9) );                        //fallait inversé le et en ou par rapport a l'algo (jusqu'a qui devient en code tant que)

            if(champMines.terrain[posX][posY]==9)
            {
                getch();
                champMines.afficheEmplacementMines();
                gotoxy(offsetX + champMines.taille*2 +15,17);
                color(4,0);
                cout<<"****Perdu****";
                color(15,0);
            }
            else
            {
                champMines.afficheEmplacementMines();
                gotoxy(offsetX + champMines.taille*2 +15,17);
                color(2,0);
                cout<<"****Gagne****";
                color(15,0);
            }
        gotoxy(offsetX, offsetY+champMines.taille+5);
        getch();
}


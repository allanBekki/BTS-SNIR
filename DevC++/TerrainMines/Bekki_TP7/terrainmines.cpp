#include "terrainmines.h"
#include<cmath>

TerrainMines::TerrainMines()
{

}

void TerrainMines::initTerrain()
{
/*Algorithme : algorithme initTerrain(nbMines) de la classe TerrainMines qui consiste a initialiser le tableau a 0
Auteur : Bekki Allan
Date : 16 Jan 2022

Variables de classes : terrain(20)(20) = tableau d'entiers
Variables : i,j=entier

Debut
    pour i allant de 0 a 20
        pour j allant de 0 a 20
            terrain(i)(j)<-0

    appel de la fonction initMine()
    appel de la fonction initCases()
Fin
*/


    for(int i=0;i<20;i++)
    {
        for(int j=0;j<20;j++)
            terrain[i][j]=0;
    }
    initMines();
    initCases();

}


void TerrainMines::initMines(int nbMines)
{
    /*Algo: Algo initMines(nbMines = entier) de la classe TerrainMines qui consiste a generer des mines dispose aleatoirement dans le tableau
      Auteur: Bekki Allan
      Date: 16 Janv 2022

      Variables de classes : terrain(20)(20) = tableau d'entiers
      Variables : i,j,nbX,nbY=entier

      Debut
        afficher "Nombres de mines: "
        saisir nbMines
        pour i allant de 0 a nbMines
            nbX<- valeur aleatoire de 0 a 20
            nbY<- valeur aleatoire de 0 a 20
            si (terrain(nbX)(nbY)=9)
                i<-i-1
            sinon terrain(nbX)(nbY)=9
      Fin*/

    do
    {
        gotoxy(20,11);
        color(11,0);
        cout<<"Nombres de mines: ";
        color(2,0);
        cin>>nbMines;
    } while(nbMines>taille*taille-2);
    color(15,0);

    int nbX, nbY;
    srand(time(0));

    for (int i=0;i<nbMines;i++)
    {
        nbX=rand()%taille;
        nbY=rand()%taille;
        if(terrain[nbX][nbY]==9 || (nbX==0 && nbY==taille-1) || (nbX==taille-1 && nbY==0))  //si la case=9 -> decrementation, si la case est celle du debut ou de la fin -> decremetation
            i--;
        else terrain[nbX][nbY]=9;
    }

}

void TerrainMines::afficheTerrain()
{   /*Algo: Algorithme afficheTerrain de la classe TerrainMines qui permet d'afficher (les cases avec un caractere) du terrain sur l'ecran console avec indication de la case de debut et de fin.
      Auteur: Bekki Allan
      Date : 14 Jan 2022

      Variables de classes:
      Variable:  i,j =entier

      Debut
        effacer ecran systeme
        pour i allant de 0 à 20
            pour j allant de 0 à 20
            aller en x=20+i et y=20+j
                afficher "."
        aller en x=17 et y=39
        afficher "D->"
        aller en x=42 et y=20
        afficher "<-A"
        pause
      Fin*/

    system("cls");
    color(14,0);
    int i,j;
    for (i=0; i<taille; i++)
    {
        for(j=0; j<taille;j++)
        {
            gotoxy(offsetX+i*2,offsetY+j);
            cout<<".";
        }
    }

    gotoxy(offsetX-6,offsetY+taille-1);
    color(2,0);
    cout<<"D->";
    gotoxy(offsetX+(taille*2),offsetY);
    cout<<" <-A";
    color(15,0);

}

void TerrainMines::afficheEmplacementMines()
{
    /*Algo: algorithme de afficheEmplacementMines() de la classe TerrainMines qui permet d'afficher le terrain avec les mines disposé dessus.
      Auteur: Bekki Allan
      Date: 14 Jan 2022

      Variables de classe: terrain(20)(20)= tableau d'entiers

      Variables :

      Debut
        effacer ecran systeme
        pour i allant de 0 à 20
            pour j allant de 0 à 20
            aller en x=20+i et y=20+j
            si (terrain (i)(j)<>9)
                afficher "."
                sinon afficher "*"
        aller en x=17 et y=39
        afficher "D->"
        aller en x=42 et y=20
        afficher "<-A "
      Fin*/


    int i,j;
    for (i=0; i<taille; i++)
    {
        for(j=0; j<taille;j++)
        {
           gotoxy(offsetX+i*2,offsetY+j);
            if(terrain[i][j]!=9)
            {
                color(14,0);
                cout<<".";
            }
            else
            {
                color(4,0);
                cout<<"*";
                color(15,0);
            }
        }
    }



}

void TerrainMines::afficheCaseTerrain(int x, int y)
{

    gotoxy(offsetX + x*2, offsetY + y);    //vous m'avez mis cela dans cette fonction la derniere fois, je pense que vous avez inversé, mais j'ai laissé car cela fonctionne aussi meme si c'est inversé je pense
    color(30,0);
    cout<< 'o';



}

void TerrainMines::initCases()
{
    int valcase,x,y;
    for (x=0; x<20; x++)
        {
            for (y=0; y<20; y++)
                {
                    valcase=0;
                    if(terrain[x][y] == 0)

                              {
                                if(y<taille-1 && terrain[x][y+1]==9)
                                    valcase++;
                                if(y>0 && terrain[x][y-1]==9)
                                    valcase++;
                                if(x<taille-1 && terrain[x+1][y]==9)
                                    valcase++;
                                if(x>0 && terrain[x-1][y]==9)
                                    valcase++;
                                if(x<taille-1 && y<taille-1 && terrain[x+1][y+1]==9)
                                    valcase++;
                                if(x>0 && y>0 && terrain[x-1][y-1]==9)
                                    valcase++;
                                if(x<taille-1 && y>0 && terrain[x+1][y-1]==9)
                                    valcase++;
                                if(x>0 && y< taille-1 && terrain[x-1][y+1]==9)
                                    valcase++;


                                terrain[x][y]=valcase;
                              }

            }
        }
}

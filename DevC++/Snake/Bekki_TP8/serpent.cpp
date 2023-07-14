#include "serpent.h"


Serpent::Serpent()
{

}

void Serpent::afficheSerpent()
{
    /* Algo: Methode afficheSerpent() de la classe Serpent qui affiche la tete et le corps du serpent.
       Auteur: Bekki Allan
       Date: 31 Janv 2022

       Variables de Classes : corps(100) -> tableau de posX ET posY
                              tete -> de type structure avec posX-> entier ET posY -> entier
                              careffacement -> de type structure avec posX-> entier ET posY -> entier
                              offsetX, offsetY -> entier

       Variables : i -> entier

       Debut

        aller au positions x-> offsetX+tete.posX et y->offsetY+tete.posY
        afficher "@"

        pour i allant de 0 a 100 (ou longueur)                                                  //remplacer par longueur
            Si corps.posX<>0 et corps.posY<>0
                alors aller au positions x-> offsetX+corps.posX et y->offsetY+corps.posY
                afficher "o"


        aller aux coordonnées x-> offsetX+carEffacement.posX et y-> offsetY+carEffacement.posY
        afficher " "

       Fin

     */
    color(14,0);
    gotoxy(offsetX+tete.posX , offsetY+tete.posY);
    cout<<"@";

    for(int i=0 ; i<longueur ; i++)
    {

        gotoxy(offsetX+corps[i].posX, offsetY+corps[i].posY);
        cout<<"o";

    }

    if( offsetX + carEffacement.posX != offsetX && offsetY + carEffacement.posY != offsetY)
    {
        gotoxy(offsetX+carEffacement.posX , offsetY+carEffacement.posY);
        cout<<" ";
    }


    color(15,0);






}

void Serpent::allongeSerpent()
{
     /*Algo: Méthode allongeSerpent() de la classe serpent, qui augmente la taille du serpent quand il est sur la position d'une vitamine.
       Auteur: Bekki Allan
       Date: 31 Janv 2022

       Variables de classe: longueur type entier

       Debut

        longueur <- longueur + 1

       Fin
      */

        longueur++;

}

void Serpent::deplaceSerpent()
{
    /* Algo: Méthode deplaceSerpent() de la classe serpent, qui deplace le serpent dans sur le plateau
       Auteur: Bekki Allan
       Date: 31 Janv 2022

       Variables de classe: corps(100) -> tableau de posX ET posY
                            direction -> de type structure avec posX-> entier ET posY -> entier
                            careffacement -> de type structure avec posX-> entier ET posY -> entier
                            offsetX, offsetY -> entier

       Variables: i -> entier
                  clavier -> fonction kbhit()


       Debut



       careffacement.posX -> corps(longueur).posX
       careffacement.posY -> corps(longueur).posY

       pour i allant de longueur a 0

            corps(i).posX -> corps(i-1).posX
            corps(i).posY -> corps(i-1).posY

       corps(0).posX -> tete.posX
       corps(0).posY -> tete.posY

       Fin

      */
    if ( longueur > 0)
    {
        carEffacement.posX=corps[longueur-1].posX;
        carEffacement.posY=corps[longueur-1].posY;

        for (int i= longueur-1 ; i>0 ; i--)
        {
            corps[i].posX=corps[i-1].posX;
            corps[i].posY=corps[i-1].posY;

        }

        corps[0].posX=tete.posX;
        corps[0].posY=tete.posY;

    } else
        {
            carEffacement.posX=tete.posX;
            carEffacement.posY=tete.posY;
        }




    tete.posX = tete.posX + direction.posX;
    tete.posY = tete.posY + direction.posY;




}

void Serpent::initSerpent()
{
    /* Algo: Méthode initSerpent de la classe serpent, qui initialise le corps du serpent et attribue des positions a la tete ainsi qu'au corps.
       Auteur: Bekki Allan
       Date: 31 Janv 2022

       Variables de classe: corps(100) -> tableau de posX ET posY
                            tete -> de type structure avec posX-> entier ET posY -> entier

       Variables: i -> entier


       Debut

        pour i allant de 0 a 100
            corps(i).posX=0
            corps(i).posY=0

        tete -> posX->30
                posY->10



       Fin
      */

    for (int i=0 ; i<100 ; i++)
    {

        corps[i].posX=0;
        corps[i].posY=0;

    }

    tete.posX=offsetX+10;
    tete.posY=offsetY+3;

    carEffacement.posX=29;
    carEffacement.posY=10;

    direction.posX=0;
    direction.posY=0;

}

bool Serpent::mortSerpent()
{
    bool mort=0;

    if (tete.posX == 0 || tete.posX == 60 || tete.posY == 0 || tete.posY==20)
    {
        mort = 1;
    }

    for ( int i = 0 ; i<longueur ; i++ )
    {
        if ( tete.posX == corps[i].posX && tete.posY == corps[i].posY )
        {
            mort = 1;
        }
    }

    return mort;
}





void Serpent::infoSerpent()
{
    gotoxy( offsetX + 64 , offsetY +8);
    color(7,0);
    cout<<"Longeur du Serpent : "<<longueur;
}



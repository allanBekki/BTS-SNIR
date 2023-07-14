#include "vitamine.h"

Vitamine::Vitamine()
{

}

void Vitamine::afficheVitamine()
{
    gotoxy( offsetX + vit.posX , offsetY + vit.posY );
    color(2,0);
    cout<<"$";
    color(15,0);

}

void Vitamine::deplaceVitamine()
{
    /* Algo: Algo de la methode deplaceVitamine() de la classe vitamine qui initialise les coordonnées d'une vitamine de maniere aleatoire
       Auteur: Bekki Allan
       Date: 23 Fev 2022

       Variable de classe: posX, posY -> structure

       Variable:

       Debut
        vit.posX <- valeur aleatoire comprise entre 21 et 79
        vit.posY <- valeur aleatoire comprise entre 6 et 24


      //   Si (tete.posX = vit.posX et tete.posY = vit.posY)
            alors vit.posX <- valeur aleatoire comprise entre 21 et 79
                  vit.posY <- valeur aleatoire comprise entre 6 et 24  //


       Fin

     */

    const int minX = 1;
    const int minY = 1;

    const int maxX = 49;
    const int maxY = 20;

    srand( time (0) );

    int rX = minX + (rand() % (maxX - minX));      // generation d'un nombre aleatoire comprise entre deux bornes
    int rY = minY + (rand() % (maxY - minY));


    vit.posX=rX;
    vit.posY=rY;


    //cout<<vit.posX<<endl<<vit.posY;


}


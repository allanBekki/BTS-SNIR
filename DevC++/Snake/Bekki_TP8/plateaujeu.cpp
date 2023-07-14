#include "plateaujeu.h"

PlateauJeu::PlateauJeu()
{

}

void PlateauJeu::affichePlateau()
{
    /* Algo: Algo de la methode affichePlateau de la classe PlateauJeu() qui permet d'affiche le plateau de jeu
       Auteur: Bekki Allan
       Date: 31 Janv 2022

       Variables de classes: offsetX
                             offsetY

       Variables: x, y -> entier


       Debut

       aller en abscisse -> offsetX+20 et ordonné -> offsetY+10
       afficher "Vous allez jouer a SNAKE"
       afficher "Voulez-vous continuer ?"


        aller en abscisse -> offsetX et ordonné -> offsetY
        pour x allant de 0 a 60
            afficher "-"

        pour y allant de 0 a 20
            aller en abscisse -> offsetX et ordonné -> offsetY+y
            afficher "|"

        aller en abscisse -> offsetX et ordonné -> offsetY+20
        pour x allant de 0 a 20
            afficher "-"

        pour y allant de 0 a 20
        aller en abscisse -> offsetX+60 et ordonné -> offsetY+y


       Fin

     */

    color(12,0);

    for(int x=0 ; x<61 ; x++)
    {

        gotoxy(offsetX+x,offsetY);
        cout<<"\315";                  //ascii en octal

        gotoxy(offsetX+x,offsetY+20);
        cout<<"\315";
    }

    for (int y=1 ; y<20 ; y++)
    {
        gotoxy(offsetX,offsetY+y);
        cout<<(char)186;                //cast en caractere d'une valeur en dec

        gotoxy(offsetX+60,offsetY+y);
        cout<<(char)186;
    }

    gotoxy(offsetX,offsetY+20);
    cout<<(char)200;                    //les coins du cadres

    gotoxy(offsetX,offsetY);
    cout<<(char)201;

    gotoxy(offsetX+60,offsetY);
    cout<<"\273";

    gotoxy(offsetX+60,offsetY+20);
    cout<<"\274";

    color(1,0);

    for(int x=0 ; x<5 ; x++)                            //cadre des touches (trait vertivale)
    {
        gotoxy(offsetX+75+x,offsetY);
        cout<<"\315";

        gotoxy(offsetX+75+x,offsetY+2);
        cout<<"\315";


        gotoxy(offsetX+75+x,offsetY+3);
        cout<<"\315";

        gotoxy(offsetX+75+x,offsetY+5);
        cout<<"\315";

        gotoxy(offsetX+69+x,offsetY+3);
        cout<<"\315";

        gotoxy(offsetX+69+x,offsetY+5);
        cout<<"\315";

        gotoxy(offsetX+81+x,offsetY+3);
        cout<<"\315";

        gotoxy(offsetX+81+x,offsetY+5);
        cout<<"\315";
    }



        gotoxy(offsetX+75,offsetY+1);        //lignes horizontales
        cout<<(char)186;
        gotoxy(offsetX+75+4,offsetY+1);
        cout<<(char)186;

        gotoxy(offsetX+69,offsetY+4);
        cout<<(char)186;
        gotoxy(offsetX+73,offsetY+4);
        cout<<(char)186;

        gotoxy(offsetX+75,offsetY+4);
        cout<<(char)186;
        gotoxy(offsetX+79,offsetY+4);
        cout<<(char)186;

        gotoxy(offsetX+81,offsetY+4);
        cout<<(char)186;
        gotoxy(offsetX+85,offsetY+4);
        cout<<(char)186;


        gotoxy(offsetX+75 , offsetY+2);     // coin en bas a gauche
        cout<<(char)200;
        gotoxy(offsetX+69 , offsetY+5);
        cout<<(char)200;
        gotoxy(offsetX+75 , offsetY+5);
        cout<<(char)200;
        gotoxy(offsetX+81 , offsetY+5);
        cout<<(char)200;

        gotoxy(offsetX+75 , offsetY);  //coin en haut a gauche
        cout<<(char)201;
        gotoxy(offsetX+69 , offsetY+3);
        cout<<(char)201;
        gotoxy(offsetX+75 , offsetY+3);
        cout<<(char)201;
        gotoxy(offsetX+81 , offsetY+3);
        cout<<(char)201;

        gotoxy(offsetX+79 , offsetY);  //coin en haut a droite
        cout<<"\273";
        gotoxy(offsetX+73 , offsetY+3);
        cout<<"\273";
        gotoxy(offsetX+79 , offsetY+3);
        cout<<"\273";
        gotoxy(offsetX+85 , offsetY+3);
        cout<<"\273";

        gotoxy(offsetX+79,offsetY+2);  //coin en bas a droite
        cout<<"\274";
        gotoxy(offsetX+73,offsetY+5);
        cout<<"\274";
        gotoxy(offsetX+79,offsetY+5);
        cout<<"\274";
        gotoxy(offsetX+85,offsetY+5);
        cout<<"\274";

        color(11,0);

        gotoxy(offsetX+63,offsetY+1);
        cout<<"Touches :";

        gotoxy(offsetX+77,offsetY+1);
        cout<<"Z";

        gotoxy(offsetX+77,offsetY+4);
        cout<<"S";

        gotoxy(offsetX+71,offsetY+4);
        cout<<"Q";

        gotoxy(offsetX+83,offsetY+4);
        cout<<"D";

        color(2,0);

        gotoxy(offsetX+2 ,1);
        cout<<"                          888";
        gotoxy(offsetX+2 ,2);
        cout<<".d8888b  88888b.  8888b.  888  888  .d88b.";
        gotoxy(offsetX+2 ,3);
        cout<<"88K      888  88b    '88b 888 .88P d8P  Y8b";
        gotoxy(offsetX+2 ,4);
        cout<<"'Y8888b. 888  888 .d88888 8888888K 88888888";
        gotoxy(offsetX+2 ,5);
        cout<<"     X88 888  888 888  88 8888 '88b Y8b.";
        gotoxy(offsetX+2 ,6);
        cout<<" 88888P' 888  888 'Y88888 8888  888 'Y8888";
        gotoxy(offsetX+45 ,6);
        color(5,0);
        cout<<"By Allan Bekki";

        color(2,0);


        gotoxy(offsetX+63, offsetY+15);
        cout<<"                    _,.--.";
        gotoxy(offsetX+63, offsetY+16);
        cout<<"--..,_           .'`__ o  `;__,";
        gotoxy(offsetX+63, offsetY+17);
        cout<<"   `'.'.       .'.'`  '---'`  '";
        gotoxy(offsetX+63, offsetY+18);
        cout<<"      '.`-...-'.'";
        gotoxy(offsetX+63, offsetY+19);
        cout<<"       `-...-'";

        color(15,0);

}

void PlateauJeu::presentation()
{
    affichePlateau();
    color(14,0);
    gotoxy(offsetX+19,offsetY+10);
    cout<<"Vous allez jouer a SNAKE";
    gotoxy(offsetX+19,offsetY+11);
    cout<<"Voulez-vous continuer ?";
    getch();
    system("cls");
}

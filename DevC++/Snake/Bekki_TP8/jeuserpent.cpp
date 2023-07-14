#include "jeuserpent.h"

JeuSerpent::JeuSerpent()
{

}

void JeuSerpent::jouerJeuSerpent()
{
    char car;


    do
    {


    boa.longueur=0;

    plateau.presentation();
    plateau.affichePlateau();
    boa.initSerpent();
    appat.deplaceVitamine();


    vitesse=150;
    boa.afficheSerpent();



    do
    {
        appat.afficheVitamine();

        if( boa.tete.posX == appat.vit.posX && boa.tete.posY == appat.vit.posY )
        {
            boa.allongeSerpent();

            appat.deplaceVitamine();

            for ( int i = 0 ; i < boa.longueur ; i++)
            {
                if ( boa.corps[i].posX != appat.vit.posX && boa.corps[i].posY == appat.vit.posY)
                {
                    appat.deplaceVitamine();
                }
            }



            if (vitesse>=30)
            {
                vitesse-=5;
            }


        }

        boa.infoSerpent();
        boa.deplaceSerpent();
        boa.afficheSerpent();

        if ( kbhit() )
        {
            car = getch() ;

            if ( car == 'z' || car == 'Z')
            {
                boa.direction.posX=0;
                boa.direction.posY=-1;
            }

            if ( car == 'q' || car == 'Q')
            {
                boa.direction.posX=-1;
                boa.direction.posY=0;
            }

            if ( car == 's' || car == 'S')
            {
                boa.direction.posX=0;
                boa.direction.posY=+1;
            }

            if ( car == 'd' || car == 'D')
            {
                boa.direction.posX=+1;
                boa.direction.posY=0;
            }
        }
        gotoxy( boa.tete.posX + offsetX , boa.tete.posY + offsetY );
        Sleep(vitesse);        

    } while( boa.mortSerpent() != 1 );


    gotoxy (offsetX + 12 , offsetY + 10 );
    color(14,0);
    cout<<"Perdu - Voulez-vous recommencer (o/n)?";
    color(15,0);

    car = getch();
    system("cls");

    } while ( car != 'n' && car != 'N');

}

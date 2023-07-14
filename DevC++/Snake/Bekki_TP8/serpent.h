#ifndef SERPENT_H
#define SERPENT_H
#include"positionxy.h"


class Serpent
{
public:
    Serpent();
    void afficheSerpent();
    void allongeSerpent();
    void deplaceSerpent();
    void initSerpent();
    bool mortSerpent();


    void infoSerpent();

    //Attributs:

    int longueur;
    PositionXY corps[100];
    PositionXY carEffacement;
    PositionXY direction;
    PositionXY tete;




};

#endif // SERPENT_H

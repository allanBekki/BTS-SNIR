#ifndef JEUSERPENT_H
#define JEUSERPENT_H

#include"positionxy.h"
#include"plateaujeu.h"
#include"serpent.h"
#include"vitamine.h"



class JeuSerpent
{
public:
    JeuSerpent();    
    void jouerJeuSerpent();


private:

    //Attributs:

    int vitesse;

    //Objets:

    PlateauJeu plateau;
    Serpent boa;
    Vitamine appat;



};

#endif // JEUSERPENT_H

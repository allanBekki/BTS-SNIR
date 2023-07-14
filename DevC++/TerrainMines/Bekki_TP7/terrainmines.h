#ifndef TERRAINMINES_H
#define TERRAINMINES_H
#include "consoleJR.h"
#include <iostream>
#include <conio.h>
#include <time.h>
#include <stdlib.h>

#define offsetX 20
#define offsetY 5

using namespace std;

class TerrainMines
{
public:
    TerrainMines();
    void initTerrain();
    void afficheTerrain();
    void afficheEmplacementMines();
    void afficheCaseTerrain( int x, int y);



    void initMines(int nbMines =10);
    void initCases();


    //Attributs :
                int taille;
                int terrain[20][20];

};

#endif // TERRAINMINES_H

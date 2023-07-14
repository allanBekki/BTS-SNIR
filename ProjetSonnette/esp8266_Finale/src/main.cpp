#include <Arduino.h>

#include "clientesp.h"

#include "servRasp.h"

#include "sim.h"

int buttonState = 0; //variable pour stocjer l'etat du bt

ClientEsp client1;
ServRasp serveurRasp;
Sim gsm;

void setup() 
{ 
 Serial.begin(9600); 
 pinMode(D5,INPUT);
 pinMode(D6,OUTPUT);
 serveurRasp.initialisation();
 gsm.initialisation();
}

void loop() 
{
  //SI L'ADMIN APPELLE LA SONNERIE
  gsm.updateSerial();

//------------------------------------------------------------------------------------------------------------------

  //SI BOUTTON PRESSEE    
  buttonState = digitalRead(D5); //lecture de l'etat du bouton
  if(buttonState == LOW)
    {
      digitalWrite(D6, LOW);  //Led allumé
      Serial.println("allumé");
      client1.envoieRequetes(); //envoie des requetes sonnerie - detection - prise photo
    }

//------------------------------------------------------------------------------------------------------------------

  //EN CAS DE REPONSE DU RASPBERRY LORS DE LA DETECTION PRESENCE
  if(serveurRasp.nouvelleConnexion() == true)
  {
    String requete2 = serveurRasp.lireRequete();

    if(gsm.declencheurSMS == requete2)
    {
        Serial.print("Envoie du SMS...");
        gsm.envoieMessage();

        serveurRasp.resetRequete();   //à vérifier
    }
    
  }
}
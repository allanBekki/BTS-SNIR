#include <Arduino.h>
#include <ESP32_FTPClient.h>
#include "cam.h"
#include "serv.h"
#include "monFtp.h"






Serv serveur;
Cam camera;
MonFtp upFtp;



void setup() 
{
  Serial.begin(9600);
  pinMode(33,OUTPUT);

  serveur.initialisation();
  camera.initCam();
  camera.initSD();
}

void loop() 
{
  if(serveur.nouvelleConnexion() == true)
  {
    String requete = serveur.lireRequete();

    if(camera.declencheur == requete)
    {
      camera.capturePhoto();
      camera.sauvegardeSD();

      char nomFichier[20];
      std::sprintf(nomFichier, "picture%d.jpg", camera.pictureNumber);
      
      upFtp.uploadFile(camera.fb->buf,camera.fb->len,nomFichier);

      /*free(camera.fb->buf);
      camera.fb->buf = NULL;*/

      esp_camera_fb_return(camera.fb);
      
      

    }

    //serveur.fermerConnexion();

  }
}
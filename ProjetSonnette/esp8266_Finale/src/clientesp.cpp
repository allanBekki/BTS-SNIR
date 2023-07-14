#include "clientesp.h"

void ClientEsp::connexionWIFI()
{
    WiFi.begin(ssid, password); // Se connecter au réseau WiFi

    while (WiFi.status() != WL_CONNECTED)   //Vérification connexion
    {
        delay(1000);
        Serial.println("Connexion en cours...");
    }

    Serial.println("Connecté au réseau WiFi");
}

//------------------------------------------------------------------------------------------------------------------

void ClientEsp::envoieRequetes()
{

    client.connect(adresse_ip_rasp, 5100);
    Serial.println("Connecté au rasp, envoie Sonnerie");
    client.print(String("GET /sonnerie HTTP/1.1\r\n") + "Host: " + adresse_ip_rasp + "\r\n" + "Connection: close\r\n\r\n");

    

    client.connect(adresse_ip_rasp, 5200);
    Serial.println("Connecté au rasp, envoie Detection présence");  
    client.print(String("GET /detection_presence HTTP/1.1\r\n") + "Host: " + adresse_ip_rasp + "\r\n" + "Connection: close\r\n\r\n");


    client.stop();

  
    if (client.connect(adresse_ip_serveurESP, 1250 ))         // Établir une connexion avec le serveur /////////////////serveur port à mettre
    { 
        Serial.println("Connecté au serveur");
              
        client.write("Prend une photo");            //Envoie des données vers le serveur

    } 
    else 
    {
        Serial.println("Impossible de se connecter au serveur");
    }
}

//------------------------------------------------------------------------------------------------------------------

void ClientEsp::reponse()
{
    String url = "http://172.16.205.23:5200/detection_presence";
    http.begin(client,url);

    int httpCode = http.GET();

    if (httpCode > 0) {
      String payload = http.getString(); // Obtenez la réponse du serveur
      Serial.println("Réponse du serveur:");
      Serial.println(payload);
    } else {
      Serial.print("Erreur dans la requête GET: ");
      Serial.println(httpCode);
    }

    http.end(); // Fermez la connexion
   

    delay(5000); // Attendez 5 secondes avant la prochaine requête

}
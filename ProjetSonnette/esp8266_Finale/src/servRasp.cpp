#include "servRasp.h"

ServRasp::ServRasp()
{
    serveur = new WiFiServer(2000);
}

//------------------------------------------------------------------------------------------------------------------

void ServRasp::initialisation()
{

    IPAddress ip(192, 168, 100, 10); // Adresse IP fixe du serveur                                          
    IPAddress gateway(192, 168, 100, 1); // Adresse IP de la passerelle
    IPAddress subnet(255, 255, 255, 0); // Masque de sous-réseau

    WiFi.config(ip, gateway, subnet); // Configuration de l'adresse IP, de la passerelle et du masque de sous-réseau
    
    
    
    WiFi.begin(ssid, password); // Connexion au réseau WiFi

    while (WiFi.status() != WL_CONNECTED) 
    {
        delay(1000);
        Serial.println("Connexion en cours au reseau WiFi...");

    }

    IPAddress adresse_ip = WiFi.localIP(); // Obtenir l'adresse IP du serveur
    Serial.print("Adresse IP du serveur : ");
    Serial.println(adresse_ip);
    
    serveur->begin(); // Démarrer le serveur
}

//------------------------------------------------------------------------------------------------------------------

bool ServRasp::nouvelleConnexion()
{
    client = serveur->accept();
    
    if(client)
    {
        return true;
    }
    else
    {
        return false;
    }

}

//------------------------------------------------------------------------------------------------------------------

String ServRasp::lireRequete()
{
    String req;

    Serial.println("Nouvelle connexion entrante");
    client.readBytes(request, sizeof(request));         // lire la demande du client
    Serial.print("Client request: ");
    Serial.println(request);
    req = request;


    return req;
}

//------------------------------------------------------------------------------------------------------------------

void ServRasp::resetRequete()
{
    for (int i=0 ; i<128;i++)
        {
            request[i] = 0;
        }
}

//------------------------------------------------------------------------------------------------------------------

void ServRasp::fermerConnexion()
{
    serveur->close();
}
#include <ESP8266WiFi.h>
//#include <WiFiAP.h>
#include <string>

class ServRasp
{
    public:
        ServRasp();
        void initialisation();
        bool nouvelleConnexion();
        String lireRequete();
        void resetRequete();
        void fermerConnexion();
        
        char request[128] = {0};            // initialiser une variable pour stocker la demande du client
        const char* ssid = "Raspiwifi";              
        const char* password = "CeciEstMaClefWPA2";  
        WiFiServer * serveur;         
        WiFiClient client; 
};
#include <WiFiClient.h>
#include <ESP8266WiFi.h>
#include <ESP8266HTTPClient.h>

class ClientEsp
{
    public:

    void connexionWIFI();
    void envoieRequetes();
    void reponse();

    WiFiClient client;
    HTTPClient http;
    
    String requete = "Prend une photo";
    const char* ssid = "Raspiwifi";
    const char* password = "CeciEstMaClefWPA2";
    const char* adresse_ip_serveurESP = "192.168.100.20"; // Adresse IP du serveur 
    const char* adresse_ip_rasp = "192.168.100.1"; // Adresse IP du raspberry

};
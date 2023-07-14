#include <SoftwareSerial.h>
// MODULE GSM GPRS A6
extern SoftwareSerial mySerial;



class Sim
{
    public:
        void initialisation();
        void envoieMessage();
        void appel();
        void updateSerial();

        String phoneNumber;
        String declencheurSMS = "Envoie SMS";
        const char* trustedNumberAllan = "33602229758"; // Remplacez ceci par le numéro de téléphone spécifique que vous voulez autoriser.
        const char* trustedNumberSaad = "33768133981"; // Remplacez ceci par le numéro de téléphone spécifique que vous voulez autoriser.
        const char* trustedNumberQuentin = "33770492365"; // Remplacez ceci par le numéro de téléphone spécifique que vous voulez autoriser.


        

};
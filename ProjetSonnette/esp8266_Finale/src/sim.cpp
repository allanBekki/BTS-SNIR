#include "sim.h"

SoftwareSerial mySerial(D3, D2);

void Sim::updateSerial()
{
    delay(200);                                 //delay d'anti rebond pour le bouton anti poussoire
    while (Serial.available()) 
    {
        mySerial.write(Serial.read());          //Transférer ce que Serial a reçu au port série du logiciel
    }

    while(mySerial.available()) 
    {
        char pchar[255] = {0};
        mySerial.read(pchar,100);
        Serial.write(pchar);                    //Voir le contenu de pchar
        

        //RECUPERATION DU NUMERO ARRIVANT POUR REALISER LE FILTRE
        char *pt = strstr(pchar, "+CLIP:");
        if ( pt != 0)
            {   
                pt+=8;
                char numero[15]={0};
                strncpy (numero, pt, 11);       //nous copions 11 caractere à partir de +CLIP: de pt à numero
                Serial.println(numero);
                phoneNumber = String(numero);   
            }
        Serial.write("#");
        if (strstr(pchar,"RING")!= 0)
        {
            appel();
        }

    }
}

//------------------------------------------------------------------------------------------------------------------

void Sim::initialisation()
{
    mySerial.begin(9600);
    Serial.println("Initializing...");
    delay(1000);

    mySerial.println("AT"); //Once the handshake test is successful, it will back to OK
    updateSerial();
    mySerial.println("AT+CSQ"); //Signal quality test, value range is 0-31 , 31 is the best
    updateSerial();
    mySerial.println("AT+CCID"); //Read SIM information to confirm whether the SIM is plugged
    updateSerial();
    mySerial.println("AT+CREG?"); //Check whether it has registered in the network
    updateSerial();
    mySerial.println("AT+CLIP=1");
    updateSerial();

}

//------------------------------------------------------------------------------------------------------------------

void Sim::envoieMessage()
{
    mySerial.println("AT+CMGF=1"); // Configuring TEXT mode
    updateSerial();

    mySerial.println("AT+CMGS=\"+33602229758\"");//change ZZ with country code and xxxxxxxxxxx with phone number to sms
    updateSerial();
    mySerial.print("Une personne sonne a votre porte."); //text content
    updateSerial();
    mySerial.write(26); //26 sert à envoyer un Ctrl Z qui est necessaire à m'envoie du SMS




/*
    mySerial.println("AT+CMGS=\"+33768133981\"");//change ZZ with country code and xxxxxxxxxxx with phone number to sms
    updateSerial();
    mySerial.print("une personne a sonné a la porte"); //text content
    updateSerial();
    mySerial.write(26);
*/

/*
    mySerial.println("AT+CMGS=\"+33770492365\"");//change ZZ with country code and xxxxxxxxxxx with phone number to sms
    updateSerial();
    mySerial.print("une personne a sonné a la porte"); //text content
    updateSerial();
    mySerial.write(26);*/
}

//------------------------------------------------------------------------------------------------------------------

void Sim::appel()
{

    if (phoneNumber == trustedNumberAllan || phoneNumber == trustedNumberSaad || phoneNumber == trustedNumberQuentin) 
    {
        mySerial.println("ATA"); // Décroche l'appel.
        Serial.println("Numéro de Confiance, l'appel a été accepté");
    } else 
    {
        mySerial.println("ATH"); // Rejette l'appel.
        Serial.println("Numéro Inconnu, l'appel a été décliné");
    }


    /*int numberStartIndex = strstr(pchar, "+CLIP: \"") - pchar + 12;
    int numberEndIndex = strstr(pchar, "\",") - pchar;
    String incomingNumber = String(pchar).substring(numberStartIndex, numberEndIndex);

    if (incomingNumber == trustedNumberAllan || incomingNumber == trustedNumberSaad || incomingNumber == trustedNumberQuentin) 
    {
        mySerial.println("ATA"); // Décroche l'appel.
    } else 
    {
        mySerial.println("ATH"); // Rejette l'appel.
    }*/


    /*String response = mySerial.readString();
    mySerial.println("AT+CLCC");
    delay(500);
    response = mySerial.readString();
    if (response.indexOf("+CLCC:") != -1) { // si le numéro est récupéré
        int commaIndex = response.indexOf(",") + 2;
        String phoneNumber = response.substring(commaIndex, commaIndex + 13); // extraire le numéro de téléphone
        Serial.println("Numéro de téléphone : " + phoneNumber);
    }*/


   /*mySerial.println("ATA");
   Serial.println("envoie ATA");*/

   
}


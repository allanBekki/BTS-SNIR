#include "cam.h"

#define PWDN_GPIO_NUM     32
#define RESET_GPIO_NUM    -1
#define XCLK_GPIO_NUM      0
#define SIOD_GPIO_NUM     26
#define SIOC_GPIO_NUM     27
  
#define Y9_GPIO_NUM       35
#define Y8_GPIO_NUM       34
#define Y7_GPIO_NUM       39
#define Y6_GPIO_NUM       36
#define Y5_GPIO_NUM       21
#define Y4_GPIO_NUM       19
#define Y3_GPIO_NUM       18
#define Y2_GPIO_NUM        5
#define VSYNC_GPIO_NUM    25
#define HREF_GPIO_NUM     23
#define PCLK_GPIO_NUM     22

#define EEPROM_SIZE 1     //permet de définir le nb d'octets qu'on peut acceder en memoire flash, ici 1 permet d'avoir 256 numéros d'image


void Cam::initCam()
{
    //CAMERA CONFIGURATION
    camera_config_t config;
    config.ledc_channel = LEDC_CHANNEL_0;
    config.ledc_timer = LEDC_TIMER_0;
    config.pin_d0 = Y2_GPIO_NUM;
    config.pin_d1 = Y3_GPIO_NUM;
    config.pin_d2 = Y4_GPIO_NUM;
    config.pin_d3 = Y5_GPIO_NUM;
    config.pin_d4 = Y6_GPIO_NUM;
    config.pin_d5 = Y7_GPIO_NUM;
    config.pin_d6 = Y8_GPIO_NUM;
    config.pin_d7 = Y9_GPIO_NUM;
    config.pin_xclk = XCLK_GPIO_NUM;
    config.pin_pclk = PCLK_GPIO_NUM;
    config.pin_vsync = VSYNC_GPIO_NUM;
    config.pin_href = HREF_GPIO_NUM;
    config.pin_sscb_sda = SIOD_GPIO_NUM;
    config.pin_sscb_scl = SIOC_GPIO_NUM;
    config.pin_pwdn = PWDN_GPIO_NUM;
    config.pin_reset = RESET_GPIO_NUM;
    config.xclk_freq_hz = 20000000;
    config.pixel_format = PIXFORMAT_JPEG;

    if(psramFound())  //Paramètres pour un appareil photo avec PSRAM
    {
    config.frame_size = FRAMESIZE_UXGA; // FRAMESIZE_ + QVGA|CIF|VGA|SVGA|XGA|SXGA|UXGA
    config.jpeg_quality = 10;
    config.fb_count = 2;
    }
    else              // Si pas PSRAM
    {
    config.frame_size = FRAMESIZE_SVGA;
    config.jpeg_quality = 12;
    config.fb_count = 1;
    }


    // Init Camera
  esp_err_t err = esp_camera_init(&config);
  if (err != ESP_OK) 
  {
    Serial.printf("Camera init failed with error 0x%x", err);
    return;
  }

    Serial.println("Initialisation Camera OK");
}

//-------------------------------------------------------------------------------------------------------------------------------

void Cam::initSD()
{
    //INIT SD
    //Serial.println("Starting SD Card");
    if(!SD_MMC.begin())
    {
        Serial.println("SD Card Mount Failed");
        return;                                                                               //A REMETTRE QUAND J'AURAIS LA SD
    }
    
    uint8_t cardType = SD_MMC.cardType();
    if(cardType == CARD_NONE)
    {
        Serial.println("No SD Card attached");
        return;                                                                               //A REMETTRE QUAND J'AURAIS LA SD
    }

    Serial.println("Initialisation SD OK");

}

//-------------------------------------------------------------------------------------------------------------------------------

void Cam::capturePhoto()
{
     //PRISE DE PHOTO
     
    fb = NULL;  

    fb = esp_camera_fb_get();  
    if(!fb) 
    {
        Serial.println("Camera capture failed");
        return;
    }

    EEPROM.begin(EEPROM_SIZE);              //initialisation de l'eeprom avec la taille defini de base
    pictureNumber = EEPROM.read(0) + 1;     //numero d'image generer en ajoutant 1
    Serial.println("Prise de Photo OK");

    
}

//-------------------------------------------------------------------------------------------------------------------------------

void Cam::sauvegardeSD()
{
    path = "/picture" + String(pictureNumber) +".jpg";       //creation du chemin vers le fichier où sera contenue les photographies

    //ENREGISTREMENT DES PHOTOS SUR LA SD
    fs::FS &fs = SD_MMC; 
    Serial.printf("Picture file name: %s\n", path.c_str());

    File file = fs.open(path.c_str(), FILE_WRITE);
    if(!file)
    {
        Serial.println("Failed to open file in writing mode");
    } 
    else 
    {
        file.write(fb->buf, fb->len); // payload (image), payload length
        Serial.printf("Saved file to path: %s\n", path.c_str());
        EEPROM.write(0, pictureNumber);
        EEPROM.commit();
    }
    file.close();



    EEPROM.write(0, pictureNumber);   //on garde en memoire flash le numero de la photo prise pour avoir le bon nombre a chaque fois
    EEPROM.commit();

}


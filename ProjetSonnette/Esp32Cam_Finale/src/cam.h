#include "esp_camera.h"
#include "FS.h"                // SD Card ESP32
#include "SD_MMC.h"            // SD Card ESP32
#include "soc/soc.h"           
#include "soc/rtc_cntl_reg.h"  
#include "driver/rtc_io.h"
#include <EEPROM.h>            // lire et ecrire en mémoire flash

#include <iostream>
#include <sstream>
#include <string>

#include <cstdio>




class Cam
{
    public:
        void initCam();
        void initSD();       
        void capturePhoto();
        void sauvegardeSD();

        String declencheur = "Prend une photo";
        int pictureNumber = 0;
        String path;
        const char* nomFichier;

        camera_fb_t * fb;      //verifier que ça ne cause pas de pb en étant mis à null ici


};
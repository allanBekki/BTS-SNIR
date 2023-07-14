#include "ESP32_FTPClient.h"

class MonFtp
{
    public:

    void uploadFile(unsigned char *data, int length, const char *name);

    
    
    const char* ftp_server= "192.168.100.1";
    const char* ftp_user = "pi";
    const char* ftp_pass = "admin";
    const char* ftp_remote_dir = "/files";
    const unsigned short ftp_port = 21;

};
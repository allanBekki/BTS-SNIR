#include "monFtp.h"

void MonFtp::uploadFile(unsigned char *data, int length, const char *name)
{
    ESP32_FTPClient* ftp = new ESP32_FTPClient((char*)ftp_server,ftp_port,(char*)ftp_user,(char*)ftp_pass);

    Serial.print("Uploading via FTP");

    ftp->OpenConnection();

    ftp->InitFile("Type I");
    ftp->ChangeWorkDir(ftp_remote_dir);
    ftp->NewFile(name);
    ftp->WriteData(data,length);
    ftp->CloseFile();

    Serial.print("Uploading Finished");

}
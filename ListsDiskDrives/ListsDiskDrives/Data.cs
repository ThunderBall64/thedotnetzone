using System;
using System.Collections.Generic;
using System.Text;

namespace ListsDiskDrives
{
    class Data
    {
        private string fileName = "n\a";
        private byte fileSize = 0;
        private string fileDetails = "n\a";

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        public byte FileSize
        {
            get { return fileSize; }
            set { fileSize = value; }
        }
        public string FileDetails
        {
            get { return fileDetails; }
            set { fileDetails = value; }
        }

        public override string ToString()
        {
            string message = "";
            message = message + "FileName " + FileName + "\n";
            message = message + "FileSize " + FileSize + "\n";
            message = message + "FileDetails " + FileDetails + "\n";
            return message;
        }
    }
}

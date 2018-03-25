using System;
using System.IO; //Input:Output

// List size of each disk drive
namespace ListsDiskDrives
{
    class Program
    {
        public static void Main()
        {
            FileInfo info = new FileInfo("C:\\");
            FileAttributes attributes = info.Attributes;
            Console.WriteLine("Nature(Attribute) of the File : {0}", attributes);

            Data data = new Data();
            data.FileDetails = "Examine Files";
            data.FileSize = 0;
            data.FileName = "Enter File Name";

            if (data.FileSize > 0)
            {
                Console.WriteLine("File is empty");
            }
            Console.WriteLine("Analyzing File Data...");
            Console.ReadLine();
            

            DriveInfo[] listdiskdrivedetails = DriveInfo.GetDrives();
            foreach (DriveInfo drive in listdiskdrivedetails)
            {
                Console.WriteLine("Drive (0)", drive.Name);
                Console.WriteLine("File type: {0}", drive.DriveType);
                if (drive.IsReady == true)
                {
                    Console.WriteLine("Total size of drive:{0, 15} bytes ", drive.TotalSize);
                    Console.ReadLine();
                }

            }
            // Display the Information of the File and Disk Drive
            // View details in console application
            Console.ReadLine();
        }
    }
}
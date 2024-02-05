using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12
{
    internal class MMEDiskInfo
    {
        private readonly MMELog logger;

        public MMEDiskInfo()
        {
            logger = new MMELog();
        }

        public void GetFreeSpace(string driveName)
        {
            DriveInfo drive = new DriveInfo(driveName);
            Console.WriteLine($"Свободное место на диске {driveName} {drive.AvailableFreeSpace} байтов");

            logger.WriteLog("GetFreeSpace", $"Диск: {driveName} свободно: {drive.AvailableFreeSpace}");
        }

        public void GetFileSystem(string driveName)
        {
            DriveInfo drive = new DriveInfo(driveName);
            Console.WriteLine($"Файловая система {driveName} {drive.DriveFormat}");

            logger.WriteLog("GetFileSystem", $"Диск: {driveName} файлова система:{drive.DriveFormat}");
        }

        public void GetAllDrivesInfo()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Имя диска: {drive.Name}");
                Console.WriteLine($"Общий размер: {drive.TotalSize} байтов");
                Console.WriteLine($"Свободное место: {drive.TotalFreeSpace} байтов");
                Console.WriteLine($"Метка тома: {drive.VolumeLabel}");
                Console.WriteLine();

                logger.WriteLog("GetAllDrivesInfo", $"Диск: {drive.Name}");
            }
        }
    }
}

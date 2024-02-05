using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MMEDiskInfo diskInfo = new MMEDiskInfo();

            diskInfo.GetFreeSpace("D:");

            diskInfo.GetFileSystem("D:");
            Console.WriteLine();

            diskInfo.GetAllDrivesInfo();
            Console.WriteLine();

            string filePath = "D:\\lab\\KYR\\KYRlab2\\1_1.html";

            MMEFileInfo fileInfo = new MMEFileInfo();

            fileInfo.PrintFullPath(filePath);
            fileInfo.PrintFileInfo(filePath);
            Console.WriteLine();

            string directoryPath = "D:\\project";

            MMEDirInfo dirInfo = new MMEDirInfo();

            dirInfo.PrintFilesCount(directoryPath);
            dirInfo.PrintCreationTime(directoryPath);
            Console.WriteLine();

            string diskPath = "D:\\";
            MMEFileManager fileManager = new MMEFileManager(diskPath);
            fileManager.ExecuteActions();
            Console.WriteLine();

            MMELog logger = new MMELog();
            DateTime fromDate = new DateTime(2023, 11, 24, 0, 0, 0);
            DateTime toDate = new DateTime(2023, 11, 24, 23, 59, 59);
            logger.SearchLogByDateTime(fromDate, toDate);
            Console.WriteLine();

            int entryCount = logger.GetLogEntryCount();
            Console.WriteLine($"Количество записей в лог-файле: {entryCount}");
            Console.WriteLine();
        }
    }
}

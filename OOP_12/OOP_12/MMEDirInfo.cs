using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12
{
    internal class MMEDirInfo
    {
        private readonly MMELog logger;

        public MMEDirInfo()
        {
            logger = new MMELog();
        }

        public void PrintFilesCount(string directoryPath)
        {
            try
            {
                string[] files = Directory.GetFiles(directoryPath);
                int fileCount = files.Length;
                Console.WriteLine($"Количество файлов: {fileCount}");

                logger.WriteLog("PrintFilesCount", $"Директория: {directoryPath}, Количество файлов: {fileCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void PrintCreationTime(string directoryPath)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
                DateTime creationTime = directoryInfo.CreationTime;
                Console.WriteLine($"Время создания: {creationTime}");

                logger.WriteLog("PrintCreationTime", $"Директория: {directoryPath}, Время создания: {creationTime}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void PrintSubdirectoriesCount(string directoryPath)
        {
            try
            {
                string[] subdirectories = Directory.GetDirectories(directoryPath);
                int subdirectoryCount = subdirectories.Length;
                Console.WriteLine($"Количество поддиректориев: {subdirectoryCount}");

                logger.WriteLog("PrintSubdirectoriesCount", $"Директория: {directoryPath}, Количество поддиректориев: {subdirectoryCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void PrintParentDirectories(string directoryPath)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
                DirectoryInfo parentDirectory = directoryInfo.Parent;
                while (parentDirectory != null)
                {
                    Console.WriteLine($"Родительская директория: {parentDirectory.Name}");
                    parentDirectory = parentDirectory.Parent;
                }

                logger.WriteLog("PrintParentDirectories", $"Директория: {directoryPath}, {directoryInfo.FullName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}

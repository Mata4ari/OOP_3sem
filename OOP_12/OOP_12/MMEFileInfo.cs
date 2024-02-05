using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12
{
    internal class MMEFileInfo
    {
        private readonly MMELog logger;

        public MMEFileInfo()
        {
            logger = new MMELog();
        }

        public void PrintFullPath(string filePath)
        {
            try
            {
                string fullPath = Path.GetFullPath(filePath);
                Console.WriteLine($"Полный путь файла: {fullPath}");

                logger.WriteLog("PrintFullPath", $"Файл: {filePath}, полный путь {fullPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void PrintFileInfo(string filePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);
                Console.WriteLine($"Имя файла: {fileInfo.Name}");
                Console.WriteLine($"Расширение файла: {fileInfo.Extension}");
                Console.WriteLine($"Размер файла: {fileInfo.Length} байтов");

                logger.WriteLog("PrintFileInfo", $"Файл: {filePath}, {fileInfo.Name}, {fileInfo.Extension}, {fileInfo.Length}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void PrintFileDates(string filePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);
                Console.WriteLine($"Дата создания файла: {fileInfo.CreationTime}");
                Console.WriteLine($"Дата последнего изменения файла: {fileInfo.LastWriteTime}");

                logger.WriteLog("PrintFileDates", $"Файл: {filePath}, дата создания:{fileInfo.CreationTime}, дата изменения:{fileInfo.LastWriteTime}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}

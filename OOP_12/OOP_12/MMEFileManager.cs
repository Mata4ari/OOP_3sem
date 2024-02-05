using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace OOP_12
{
    internal class MMEFileManager
    {
        private string diskPath;
        private readonly MMELog logger;

        public MMEFileManager()
        {
            logger = new MMELog();
        }

        public MMEFileManager(string diskPath)
        {
            this.diskPath = diskPath;
            logger = new MMELog();
        }

        public void ExecuteActions()
        {
            string inspectDirPath = Path.Combine(diskPath, "MMEInspect");
            Directory.CreateDirectory(inspectDirPath);
            logger.WriteLog("ExecuteActions", $"Created directory: {inspectDirPath}");

            string dirInfoFilePath = Path.Combine(inspectDirPath, "MMEdirinfo.txt");
            SaveDirectoryInfoToFile(dirInfoFilePath);
            logger.WriteLog("ExecuteActions", $"Saved directory info to file: {dirInfoFilePath}");

            string copiedFilePath = CopyAndRenameFile(dirInfoFilePath);
            logger.WriteLog("ExecuteActions", $"Copied and renamed file: {dirInfoFilePath} to {copiedFilePath}");

            DeleteFile(dirInfoFilePath);
            logger.WriteLog("ExecuteActions", $"Deleted file: {dirInfoFilePath}");

            string filesDirPath = Path.Combine(diskPath, "MMEfiles");
            Directory.CreateDirectory(filesDirPath);
            logger.WriteLog("ExecuteActions", $"Created directory: {filesDirPath}");

            string extension = GetUserInput("Enter file extension:");
            logger.WriteLog("ExecuteActions", $"User entered file extension: {extension}");
            CopyFilesByExtension(extension, filesDirPath);
            logger.WriteLog("ExecuteActions", $"Copied files with extension: {extension} to directory: {filesDirPath}");

            string archiveFilePath = Path.Combine(inspectDirPath, "MMEfiles.zip");
            CreateArchive(filesDirPath, archiveFilePath);
            logger.WriteLog("ExecuteActions", $"Created archive: {archiveFilePath}");

            string extractionDirPath = Path.Combine(diskPath, "MMEdestination");
            ExtractArchive(archiveFilePath, extractionDirPath);
            logger.WriteLog("ExecuteActions", $"Extracted archive: {archiveFilePath} to directory: {extractionDirPath}");
        }

        private void SaveDirectoryInfoToFile(string filePath)
        {
            string[] directoryContent = Directory.GetFileSystemEntries(diskPath);
            File.WriteAllLines(filePath, directoryContent);
        }

        private string CopyAndRenameFile(string sourceFilePath)
        {
            string destinationFilePath = Path.Combine(diskPath, "MMEdirinfo_copy.txt");
            File.Copy(sourceFilePath, destinationFilePath);
            return destinationFilePath;
        }

        private void DeleteFile(string filePath)
        {
            File.Delete(filePath);
        }

        private void CopyFilesByExtension(string extension, string destinationDirPath)
        {
            string[] files = Directory.GetFiles(diskPath, $"*.{extension}");
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destinationFilePath = Path.Combine(destinationDirPath, fileName);
                File.Copy(file, destinationFilePath);
            }
        }

        private void CreateArchive(string sourceDirPath, string archiveFilePath)
        {
            ZipFile.CreateFromDirectory(sourceDirPath, archiveFilePath);
        }

        private void ExtractArchive(string archiveFilePath, string destinationDirPath)
        {
            ZipFile.ExtractToDirectory(archiveFilePath, destinationDirPath);
        }

        private static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12
{
    public class MMELog
    {
        private const string LogFileName = "MMElogfile.txt";

        public void WriteLog(string action, string detail)
        {
            string logEntry = $"{DateTime.Now} - Действие: {action}, Детали: {detail}";

            try
            {
                using (StreamWriter writer = new StreamWriter(LogFileName, true))
                {
                    writer.WriteLine(logEntry);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка записи в log file: {ex.Message}");
            }
        }

        public void ReadLog()
        {
            try
            {
                using (StreamReader reader = new StreamReader(LogFileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка чтения из log file: {ex.Message}");
            }
        }

        public void SearchLogByKeyword(string searchTerm)
        {
            try
            {
                using (StreamReader reader = new StreamReader(LogFileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(searchTerm))
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка поиска в log file: {ex.Message}");
            }
        }

        public void SearchLogByDateTime(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (StreamReader reader = new StreamReader(LogFileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        DateTime logDateTime;
                        if (TryParseLogDateTime(line, out logDateTime))
                        {
                            if (logDateTime >= fromDate && logDateTime <= toDate)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка поиска в log file: {ex.Message}");
            }
        }

        public int GetLogEntryCount()
        {
            int count = 0;
            try
            {
                using (StreamReader reader = new StreamReader(LogFileName))
                {
                    while (reader.ReadLine() != null)
                    {
                        count++;
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка чтения из log file: {ex.Message}");
            }

            return count;
        }

        private bool TryParseLogDateTime(string logLine, out DateTime logDateTime)
        {
            logDateTime = DateTime.MinValue;
            int index = logLine.IndexOf('-');
            if (index >= 0 && index < logLine.Length - 2)
            {
                string dateTimeString = logLine.Substring(0, index).Trim();
                return DateTime.TryParse(dateTimeString, out logDateTime);
            }
            return false;
        }
    }
}

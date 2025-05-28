using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace miniPro
{
    internal class Logger
    {
        private static string logPath = $"./../../Logs/logs {DateTime.Today:yyyy-MM-dd}.txt";
        public static void writeLog(string message)
        {
            File.AppendAllText(logPath,message+"\n");
        }
        public static void printDayLogsToConsole()
        {
            if(File.Exists(logPath))
                Console.WriteLine(File.ReadAllText(logPath));
        }
    }
}

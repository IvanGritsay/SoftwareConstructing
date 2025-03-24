using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryAdapter;

namespace ConsoleAppAdapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Logger consoleLogger = new Logger();
            FileWriter fileWriter = new FileWriter("log.txt");
            FileLoggerAdapter fileLogger = new FileLoggerAdapter(fileWriter);

            consoleLogger.Log("Це повідомлення журналу");
            consoleLogger.Error("Це помилка");
            consoleLogger.Warn("Це попередження");

            fileLogger.Log("Це повідомлення журналу, записане у файл");
            fileLogger.Error("Це повідомлення про помилку, записане у файл");
            fileLogger.Warn("Це попередження, записане у файл");
            Console.ReadLine();

        }
    }
}

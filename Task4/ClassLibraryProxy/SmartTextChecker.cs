using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProxy
{
    public class SmartTextChecker : ITextReader
    {
        private ITextReader _realSubject;

        public SmartTextChecker(ITextReader realSubject)
        {
            _realSubject = realSubject;
        }

        public char[][] ReadFile(string filename)
        {
            Console.WriteLine($"Відкриття файлу: {filename}");
            char[][] result = _realSubject.ReadFile(filename);

            if (result != null)
            {
                Console.WriteLine($"Файл {filename} успішно прочитано.");
                Console.WriteLine($"Кількість рядків: {result.Length}");
                int charCount = 0;
                foreach (var line in result)
                {
                    charCount += line.Length;
                }
                Console.WriteLine($"Кількість символів: {charCount}");
                Console.WriteLine($"Закриття файлу: {filename}");
            }
            else
            {
                Console.WriteLine($"Не вдалося прочитати файл: {filename}");
            }

            return result;
        }
    }
}

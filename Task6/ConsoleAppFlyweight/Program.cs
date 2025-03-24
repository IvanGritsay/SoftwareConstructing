using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ClassLibraryComposite;
using ClassLibraryFlyweight;

namespace ConsoleAppFlyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string filePath = "text.txt";
            string outputFilePath = "output.html"; 


            string bookText = File.ReadAllText(filePath);
            string[] lines = bookText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            LightElementFlyWeight factory = new LightElementFlyWeight();
            LightElementNode root = factory.GetElement("div", "block", "double");

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i]; 

                if (string.IsNullOrWhiteSpace(line)) continue; 

                LightElementNode element;

                if (i == 0)
                {
                    element = factory.GetElement("h1", "block", "double", new List<LightNode> { new LightTextNode(line) });
                }
                else if (line.Length < 20)
                {
                    element = factory.GetElement("h2", "block", "double", new List<LightNode> { new LightTextNode(line) });
                }
                else if (line.StartsWith(" "))
                {
                    element = factory.GetElement("blockquote", "block", "double", new List<LightNode> { new LightTextNode(line) });
                }
                else
                {
                    element = factory.GetElement("p", "block", "double", new List<LightNode> { new LightTextNode(line) });
                }

                root.AddChild(element);
            }


            string htmlString = root.OuterHTML();
            long memorySize = Encoding.UTF8.GetByteCount(htmlString);

            File.WriteAllText(outputFilePath, htmlString, Encoding.UTF8);
            Console.WriteLine($"Розмір HTML верстки: {memorySize} байт");
            Console.WriteLine($"Результат записано в {outputFilePath}");
        }
    }
}

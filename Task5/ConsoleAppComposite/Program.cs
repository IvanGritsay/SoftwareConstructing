using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryComposite;

namespace ConsoleAppComposite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LightElementNode table = new LightElementNode("table", "block", "double", new List<string> { "my-table" });
            LightElementNode headerRow = new LightElementNode("tr", "block", "double");
            headerRow.AddChild(new LightElementNode("th", "block", "double", children: new List<LightNode> { new LightTextNode("Name") }));
            headerRow.AddChild(new LightElementNode("th", "block", "double", children: new List<LightNode> { new LightTextNode("Age") }));
            table.AddChild(headerRow);

            LightElementNode dataRow = new LightElementNode("tr", "block", "double");
            dataRow.AddChild(new LightElementNode("td", "block", "double", children: new List<LightNode> { new LightTextNode("Ivan") }));
            dataRow.AddChild(new LightElementNode("td", "block", "double", children: new List<LightNode> { new LightTextNode("18") }));
            table.AddChild(dataRow);

            Console.WriteLine(table.OuterHTML());
        }
    }
}

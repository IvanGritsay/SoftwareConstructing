using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public class Character
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; }
        public string Alignment { get; set; }

        public List<string> GoodDeeds { get; set; } = new List<string>();

        public List<string> EvilDeeds { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"Ім'я: {Name}\nЗріст: {Height}\nСтатура: {Build}\nКолір волосся: {HairColor}\nКолір очей: {EyeColor}\nОдяг: {Clothing}\nІнвентар: {string.Join(", ", Inventory)}\nСвітогляд: {Alignment}\nДобрі справи: {string.Join(", ", GoodDeeds)}\nЗлі справи: {string.Join(", ", EvilDeeds)}";
        }
    }
}

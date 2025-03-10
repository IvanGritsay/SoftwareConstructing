using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character character;

        public EnemyBuilder(string name)
        {
            character = new Character { Name = name, Inventory = new List<string>(), Alignment = "Зло" };
        }

        public ICharacterBuilder SetHeight(string height)
        {
            character.Height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            character.Build = build;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            character.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            character.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            character.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder AddItem(string item)
        {
            character.Inventory.Add(item);
            return this;
        }

        public ICharacterBuilder DoEvilDeed(string deed)
        {
            character.EvilDeeds.Add(deed);
            return this;
        }

        public ICharacterBuilder DoGoodDeed(string deed)
        {
            return this; 
        }

        public Character Build()
        {
            return character;
        }
    }


}

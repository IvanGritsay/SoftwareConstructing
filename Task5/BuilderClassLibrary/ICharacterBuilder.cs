using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetHeight(string height);
        ICharacterBuilder SetBuild(string build);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetClothing(string clothing);
        ICharacterBuilder AddItem(string item);
        ICharacterBuilder DoGoodDeed(string deed);   
        ICharacterBuilder DoEvilDeed(string deed);   
        Character Build();
    }

}

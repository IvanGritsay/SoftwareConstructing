using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public class CharacterDirector
    {
        public Character CreateHero(ICharacterBuilder builder)
        {
            return builder.SetHeight("180 см")
                .SetBuild("Спортивна")
                .SetHairColor("Блондин")
                .SetEyeColor("Блакитні")
                .SetClothing("Броня лицаря")
                .AddItem("Меч")
                .AddItem("Щит")
                .DoGoodDeed("Врятував село")
                .DoGoodDeed("Переміг дракона")
                .Build();
        }

        public Character CreateEnemy(EnemyBuilder builder)
        {
            return builder.SetHeight("190 см")
                .SetBuild("Масивна")
                .SetHairColor("Чорний")
                .SetEyeColor("Червоні")
                .SetClothing("Темна броня")
                .AddItem("Сокира")
                .DoEvilDeed("Зруйнував село")
                .DoEvilDeed("Вбив героя")
                .Build();
        }
    }

}

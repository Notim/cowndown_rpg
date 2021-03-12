using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToxinhoCorno.Entities.Enums;

namespace ToxinhoCorno.Entities.HeroClasses
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(
            name,
            new Attribute()
            {
                Level = 3,
                Health = 4096,
                Mana = 100,
                Strong = 100,
                Intelligence = 10,
                Agility = 10,
                Faith = 10,
                Armor = 500,
                DodgeChance = 0.1,
                CriticalChance = 0.1,
                ResistanceMagicDamage = 0.10,
                ResistancePhysicalDamage = 0.10
            },
            new List<Attack>
            {
                new PhysicAttack("Tacar pedra", 50, 1),
                new PhysicAttack("Rasga tripa", 250, 5),
                new PhysicAttack("Ranca Oreia", 150, 2)
            },
            new List<Magic> { },
            new List<Item>
            {
                new Item("Doritos", ItemType.Cure, 2, 200)
            }
         ) {
            ClassName = this.GetType().Name;
            Name = name;
        }
    }
}

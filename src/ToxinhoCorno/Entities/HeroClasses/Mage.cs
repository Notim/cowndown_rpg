using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToxinhoCorno.Entities.Enums;

namespace ToxinhoCorno.Entities.HeroClasses
{
    public class Mage : Hero
    {
        public Mage(string name) : base(
            name,
            new Attribute()
            {
                Level = 5,
                Health = 2048,
                Mana = 2000,
                Strong = 10,
                Intelligence = 100,
                Agility = 23,
                Faith = 17,
                Armor = 200,
                DodgeChance = 0.15,
                CriticalChance = 0.2,
                ResistanceMagicDamage = 0.30,
                ResistancePhysicalDamage = 0.05
            },
            new List<Attack>
            {
                new PhysicAttack("Socão na napa", 20, 1),
                new MagicAttack("Hadouken 2x aumentado", 100, 2),
                new MagicAttack("Hadouken 10x aumentado", 350, 5)
            },
            new List<Magic> { },
            new List<Item>
            {
                new Item("Alho estragado", ItemType.Damege, 1, 200)
            }
         ) {
            ClassName = this.GetType().Name;
            Name = name;
        }
    }
}

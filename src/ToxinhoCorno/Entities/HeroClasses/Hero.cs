using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ToxinhoCorno.Entities.HeroClasses
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public string ClassName { get; set; }

        public Attribute Attribute { get; set; }

        public List<Attack> AttackList { get; set; }

        public List<Magic> MagicList { get; set; }

        public List<Item> Inventory { get; set; }

        public Hero (
            string name,
            Attribute attribute, 
            List<Attack> attackList, 
            List<Magic> magicList, 
            List<Item> inventory)
        {
            Name = name;
            Attribute = attribute;
            AttackList = attackList;
            MagicList = magicList;
            Inventory = inventory;

        }

        public void ShowAttacks()
        {
            PossibleAttacks().ForEach(attack => {
                Console.WriteLine($"{attack.Name} Lv.{attack.LevelMinimum}");
            });
        }

        protected List<Attack> PossibleAttacks()
        {
            return AttackList
                    .FindAll(attack => attack.LevelMinimum <= Attribute.Level)
                    .OrderBy(attack => attack.LevelMinimum)
                    .ToList();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"\nHero {ClassName}: {Name}\n");
            sb.AppendLine($"Attributes: ");
            sb.AppendLine(Attribute.ToString("\t"));

            sb.AppendLine($"Items: ");

            int count = 1;

            Inventory.ForEach(i =>
            {
                sb.AppendLine(i.ToString($"\t{count} - "));
            });

            sb.AppendLine($"Attacks: ");

            PossibleAttacks().ForEach(a =>
            {
                sb.AppendLine(a.ToString("\t"));
            });

            return sb.ToString();
        }
    }
}
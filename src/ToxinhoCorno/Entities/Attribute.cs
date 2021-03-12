using System.Text;

namespace ToxinhoCorno.Entities.HeroClasses
{
    public class Attribute
    {
        public int Level { get; set; }

        public int Health { get; set; }

        public int Mana { get; set; }

        public int Strong { get; set; }

        public int Faith { get; set; }

        public int Agility { get; set; }

        public int Intelligence { get; set; }

        public int Armor { get; set; }

        public double ResistancePhysicalDamage { get; set; }

        public double ResistanceMagicDamage { get; set; }

        public double DodgeChance { get; set; }

        public double CriticalChance { get; set; }

        public Attribute()
        {

        }

        public override string ToString()
        {
            return this.ToString("");
        }
        public string ToString(string prefix = "")
        {
            StringBuilder sb = new StringBuilder();
          
            sb.AppendLine($"{prefix}Level: {Level}");
            sb.AppendLine($"{prefix}Health Points: {Health}");
            sb.AppendLine($"{prefix}Mana Points: {Mana}");

            return sb.ToString();
        }
    }
}
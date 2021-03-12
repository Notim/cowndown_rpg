using System.Text;
using ToxinhoCorno.Entities.Enums;

namespace ToxinhoCorno {

    public class Item {

        public string Name { get; set; }

        public ItemType Type { get; set; }

        public int Effectiveness { get; set; } = 0;

        public int Quantity { get; set; } = 0;

        public double Armadura { get; set; } = 0;

        public int ChanceEsquiva { get; set; } = 0;

        public int ChanceCritical { get; set; } = 0;

        public int CriticalC { get; set; } = 0;
        
        public int ResistenciaMagica { get; set; } = 0;

        public Item(string name, ItemType type, int quantity, int effectiveness)
        {
            Name = name;
            Type = type;
            Effectiveness = effectiveness;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return this.ToString(""); 
        }

        public string ToString(string prefix = "")
        {
            return $"{prefix}{Name}, Quantity: {Quantity}, Type: {Type.ToString()}, Effectiveness: {Effectiveness}.";
        }
    }
}
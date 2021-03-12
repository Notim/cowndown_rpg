namespace ToxinhoCorno.Entities.HeroClasses
{
    public abstract class Attack
    {
        public string Name { get; set; }

        public int Damage { get; set; }

        public int LevelMinimum { get; set; }

        public Attack(string name, int damage, int levelMinimum)
        {
            Name = name;
            Damage = damage;
            LevelMinimum = levelMinimum;
        }

        public abstract void ExecuteAttack();

        public override string ToString()
        {
            return ToString("");
        }

        public string ToString(string prefix = "")
        {
            return $"{prefix}{Name}, Damage: {Damage}, Lv.{LevelMinimum}.";
        }
    }
}
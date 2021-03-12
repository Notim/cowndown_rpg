using System;
using System.Collections.Generic;
using System.Text;
using ToxinhoCorno.Entities.HeroClasses;

namespace ToxinhoCorno.Entities
{
    public class MagicAttack : Attack
    {
        public MagicAttack(string name, int damage, int levelMinimum) : base(name, damage, levelMinimum) { }

        public override void ExecuteAttack()
        {
        }
    }
}

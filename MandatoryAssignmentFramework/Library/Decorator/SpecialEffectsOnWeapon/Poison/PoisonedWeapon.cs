using MandatoryAssignmentFramework.Library.Decorator.SpecialEffectsOnWeapon.Poison;
using MandatoryAssignmentFramework.Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library.SpecialEffectsOnWeapon
{
    public class PoisonedWeapon : AttackItem
    {

        
        
        private readonly int _poisonDuration;
        private readonly int _poisonDamage;

        
        public PoisonedWeapon(AttackItem attackitem, int poisonDuration, int poisonDamage) : base("Poison Dagger", "A dagger with poisonous effect.", 20, 0, 242, 122, true)
        {

            _poisonDuration = poisonDuration;
            _poisonDamage = poisonDamage;
        }

        public new int Range => base.Range;

        public new int Damage => _poisonDamage;
        public int Duration => _poisonDuration;

        public new string Name => $"Poisoned {base.Name}";

        public new string Description => $"{base.Description}which poisons the target for {_poisonDuration} turns, dealing {_poisonDamage} damage per turn.";
    }
}

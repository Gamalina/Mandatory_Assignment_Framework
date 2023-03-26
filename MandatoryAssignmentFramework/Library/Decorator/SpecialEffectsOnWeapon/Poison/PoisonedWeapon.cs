using MandatoryAssignmentFramework.Library.Decorator.SpecialEffectsOnWeapon.Poison;
using MandatoryAssignmentFramework.Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library.SpecialEffectsOnWeapon
{
    public class PoisonedWeapon : IAttack
    {
        private readonly IAttack _weapon;
        private readonly ICreature _creature;
        private readonly int _poisonDuration;
        private readonly int _poisonDamage;

        public PoisonedWeapon(IAttack weapon, int poisonDuration, int poisonDamage)
        {
            _weapon = weapon;
            _poisonDuration = poisonDuration;
            _poisonDamage = poisonDamage;
        }

        public int Range => _weapon.Range;

        public int Damage => _weapon.Damage + _poisonDamage;
        public int Duration => _poisonDuration;

        public string Name => $"Poisoned {_weapon.Name}";

        public string Description => $"{_weapon.Description}, but also poisons the target for {_poisonDuration} turns, dealing {_poisonDamage} damage per turn.";

        public void Attack(ICreature target)
        {
            _creature.Hit(target);

            // Add poison effect to target
            var poisonEffect = new PoisonEffect(_poisonDuration, _poisonDamage);
            target.Effects.Add(poisonEffect);
        }
    }
}

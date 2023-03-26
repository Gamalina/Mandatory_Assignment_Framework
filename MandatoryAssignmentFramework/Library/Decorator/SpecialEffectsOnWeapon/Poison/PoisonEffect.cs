using MandatoryAssignmentFramework.Library.Decorator.Interface;
using MandatoryAssignmentFramework.Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library.Decorator.SpecialEffectsOnWeapon.Poison
{
    public class PoisonEffect : IEffect
    {
        private int _duration;
        private int _damagePerTurn;

        public PoisonEffect(int duration, int damagePerTurn)
        {
            _duration = duration;
            _damagePerTurn = damagePerTurn;
        }

        public bool IsActive => _duration > 0;

        public void ApplyEffect(ICreature target)
        {
            // Deal damage to target and reduce duration
            target.HitPoints -= _damagePerTurn;
            _duration--;
        }
    }
}

using MandatoryAssignmentFramework.Library.Decorator.SpecialEffectsOnWeapon.Poison;
using MandatoryAssignmentFramework.Library.Interface;
using MandatoryAssignmentFramework.Library.SpecialEffectsOnWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library
{
    /// <summary>
    /// Represents an attack item that can be placed on a creature or in the world as a object 
    /// </summary>
    public class AttackItem : WorldObject, IAttack
    {
        /// <summary>
        /// The range of the attack item.
        /// </summary>
        public int Range { get; }
        /// <summary>
        /// The damage of the attack item.
        /// </summary>
        public int Damage { get; }
        /// <summary>
        /// The name of the attack item.
        /// </summary>
        public new string Name { get; }
        /// <summary>
        /// The description of the attack item.
        /// </summary>
        public new string Description { get; }
        /// <summary>
        /// 
        /// </summary>

        /// <summary>
        /// Initializes a new instance of the AttackItem class with the specified name, description, position, range, and damage.
        /// </summary>
        /// <param name="name">The name of the attack item.</param>
        /// <param name="description">The description of the attack item.</param>
        /// <param name="x">The x-coordinate of the attack item's position.</param>
        /// <param name="y">The y-coordinate of the attack item's position.</param>
        /// <param name="range">The range of the attack item.</param>
        /// <param name="damage">The amount of damage the attack item can cause.</param>
        public AttackItem(string name, string description, int range, int damage) : base(name, description, true, true)
        {
            Range = range;
            Damage = damage;
            Name = name;
            Description = description;
        }

        public void Attack(ICreature target)
        {
            throw new NotImplementedException();
        }
    }

}

using MandatoryAssignmentFramework.Library.Decorator.SpecialEffectsOnWeapon.Poison;
using MandatoryAssignmentFramework.Library.Interface;
using MandatoryAssignmentFramework.Library.SpecialEffectsOnWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MandatoryAssignmentFramework.Library
{
    /// <summary>
    /// Represents an attack item that can be placed on a creature or in the world as a object 
    /// </summary>
    public class AttackItem : WorldObject, IAttack, IPosition
    {
        
        /// <summary>
        /// The range of the attack item.
        /// </summary>
        public new int Range { get; }
        /// <summary>
        /// The damage of the attack item.
        /// </summary>
        public new int Damage { get; }
        public AttackItem Weapon { get; set; }
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
        public bool IsWeapon { get; }

        public bool HasSpecielEffect { get; set; }

        public int x;

        public int y;
        /// <summary>
        /// Initializes a new instance of the AttackItem class with the specified name, description, position, range, and damage.
        /// </summary>
        /// <param name="name">The name of the attack item.</param>
        /// <param name="description">The description of the attack item.</param>
        /// <param name="range">The range of the attack item.</param>
        /// <param name="damage">The amount of damage the attack item can cause.</param>
        public AttackItem(string name, string description, int range, int damage, int x, int y, bool hasspecieleffect) : base(name, description, true, true)
        {
            Range = range;
            Damage = damage;
            Name = name;
            Description = description;
            IsWeapon = true;
            X = x;
            Y = y;
            HasSpecielEffect = hasspecieleffect;
        }
    }

}

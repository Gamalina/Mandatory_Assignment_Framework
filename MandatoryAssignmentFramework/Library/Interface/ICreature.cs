using MandatoryAssignmentFramework.Library.Classes;
using MandatoryAssignmentFramework.Library.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library.Interface
{
    /// <summary>
    /// Interface for creatures in the world.
    /// </summary>
    public interface ICreature
    {
        /// <summary>
        /// The name of the creature.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// The health of the creature.
        /// </summary>
        int HitPoints { get; set; }
        /// <summary>
        /// The attack power of the creature.
        /// </summary>
        int AttackPoints { get; set; }
        /// <summary>
        /// The defensive power of the creature.
        /// </summary>
        int DefensePoints { get; set; }
        /// <summary>
        /// A list of attack items the creature currently have on.
        /// </summary>
        List<IAttack> AttackItems { get; set; }
        /// <summary>
        /// A list of defensive items the creature currently have on.
        /// </summary>
        List<IDefenseItem> DefenseItems { get; set; }

        List<Inventory> inventories { get; set; }
        List<IEffect> Effects { get; set; }
        /// <summary>
        /// The X-coordinate of the creature's position in the world.
        /// </summary>
        int X { get; set; }
        /// <summary>
        /// The Y-coordinate of the creature's position in the world.
        /// </summary>
        int Y { get; set; }
        /// <summary>
        /// Attacks another creature and caluclates the damage.
        /// </summary>
        /// <param name="creature">The creature to attack</param>

        void Hit(ICreature target, Creature creature);
        /// <summary>
        /// Picks up an object from the world.
        /// </summary>
        /// <param name="worldObject">The object to pick up</param>
        void Pick(AttackItem attack);
        /// <summary>
        /// Receives damage from an attack.
        /// </summary>
        /// <param name="damage">The amount of damage receieved</param>
        void ReceiveHit(int damage);

        
    }
}

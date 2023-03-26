using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library.Interface
{
    /// <summary>
    /// Interface for creatures that can defend against attacks.
    /// </summary>
    public interface IDefenseItem
    {
        /// <summary>
        /// Name of Defensive Object
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Description of Defensive Object
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Reduces the damage dealt by an attack based on defense properties of the creature
        /// </summary>
        int ReduceDamage { get; }

        /// <summary>
        /// The amount of defense stats the creature has.
        /// </summary>
        int Defense { get; }
    }
}

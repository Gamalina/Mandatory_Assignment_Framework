using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library.Interface
{
    /// <summary>
    /// Interface for an attack item.
    /// </summary>
    public interface IAttack
    {
        /// <summary>
        /// The amount of damage caused by the attack.
        /// </summary>
        int Damage { get;}

        /// <summary>
        /// The range of the attack.
        /// </summary>
        int Range { get; }

        /// <summary>
        /// The name of the attack item.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// A description of the attack item.
        /// </summary>
        string Description { get; }

        void Attack(ICreature target);
    }
}

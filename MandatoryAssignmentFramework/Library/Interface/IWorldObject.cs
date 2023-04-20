using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library.Interface
{
    public interface IWorldObject : IPosition
    {
        /// <summary>
        /// The name of object
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// The description of object
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// Is the object removable
        /// </summary>
        bool IsRemovable { get; set; }
        /// <summary>
        /// Is the object lootable
        /// </summary>
        bool IsLootable { get; set; }
        /// <summary>
        /// The X coordiante of the object's position in the world.
        /// </summary>
        int X { get; set; }
        /// <summary>
        /// The Y coordiante of the object's position in the world.
        /// </summary>
        int Y { get; set; }

        int Damage { get; set; }

        int Range { get; set; }

    }
}

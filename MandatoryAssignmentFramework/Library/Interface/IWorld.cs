using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library.Interface
{
    /// <summary>
    /// Interface for the world.
    /// </summary>
    public interface IWorld
    {
        /// <summary>
        /// The maximum X-coordinates of the world.
        /// </summary>
        int MaxX { get; set; }
        /// <summary>
        /// The maximum Y-coordinate of the world.
        /// </summary>
        int MaxY { get; set; }
        /// <summary>
        /// A list of creatures in the world.
        /// </summary>
        List<ICreature> Creatures { get; set; }
        /// <summary>
        /// A list of objects in the world.
        /// </summary>
        List<IWorldObject> WorldObjects { get; set; }
        /// <summary>
        /// Adds a creature to the world.
        /// </summary>
        /// <param name="creature">The creature to be added.</param>
        void AddCreature(ICreature creature);
        /// <summary>
        /// Removes a creature from the world.
        /// </summary>
        /// <param name="creature">The creature to be removed</param>
        void RemoveCreature(ICreature creature);
        /// <summary>
        /// Adds an object to the world.
        /// </summary>
        /// <param name="worldObject">The object to be added.</param>
        void AddObject(IWorldObject worldObject);
        /// <summary>
        /// Removes an object from the world
        /// </summary>
        /// <param name="worldObject">The object to be removed.</param>
        void RemoveObject(IWorldObject worldObject);
    }

}

using MandatoryAssignmentFramework.Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library
{
    /// <summary>
    /// Represents an object in the world.
    /// </summary>
    public class WorldObject : IWorldObject, IPosition, IAttack
    {
        /// <summary>
        /// The name of the object.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Description of the object.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The X coordiantes of the object's posistion in the world.
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// The Y coordiantes of the object's posistion in the world.
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Whether or not the object can be removed from the game.
        /// </summary>
        public bool IsRemovable { get; set; }
        /// <summary>
        /// Whether or not the object is lootable.
        /// </summary>
        public bool IsLootable { get; set; }

        public int Damage { get; set; }

        public int Range { get; set; }

        /// <summary>
        /// Initializes a new instance of the WorldObject class.
        /// </summary>
        /// <param name="name">The name of the object.</param>
        /// <param name="x">The X position of the object in the world.</param>
        /// <param name="y">The Y position of the object in the world.</param>
        /// <param name="isRemovable">Whether or not the object can be removed from the game.</param>
        /// <param name="description">A description of the object.</param>
        /// <param name="isLootable">Whether or not the object can be looted.</param>
        public WorldObject(string name, string description, int x, int y, bool isRemovable, bool isLootable)
        {
            Name = name;
            X = x;
            Y = y;
            IsRemovable = isRemovable;
            Description = description;
            IsLootable = isLootable;
        }
        public WorldObject(string name, string description, int x, int y, bool isRemovable, bool isLootable, int damage, int range)
        {
            Name = name;
            Damage = damage;
            Range = range;
            X = x;
            Y = y;
            IsRemovable = isRemovable;
            Description = description;
            IsLootable = isLootable;
        }
        public WorldObject(string name, string description, bool isRemovable, bool isLootable)
        {
            Name = name;
            IsRemovable = isRemovable;
            Description = description;
            IsLootable = isLootable;
        }
        /// <summary>
        /// Trying to get remove object to work...
        /// </summary>
        /// <param name="obj"></param>
        public void Remove(WorldObject obj)
        {
            if(obj.IsRemovable)
            {
                
            }
        }
    }

}

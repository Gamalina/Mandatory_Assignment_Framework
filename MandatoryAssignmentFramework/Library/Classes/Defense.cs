using MandatoryAssignmentFramework.Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library
{
    /// <summary>
    /// Class representing a defense item in the world that can be picked up by creature
    /// </summary>
    public class DefenseItem : WorldObject, IDefenseItem
    {
        /// <summary>
        /// The amount of damage the defense item can reduce.
        /// </summary>
        public int ReduceDamage { get; }
        /// <summary>
        /// The amount of defense the item provides.
        /// </summary>
        public int Defense { get; }
        /// <summary>
        /// The name of the defense item.
        /// </summary>
        public new string Name { get; }
        /// <summary>
        /// The description of the defense item.
        /// </summary>
        public new string Description { get; }

        /// <summary>
        /// Initializes a new instance of the DefenseItem class with the specified name, position, reduceDamage and defense values.
        /// </summary>
        /// <param name="name">The name of the defense item.</param>
        /// <param name="x">The x-coordinate of the position of the defense item in the game world.</param>
        /// <param name="y">The y-coordinate of the position of the defense item in the game world.</param>
        /// <param name="reduceDamage">The amount of damage the defense item can reduce.</param>
        /// <param name="defense">The amount of defense the item provides.</param>
        public DefenseItem(string name, string description, int x, int y, int reduceDamage, int defense) : base(name, description, x, y, true, true)
        {
            Name = name;
            Description = description;
            ReduceDamage = reduceDamage;
            Defense = defense;
        }
    }

}

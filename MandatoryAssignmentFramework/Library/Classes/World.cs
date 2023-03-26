using MandatoryAssignmentFramework.Library.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library
{
    /// <summary>
    /// Represents a world containing creatures and objects in a 2D world.
    /// </summary>
    public class World : IWorld
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<World> _logger;
        private readonly List<ICreature> _creatures;
        private readonly List<IWorldObject> _worldObjects;
        /// <summary>
        /// Gets or sets the maximum X-coordinate of the world.
        /// </summary>
        public int MaxX { get; set; }
        /// <summary>
        /// Gets or sets the maximum Y-coordinate of the world.
        /// </summary>
        public int MaxY { get; set; }
        /// <summary>
        /// Gets or sets a list of creatures in the world.
        /// </summary>
        public List<ICreature> Creatures { get { return _creatures; } set { } }
        /// <summary>
        /// Gets or sets a list of objects in the world.
        /// </summary>
        public List<IWorldObject> WorldObjects { get { return _worldObjects; } set { } }
        /// <summary>
        /// Creates a new instance of the World class with the specified configuration and logger.
        /// </summary>
        /// <param name="configuration">The configuration to use for the world.</param>
        /// <param name="logger">The logger to log for the world.</param>
        public World(IConfiguration configuration, ILogger<World> logger)
        {
            _configuration = configuration;
            _logger = logger;
            _creatures = new List<ICreature>();
            _worldObjects = new List<IWorldObject>();

            // Getting X and Y values from appsettings.json
            MaxX = Convert.ToInt32(_configuration.GetSection("World")["SizeX"]);
            MaxY = Convert.ToInt32(_configuration.GetSection("World")["SizeY"]);
            //MaxX = (int)_configuration.GetType().GetProperty(GetType().Name).GetValue("World:SizeX");
            //MaxY = _configuration.GetValue<int>("World:SizeY");
            
            
            // For testing purpose
            AddCreature(player1);
        }
        /// <summary>
        /// Test Creature 
        /// </summary>
        Creature player1 = new Creature("Player1", 200, 10, 5, 0, 0);

        /// <summary>
        /// Adds a creature to the world.
        /// </summary>
        /// <param name="creature">The creature to add.</param>
        public void AddCreature(ICreature creature)
        {
            _creatures.Add(creature);
            _logger.LogInformation($"Added creature {creature.Name} to world");
        }
        /// <summary>
        /// Removes a creature from the world.
        /// </summary>
        /// <param name="creature">The creature to remove.</param>
        public void RemoveCreature(ICreature creature)
        {
            _creatures.Remove(creature);
            _logger.LogInformation($"Removed creature {creature.Name} from world");
        }
        /// <summary>
        /// Adds an object to the world.
        /// </summary>
        /// <param name="worldObject">The object to add.</param>
        public void AddObject(IWorldObject worldObject)
        {
            _worldObjects.Add(worldObject);
            _logger.LogInformation($"Added world object at ({worldObject.X},{worldObject.Y}) to world");
        }
        /// <summary>
        /// Removes an object from the world.
        /// </summary>
        /// <param name="worldObject">The object to remove.</param>
        public void RemoveObject(IWorldObject worldObject)
        {
            int index = _worldObjects.IndexOf(worldObject);
            _worldObjects.Remove(worldObject);
            _logger.LogInformation($"Removed world object at ({worldObject.X}, {worldObject.Y}) from world");
        }

    }
}

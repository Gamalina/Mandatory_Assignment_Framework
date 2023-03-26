using MandatoryAssignmentFramework.Library.Classes;
using MandatoryAssignmentFramework.Library.Decorator.Interface;
using MandatoryAssignmentFramework.Library.Interface;
using MandatoryAssignmentFramework.Library.SpecialEffectsOnWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library
{
    /// <summary>
    /// Represents a creature in the world.
    /// </summary>
    public class Creature : ICreature
    {
        private List<IPickupObserver> _observers = new List<IPickupObserver>();

        /// <summary>
        /// The name of the creature.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The hitpoints of the creature.
        /// </summary>
        public int HitPoints { get; set; }
        /// <summary>
        /// The attack power of the creature.
        /// </summary>
        public int AttackPoints { get; set; }
        /// <summary>
        /// The defensive power of the creature.
        /// </summary>
        public int DefensePoints { get; set; }
        /// <summary>
        /// The X coordiantes of the creatures posistion in the world.
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// The Y coordiantes of the creatures posistion in the world.
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// The list of attack items currently held by the creature.
        /// </summary>
        public List<IAttack> AttackItems { get; set; }
        /// <summary>
        /// The list of defensive items currently held by the creature.
        /// </summary>
        public List<IDefenseItem> DefenseItems { get; set; }
        public List<Inventory> inventories { get; set; }
        /// <summary>
        /// The list of effects on the creature.
        /// </summary>
        public List<IEffect> Effects { get; set; }


        /// <summary>
        /// Initializes a new instance of the Creature class.
        /// </summary>
        /// <param name="name">The name of the creature.</param>
        /// <param name="health">The starting health of the creature.</param>
        /// <param name="attackPoints">The attack points of the creature.</param>
        /// <param name="defensePoints">The defense points of the creature.</param>
        /// <param name="x">The starting X coordinate of the creatures position in the world.</param>
        /// <param name="y">The starting Y coordinate of the creatures position in the world.</param>
        public Creature(string name, int health, int attackPoints, int defensePoints, int x, int y)
        {
            Name = name;
            HitPoints = health;
            AttackPoints = attackPoints;
            DefensePoints = defensePoints;
            X = x;
            Y = y;
            AttackItems = new List<IAttack>();
            DefenseItems = new List<IDefenseItem>();

            // Testing
            Effects = new List<IEffect>();
            var inventory = new Inventory();
            inventory.Capacity = 20;
            var sword = new AttackItem("Sword", "A Handy Sword", 1, 10);
            inventory.AddItem(sword);
            var poisonSword = new AttackItem("PoisonedWeapon", "A Poisoned Weapon", 1, 10);
            inventory.AddItem(poisonSword);
            
        }

        /// <summary>
        /// Performs an attack on the target.
        /// </summary>
        /// <param name="target">The target of the attack.</param>
        public void Hit(ICreature target)
        {
            // Calculate damage
            int damage = AttackPoints;
            foreach (var attackObject in AttackItems)
            {
                damage += attackObject.Damage;
            }
            

            // Apply damage to target
            target.ReceiveHit(damage);
        }
        /// <summary>
        /// Receives a hit from the attacker.
        /// </summary>
        /// <param name="damage">The amount of damage received.</param>
        public void ReceiveHit(int damage)
        {
            // Calculate damage reduction
            int defense = DefensePoints;
            foreach (var defenseObject in DefenseItems)
            {
                defense += defenseObject.Defense;
            }

            // Apply damage to health
            HitPoints -= Math.Max(damage - defense, 0);
        }
        /// <summary>
        /// Picks of an object in the world and adds it to the lists of objects currently heldt.
        /// </summary>
        /// <param name="worldObject"></param>
        public void Pick(IWorldObject worldObject)
        {
            if (worldObject is IAttack attackObject)
            {
                inventories.Add((Inventory)attackObject);
                NotifyAttackItemPickedUp(attackObject);

            }
            else if (worldObject is IDefenseItem defenseObject)
            {
                inventories.Add((Inventory)defenseObject);
                NotifyDefensiveItemPickedUp(defenseObject);
            }

            // Remove world object from world
            // Needs implementents 
            
        }
        /// <summary>
        /// Notification on picking up Attack item
        /// </summary>
        /// <param name="attackitem">The item that was picked up</param>
        private void NotifyAttackItemPickedUp(IAttack attackitem)
        {
            foreach(var observer in _observers)
            {
                observer.OnAttackItemPicked(attackitem);
            }
        }
        /// <summary>
        /// Notification on picking up Defensive item
        /// </summary>
        /// <param name="defenseitem">The item that was picked up</param>
        private void NotifyDefensiveItemPickedUp(IDefenseItem defenseitem)
        {
            foreach (var observer in _observers)
            {
                observer.OnDefenseItemPicked(defenseitem);
            }
        }
    }
}

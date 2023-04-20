using MandatoryAssignmentFramework.Library.Classes;
using MandatoryAssignmentFramework.Library.Decorator.Interface;
using MandatoryAssignmentFramework.Library.Decorator.SpecialEffectsOnWeapon.Poison;
using MandatoryAssignmentFramework.Library.Interface;
using MandatoryAssignmentFramework.Library.SpecialEffectsOnWeapon;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace MandatoryAssignmentFramework.Library
{
    /// <summary>
    /// Represents a creature in the world.
    /// </summary>
    public class Creature : WorldObject, ICreature
    {
        Creature player;
        private List<IPickupObserver> _observers = new List<IPickupObserver>();
        private List<WorldObject> _items = new List<WorldObject>();
        /// <summary>
        /// The name of the creature.
        /// </summary>
        public new string Name { get; set; }
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
        /// The range of the creatures attacks
        /// </summary>
        public int AttackRange { get; set; }
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
        public List<IAttack> AttackItemsList { get; set; }
        public List<IAttack> AttackItems { get; set; }
        
        /// <summary>
        /// The list of defensive items currently held by the creature.
        /// </summary>
        public List<IDefenseItem> DefenseItems { get; set; }
        public List<Inventory> inventories { get; set; }
        public Inventory Inventory { get; }
        /// <summary>
        /// The list of effects on the creature.
        /// </summary>
        public List<IEffect> Effects { get; set; }
        public bool IsDead { get;  set; }
        public bool weaponEquiped { get; set; }
        public int currentWeaponDamage { get; set; }
        List<IAttack> ICreature.AttackItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EquipedWeaponName { get; set; }

        /// <summary>
        /// Initializes a new instance of the Creature class.
        /// </summary>
        /// <param name="name">The name of the creature.</param>
        /// <param name="health">The starting health of the creature.</param>
        /// <param name="attackPoints">The attack points of the creature.</param>
        /// <param name="defensePoints">The defense points of the creature.</param>
        /// <param name="x">The starting X coordinate of the creatures position in the world.</param>
        /// <param name="y">The starting Y coordinate of the creatures position in the world.</param>
        public Creature(string name, string description, int health, int attackPoints, int defensePoints, bool isDead, int range, bool weaponEqupid, int x, int y) : base(name, description, x, y, true, true)
        {
            Name = name;
            HitPoints = health;
            AttackPoints = attackPoints;
            DefensePoints = defensePoints;
            AttackRange = range;
            IsDead = isDead;
            weaponEquiped = false;
            AttackItems = new List<IAttack>();
            DefenseItems = new List<IDefenseItem>();
            Inventory = new Inventory();
            X = x;
            Y = y;
            Effects = new List<IEffect>();


        }

        /// <summary>
        /// Performs an attack on the target.
        /// </summary>
        /// <param name="target">The target of the attack.</param>
        public void Hit(ICreature target, Creature creature)
        {

            if(weaponEquiped)
            {
                foreach(var item in Inventory.GetItems())
                {
                    if (item is AttackItem attackItem && attackItem.Name == EquipedWeaponName)
                    {
                        if(attackItem is PoisonedWeapon poisonedWeapon)
                        {
                            var poisonEffect = new PoisonEffect(poisonedWeapon.Duration, poisonedWeapon.Damage);
                            Effects.Add(poisonEffect);
                            // You left off here.
                            int damageWithPoisonousWeapon = creature.AttackPoints + attackItem.Damage;
                            currentWeaponDamage = damageWithPoisonousWeapon;
                            target.ReceiveHit(currentWeaponDamage);
                        }
                    }
                   
                }
            }
            // Hit without weapon.
            else
            {
                int damage2 = AttackPoints;
                currentWeaponDamage = damage2;
                target.ReceiveHit(10);
            }

            IEffect lastEffect = Effects.LastOrDefault();

            // Apply the effect to the target
            if (lastEffect != null)
            {
                lastEffect.ApplyEffect(target);
            }

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
            int remainingDamage = Math.Max(damage - defense, 0);
            HitPoints -= remainingDamage;

            // Check if the creature has died
            if (HitPoints <= 0)
            {
                IsDead = true;
            }
        }
        /// <summary>
        /// Picks of an object in the world and adds it to the lists of objects currently heldt.
        /// </summary>
        /// <param name="worldObject"></param>
        public void Pick(AttackItem attack)
        {
           

            var items = _items.Where(item => item.X == player.X && item.Y == player.X);

            foreach (var item in items.ToList())
            {
                if(item is AttackItem attackItem)
                {
                    player.Inventory.AddItem(attackItem);
                    player.AttackItemsList.Add(attackItem);
                    player.weaponEquiped = true;
                    
                    _items.Remove(attackItem);
                    player.NotifyAttackItemPickedUp(attackItem);
                }
                else if(item is DefenseItem defenseItem)
                {
                    player.Inventory.AddItem(defenseItem);
                    _items.Remove(defenseItem);
                    player.NotifyDefensiveItemPickedUp(defenseItem);
                }
            }

        }
        public void EquipWeapon(AttackItem weapon)
        {
            EquipedWeaponName = weapon.Name;
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
        /// <summary>
        /// Moves the creature based on the X and Y Input
        /// </summary>
        /// <param name="xDelta">X input</param>
        /// <param name="yDelta">Y input</param>
        public void Move(int xDelta, int yDelta)
        {
            X += xDelta;
            Y += yDelta;

        }
    }
}

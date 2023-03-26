using MandatoryAssignmentFramework.Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library
{
    public class PickUpObserver : IPickupObserver
    {
        public void OnAttackItemPicked(IAttack attackItem)
        {
            Console.WriteLine($"Attack item {attackItem.Name} picked up!");
        }

        public void OnDefenseItemPicked(IDefenseItem defenseItem)
        {
            Console.WriteLine($"Defensive item {defenseItem.Name} picked up!");
        }
    }
}

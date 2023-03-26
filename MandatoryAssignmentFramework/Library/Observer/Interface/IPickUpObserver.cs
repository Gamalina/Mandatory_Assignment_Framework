using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library.Interface
{
    public interface IPickupObserver
    {
        void OnAttackItemPicked(IAttack attackItem);
        void OnDefenseItemPicked(IDefenseItem defenseItem);
    }
}

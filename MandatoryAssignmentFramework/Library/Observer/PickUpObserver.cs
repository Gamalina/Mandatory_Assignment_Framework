using JetBrains.Annotations;
using MandatoryAssignmentFramework.Library.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandatoryAssignmentFramework.Library
{
    public class PickUpObserver : INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // Couldn't get this to work.
        [NotifyPropertyChangedInvocator]
        protected virtual void Notify([CallerMemberName] string attackItem = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(attackItem));
        }
        public void OnAttackItemPicked(IAttack attackItem)
        {
            Console.WriteLine($"Offensive Item {attackItem.Name} was picked up");
            
        }

        public void OnDefenseItemPicked(IDefenseItem defenseItem)
        {
            Console.WriteLine($"Defensive item {defenseItem.Name} picked up!");
        }

    }
}

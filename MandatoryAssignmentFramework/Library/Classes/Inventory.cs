using MandatoryAssignmentFramework.Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library.Classes
{
    public class Inventory
    {
        private List<IWorldObject> _items = new List<IWorldObject>();
        public int Capacity { get; set; }


        public Inventory()
        {
            _items = new List<IWorldObject>();
            
           Capacity = 5;
        }

        

        public bool AddItem(IWorldObject item)
        {
            if (_items.Count >= Capacity)
            {
                return false;
            }

            _items.Add(item);
            return true;
        }

        public bool RemoveItem(IWorldObject item)
        {
            return _items.Remove(item);
        }

        public IEnumerable<IWorldObject> GetItems()
        {
            return _items;
        }

        public static implicit operator List<object>(Inventory v)
        {
            throw new NotImplementedException();
        }
    }
}

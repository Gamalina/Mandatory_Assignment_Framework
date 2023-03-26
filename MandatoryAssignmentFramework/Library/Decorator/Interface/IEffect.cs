using MandatoryAssignmentFramework.Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentFramework.Library.Decorator.Interface
{
    public interface IEffect
    {
        void ApplyEffect(ICreature target);
    }
}

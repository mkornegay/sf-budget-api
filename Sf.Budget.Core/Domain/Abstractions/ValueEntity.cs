using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sf.Budget.Core.Domain.Abstractions
{
    public abstract class ValueEntity : IValueEntity
    {
        public required string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sf.Budget.Core.Domain.Abstractions
{
    public abstract class Entity
    {
        public DateTimeOffset CreatedDate { get; protected set; }

        public DateTimeOffset ModifiedDate { get; protected set; }

        public string? CreatedBy { get; protected set; }

        public string? ModifiedBy { get; protected set; } = string.Empty;
    }
}

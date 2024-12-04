using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sf.Budget.Core.Domain.Budgets
{
    public class BudgetCategory : Abstractions.DomainEntity
    {
        public string? Name { get; init; }

        public string? Description { get; init; }
    }
}

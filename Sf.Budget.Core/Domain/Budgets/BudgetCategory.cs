using Sf.Budget.Core.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sf.Budget.Core.Domain.Budgets
{
    public class BudgetCategory : ValueEntity
    {
        public string? Description { get; init; }
    }
}

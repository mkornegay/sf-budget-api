using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sf.Budget.Core.Domain.Budgets
{
    public class BudgetLineItem : Abstractions.DomainEntity
    {
        public int? BudgetCategoryId { get; init; }

        public ItemClassification? Classification { get; init; }

    }
}

using Sf.Budget.Core.Domain.Abstractions;

namespace Sf.Budget.Core.Domain.Budgets
{
    public class Budget : DomainEntity, IAggregateRoot
    {
        public DateOnly BudgetDate { get; private set; }

        private readonly List<BudgetLineItem> _budgetLines = [];
        public IReadOnlyCollection<BudgetLineItem> BudgetLines => _budgetLines.AsReadOnly();

        public void AddBudgetLineItem(BudgetLineItem budgetLineItem)
        {
            _budgetLines.Add(budgetLineItem);
        }

        public void UpdateBudgetLineItem(BudgetLineItem budgetLineItem)
        {
            var budgetLine = _budgetLines.FirstOrDefault(b => b.Id == budgetLineItem.Id);
            if (budgetLine != null)
            {
                budgetLine.UpdateBudgetItem(
                    budgetLineItem.BudgetCategory, 
                    budgetLineItem.Classification, 
                    budgetLineItem.TransactionDate, 
                    budgetLineItem.Amount);
            }
        }
    }
}

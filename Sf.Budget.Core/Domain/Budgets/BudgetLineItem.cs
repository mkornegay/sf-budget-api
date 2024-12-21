using Sf.Budget.Core.Domain.Abstractions;

namespace Sf.Budget.Core.Domain.Budgets
{
    public class BudgetLineItem : DomainEntity
    {
        public BudgetCategory? BudgetCategory { get; private set; }

        public ItemClassification? Classification { get; private set; }

        public DateOnly TransactionDate { get; private set; }

        public decimal? Amount { get; private set; }

        public BudgetLineItem(BudgetCategory budgetCategory, ItemClassification itemClassification, DateOnly transactionDate, decimal amount)
        {
            BudgetCategory = budgetCategory;
            Classification = itemClassification;
            TransactionDate = transactionDate;
            Amount = amount;
        }

        public void UpdateBudgetItem(BudgetCategory? budgetCategory, ItemClassification? itemClassification, DateOnly transactionDate, decimal? amount)
        {
            BudgetCategory = budgetCategory;
            Classification = itemClassification;
            TransactionDate = transactionDate;
            Amount = amount;
        }


    }
}

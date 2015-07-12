using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMoney
{
    public class ExpenseManager
    {
        private IRepository _repository;

        public ExpenseManager(IRepository expenseRepository)
        {
            _repository = expenseRepository;
        }

        public bool AddExpense(int amount, string description)
        {
            return _repository.Add(amount, description);
        }

        public IList<ExpenseDetail> GetExpenseHistory()
        {
            return _repository.GetAllExpenses();
        }

        public void Remove(int expenseId)
        {
            _repository.Remove(expenseId);
        }
    }
}

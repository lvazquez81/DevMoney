using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMoney
{
    public class ExpenseHistory
    {
        private List<ExpenseDetail> _registry;

        public string Name { get; private set; }

        public ExpenseHistory(string registryName)
        {
            _registry = new List<ExpenseDetail>();
            this.Name = registryName;
        }
        
        public bool Contains(string expenseTag)
        {
            return (from x in _registry where x.Description.Equals(expenseTag) select x).Count() > 0;
        }

        public ExpenseDetail GetExpense(string expenseTag)
        {
            return (from x in _registry where x.Description.Equals(expenseTag) select x).FirstOrDefault();
        }

        internal bool Add(int amount, string description)
        {
            _registry.Add(new ExpenseDetail
            {
                Amount = amount,
                Description= description
            });
            return true;
        }
    }
}

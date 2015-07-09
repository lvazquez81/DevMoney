using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMoney
{
    public class DevMoney
    {
        private ExpenseHistory _registry;

        public DevMoney(string registryName)
        {
            _registry = new ExpenseHistory(registryName);
        }

        public bool AddExpense(int amount, string description)
        {
            return _registry.Add(amount, description);
        }

        public ExpenseHistory GetHistory()
        {
            return _registry;
        }
    }
}

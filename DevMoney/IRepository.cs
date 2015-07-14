using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMoney
{
    public interface IRepository
    {
        bool Add(decimal amount, string description);
        bool Remove(int id);
        IList<ExpenseDetail> GetAllExpenses();
        IList<ExpenseDetail> FindExpenses(string search);
    }
}

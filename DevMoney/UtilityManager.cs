using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMoney
{
    public class UtilityManager
    {
         private IUtilityRepository _repository;

         public UtilityManager(IUtilityRepository expenseRepository)
        {
            _repository = expenseRepository;
        }

        public bool AddUtility(decimal amount, DateTime dueDate, UtilityInvoice.UtilityType type)
        {
            return _repository.Add(type, amount, dueDate);
        }

        public IList<UtilityInvoice> GetUtilityInvoices()
        {
            return _repository.GetAllUtilities();
        }

        public void Remove(int expenseId)
        {
            _repository.Remove(expenseId);
        }
    }
}

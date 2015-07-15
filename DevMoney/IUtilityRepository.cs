using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMoney
{
    public interface IUtilityRepository
    {
        bool Add(UtilityInvoice.UtilityType type, decimal amount, DateTime dueDate);
        bool Remove(int id);
        IList<UtilityInvoice> GetAllUtilities();
    }
}

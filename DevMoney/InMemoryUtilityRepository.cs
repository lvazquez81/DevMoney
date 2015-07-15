using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMoney
{
    public class InMemoryUtilityRepository : IUtilityRepository
    {
        private static List<UtilityInvoice> _data;
        private static int _newId = 0;

        public InMemoryUtilityRepository()
        {
            if (_data == null)
            {
                _newId = 0;
                this.Data.Add(new UtilityInvoice() { 
                    Id = ++_newId, 
                    Amount = (decimal)5.99, 
                    Type =  UtilityInvoice.UtilityType.Power,
                    InvoiceDate = new DateTime(2015,07,15),
                    DueDate = new DateTime(2015, 07, 22),
                    Paid = false,
                    Overdue = false,
                    UtilityName = "CFE"
                });
            }
        }

        private List<UtilityInvoice> Data
        {
            get
            {
                if (_data == null) _data = new List<UtilityInvoice>();
                return _data;
            }
        }

        public bool Add(UtilityInvoice.UtilityType type, decimal amount, DateTime dueDate)
        {
            this.Data.Add(new UtilityInvoice()
            {
                Id = ++_newId,
                Amount = amount,
                DueDate = dueDate
            });
            return true;
        }

        public bool Remove(int id)
        {
            int index = this.Data.FindIndex(x => x.Id == id);
            if (index >= 0)
            {
                this.Data.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }


        public IList<UtilityInvoice> GetAllUtilities()
        {
            return this.Data;
        }
    }
}

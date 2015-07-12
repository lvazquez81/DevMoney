using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMoney
{
    public class InMemoryRepository : IRepository
    {
        private static List<ExpenseDetail> _data;

        public InMemoryRepository()
        {
            if (_data == null)
            {
                this.Data.Add(new ExpenseDetail() { Id = 1, Amount = (decimal)5.99, Description = "abc" });
            }
        }

        private List<ExpenseDetail> Data
        {
            get
            {
                if (_data == null) _data = new List<ExpenseDetail>();
                return _data;
            }
        }

        public bool Add(decimal amount, string description)
        {
            this.Data.Add(new ExpenseDetail()
            {
                Id = 1,
                Amount = amount,
                Description = description
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


        public IList<ExpenseDetail> GetAllExpenses()
        {
            return this.Data;
        }
    }
}

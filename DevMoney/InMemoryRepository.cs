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
        private static int _newId = 0;

        public InMemoryRepository()
        {
            if (_data == null)
            {
                _newId = 0;
                this.Data.Add(new ExpenseDetail() { Id = ++_newId, Amount = (decimal)5.99, Description = "abc" });
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
                Id = ++_newId,
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


        public IList<ExpenseDetail> FindExpenses(string search)
        {
            var result = from x in this.Data
                         where x.Description.Trim().ToLower().Contains(search.Trim().ToLower())
                         select x;

            return result.ToList();
        }
    }
}

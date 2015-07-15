using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMoney.Tests
{
    [TestFixture]
    public class AsDeveloperTests
    {
        
        
        [Test]
        public void WhenRegisteringMyLunchExpense_BoardShowsHistoryUpdated()
        {
            IExpenseRepository repo = new InMemoryExpenseRepository();
            ExpenseManager x = new ExpenseManager(repo);
            bool result = x.AddExpense(50, "Breakfast");
            Assert.IsTrue(result);

            IList<ExpenseDetail> expenses = x.GetExpenseHistory();

            Assert.IsNotNull(expenses);
        }
    }
}

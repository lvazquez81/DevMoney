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
            DevMoney x = new DevMoney("lvazquez81");
            bool result = x.AddExpense(50, "Breakfast");
            Assert.IsTrue(result);

            ExpenseHistory h = x.GetHistory();

            Assert.IsNotNull(h);
            Assert.IsTrue(h.Contains("Breakfast"));
            Assert.AreEqual(50, h.GetExpense("Breakfast").Expense);
        }
    }
}

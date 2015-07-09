using System;
using TechTalk.SpecFlow;

namespace DevMoney.Tests
{
    [Binding]
    public class DailySpendingSteps
    {
        [Given(@"I have my expense board open")]
        public void GivenIHaveMyExpenseBoardOpen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"i have entered (.*) as my lunch expense")]
        public void WhenIHaveEnteredAsMyLunchExpense(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"i have entered the description as '(.*)'")]
        public void WhenIHaveEnteredTheDescriptionAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"my account should show my expense as '(.*)'")]
        public void ThenMyAccountShouldShowMyExpenseAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

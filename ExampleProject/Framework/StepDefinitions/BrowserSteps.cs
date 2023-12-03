using Aquality.Selenium.Browsers;
using TechTalk.SpecFlow;

namespace ExampleProject.Framework.StepDefinitions
{
    [Binding]
    internal class BrowserSteps
    {
        [When(@"I accept the alert")]
        public void AcceptTheAlert()
        {
            AqualityServices.Browser.HandleAlert(AlertAction.Accept);
        }
    }
}
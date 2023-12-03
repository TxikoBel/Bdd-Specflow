using ExampleProject.Framework.Pages;
using TechTalk.SpecFlow;

namespace ExampleProject.Framework.StepDefinitions
{
    [Binding]
    internal class MainPageSteps
    {
        MainPage mainPage = new();

        [Given(@"I go to '(.*)' on the Main Page")]
        public void GoToOnMainPage(string link)
        {
            mainPage.ClickNavigationLink(link);
        }
    }
}
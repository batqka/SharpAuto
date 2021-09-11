using System;
using TechTalk.SpecFlow;
using SpecFlowProj.Infrastructure;
using SpecFlowProj.Drivers;

namespace SpecFlowProj.Steps
{
    [Binding]
    public class GoogleFeatureSteps
    {

        private readonly GoogleSearchPage googleSearchPage;

        public GoogleFeatureSteps(BrowserDriver WebDriver)
        {
            googleSearchPage = new GoogleSearchPage(WebDriver.Current);
        }


        [Given(@"I open “Google search” page")]
        public void GivenIOpenGoogleSearchPage()
        {
            googleSearchPage.OpenGoogleComPage();
        }
        
        [Given(@"I type ""(.*)"" in the search field")]
        public void GivenITypeInTheSearchField(string p0)
        {
            googleSearchPage.EnterTextInSearchField(p0);
        }
        
        [Given(@"I click “Google Search” button")]
        public void GivenIClickGoogleSearchButton()
        {
            googleSearchPage.ClickSearchButton();
        }
        
        [Then(@"I see “About NNN results” panel")]
        public void ThenISeeAboutNNNResultsPanel()
        {
            googleSearchPage.IsResultStatsExist();
                     
        }
    }
}

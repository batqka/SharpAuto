using System;
using TechTalk.SpecFlow;
using TechnicalAssessment.Infrastructure;

namespace TechnicalAssessment.Defenitions
{
    [Binding]
    public class GoogleFeatureSteps
    {
        private readonly GoogleSearchPage googleSearchPage;

        public GoogleFeatureSteps(BrowserDriver WebDriver)
        {
            googleSearchPage = new GoogleSearchPage(WebDriver.Current);
        }
        
        [Given(@"open ""(.*)"" page")]
        public void GivenOpenPage(string p0)
        {
            googleSearchPage.EnterTextInSearchField(p0);
        }
        
        [Given(@"type ""(.*)"" in the search field")]
        public void GivenTypeInTheSearchField(string p0)
        {

        }
        
        [When(@"I click “Google Search” button")]
        public void WhenIClickGoogleSearchButton()
        {
  
        }
        
        [Then(@"I see “About NNN results” panel")]
        public void ThenISeeAboutNNNResultsPanel()
        {
        }
    }
}

using DaimlerProject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDD_DaimlerDemo
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"the user has entered '(.*)' in the Name field")]
        public void GivenTheUserHasEnteredInTheNameField(string p0)
        {
            ScenarioContext.Current.Add("Name", p0);
        }
        
        [Given(@"the user has not entered Name filed value")]
        public void GivenTheUserHasNotEnteredNameFiledValue()
        {
            ScenarioContext.Current.Add("Name", "");
        }
        
        [When(@"I Validate the field")]
        public void WhenIValidateTheField()
        {
                  Member member = new Member();
            member.Name =(string) ScenarioContext.Current["Name"];
            ScenarioContext.Current.Add("Result", member.Status);

        }
        
        [Then(@"I see a message saying Name is '(.*)'")]
        public void ThenISeeAMessageSayingNameIs(string p0)
        {
            Assert.AreEqual(p0, ScenarioContext.Current["Result"]);
        }
    }
}

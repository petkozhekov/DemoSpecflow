using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowDemo.Pages;
using SpecFlowDemo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Steps
{
	[Binding]
	public sealed class DemoStepsDefinitions
	{

		// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

		private CustomContext _customContext;
		private InputsPage _inputsPage;
		private LinksPage _linksPage;

		public DemoStepsDefinitions(CustomContext customContext)
		{
			_customContext = customContext;
			_inputsPage = new InputsPage();
			_linksPage = new LinksPage();
		}

		#region Given
		[Given(@"I visit '(.*)'")]
		public void VisitSite(string site)
		{
			var driver = BrowserManager.GetInstance().GetDriver();
			driver.Navigate().GoToUrl(site);
		}
		#endregion // Given

		#region When
		[When(@"I type '(.*)' as my user name")]
		public void TypeUserName(string userName)
		{
			_inputsPage.FullName.SendKeys(userName);
		}

		[When(@"I type '(.*)' as my email")]
		public void TypeEmail(string email)
		{
			_inputsPage.UserEmail.SendKeys(email);
		}

		[When(@"I enter '(.*)' as my current address")]
		public void EnterCurrentAddress(string address)
		{
			_inputsPage.CurrentAddress.SendKeys(address);
		}

		[When(@"I put '(.*)' as my permanent address")]
		public void TypePermanentAddress(string address)
		{
			_inputsPage.PermanentAddress.SendKeys(address);
		}

		[When(@"I submit the form")]
		public void SubmitTheForm()
		{
			_inputsPage.SubmitButton.Click();
		}

		[When(@"I click link (.*)")]
		public void ClickLink(string link)
		{
			_linksPage.Links[link].Click();
		}
		#endregion // When

		#region Then
		[Then(@"The output should be")]
		public void VerifyOutput(Table outputTable)
		{
			List<Dictionary<string, string>> expectedOutput = outputTable.ToListOfDictionaries();
			var actualResult = _inputsPage.GetResults();
			foreach (var key in expectedOutput[0].Keys)
			{
				Assert.IsTrue(actualResult.ContainsKey(key), $"The {key} did not render!");
				Assert.AreEqual(expectedOutput[0][key], actualResult[key], $"The value of {key} is not rendered!");
			}
		}

		[Then(@"There should be a response")]
		public void ThenThereShouldBeAResponse()
		{
			WebDriverWait wait = new WebDriverWait(BrowserManager.GetInstance().GetDriver(), TimeSpan.FromSeconds(10));
			wait.Until((d) => { return _linksPage.Response != null; });
		}

		[Then(@"The response code should be (.*)")]
		public void VerifyResponseCode(string responseCode)
		{
			string actualCode = _linksPage.Response.FindElements(By.XPath("b")).ToList()[0].Text;
			Assert.AreEqual(responseCode, actualCode, "The response code is not correct!");
		}

		[Then(@"The response text should be (.*)")]
		public void VerifyResponseText(string responseText)
		{
			string actualText = _linksPage.Response.FindElements(By.XPath("b")).ToList()[1].Text;
			Assert.AreEqual(responseText, actualText, "The response text is not correct!");
		}
		#endregion // Then
	}
}

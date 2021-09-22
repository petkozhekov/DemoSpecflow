using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using SpecFlowDemo.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemo.Pages
{
	public class FormPage
	{
		RemoteWebDriver _driver;

		public FormPage()
		{
			_driver = BrowserManager.GetInstance().GetDriver();
		}

		#region Elements
		public IWebElement FirstName => _driver.FindElement(By.XPath("//input[@id = 'firstName']"));

		public IWebElement LastName => _driver.FindElement(By.XPath("//input[@id = 'lastName']"));

		public IWebElement Email => _driver.FindElement(By.XPath("//input[@id = 'userEmail']"));

		public IWebElement MobileNumber => _driver.FindElement(By.XPath("//input[@id = 'userNumber']"));

		public IWebElement MaleGender => _driver.FindElement(By.XPath("//input[@id = 'gender-radio-1']/following-sibling::label"));

		public IWebElement DateOfBirth => _driver.FindElement(By.XPath("//input[@id = 'dateOfBirthInput']"));

		public IWebElement SubmitButton => _driver.FindElement(By.XPath("//button[@id = 'submit']"));
		#endregion

		#region Methods
		public void SubmitForm()
		{
			((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", SubmitButton);
			SubmitButton.Click();
		}

		public void SetDateOfBirth(string date)
		{
			Actions action = new Actions(_driver);
			action.Click(DateOfBirth).KeyDown(Keys.Control).SendKeys("A").KeyUp(Keys.Control).Build().Perform();
			DateOfBirth.SendKeys(date);
		}
		#endregion // Methods
	}
}

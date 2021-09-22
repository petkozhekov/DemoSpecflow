using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SpecFlowDemo.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SpecFlowDemo.Pages
{
	public class InputsPage
	{
		RemoteWebDriver _driver;
		public InputsPage()
		{
			_driver = BrowserManager.GetInstance().GetDriver();
		}

		#region Elements
		public IWebElement FullName => _driver.FindElement(By.XPath("//input[@id = 'userName']"));

		public IWebElement UserEmail => _driver.FindElement(By.XPath("//input[@id = 'userEmail']"));

		public IWebElement CurrentAddress => _driver.FindElement(By.XPath("//textarea[@id = 'currentAddress']"));

		public IWebElement PermanentAddress => _driver.FindElement(By.XPath("//textarea[@id = 'permanentAddress']"));

		public IWebElement SubmitButton => _driver.FindElement(By.XPath("//button[@id = 'submit']"));

		public IWebElement OutputContainer => _driver.FindElement(By.XPath("//div[@id = 'output']"));
		#endregion //Elements

		#region Methods
		public Dictionary<string, string> GetResults()
		{
			Dictionary<string, string> results = new Dictionary<string, string>();
			ReadOnlyCollection<IWebElement> rawResults = OutputContainer.FindElements(By.XPath("div/p"));

			foreach (var result in rawResults)
			{
				string[] resultText = result.Text.Split(':');
				results.Add(resultText[0].Trim(), resultText[1].Trim());
			}

			return results;
		}
		#endregion //Methods
	}
}

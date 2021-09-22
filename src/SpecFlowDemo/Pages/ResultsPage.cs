using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SpecFlowDemo.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemo.Pages
{
	public class ResultsPage
	{
		RemoteWebDriver _driver;

		public ResultsPage()
		{
			_driver = BrowserManager.GetInstance().GetDriver();
		}

		#region Elements
		public IWebElement Container => _driver.FindElement(By.XPath("//div[@role = 'dialog']"));

		public IWebElement FullName => _driver.FindElement(By.XPath("//div[@role = 'dialog']//table/tbody/tr/td[contains(text(), 'Student Name')]/following-sibling::td"));

		public IWebElement StudentEmail => _driver.FindElement(By.XPath("//div[@role = 'dialog']//table/tbody/tr/td[contains(text(), 'Student Email')]/following-sibling::td"));

		public IWebElement Gender => _driver.FindElement(By.XPath("//div[@role = 'dialog']//table/tbody/tr/td[contains(text(), 'Gender')]/following-sibling::td"));

		public IWebElement Mobile => _driver.FindElement(By.XPath("//div[@role = 'dialog']//table/tbody/tr/td[contains(text(), 'Mobile')]/following-sibling::td"));

		public IWebElement DateOfBirth => _driver.FindElement(By.XPath("//div[@role = 'dialog']//table/tbody/tr/td[contains(text(), 'Date of Birth')]/following-sibling::td"));
		#endregion

		#region Methods
		public void WaitToLoad()
		{
			WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
			wait.Until((d) =>
			{
				return Container != null;
			});
		}
		#endregion // Methods
	}
}

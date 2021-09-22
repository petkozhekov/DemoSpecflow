using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SpecFlowDemo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecFlowDemo.Pages
{
	public class LinksPage
	{
		RemoteWebDriver _driver;
		public LinksPage()
		{
			_driver = BrowserManager.GetInstance().GetDriver();
		}

		public IWebElement LinksContainer => _driver.FindElement(By.XPath("//div[@id = 'linkWrapper']"));

		public IWebElement Response => _driver.FindElement(By.XPath("//p[@id = 'linkResponse']"));

		public Dictionary<string, IWebElement> Links => LinksContainer.FindElements(By.XPath("p//a[@href = 'javascript:void(0)']")).ToDictionary(x => x.Text, x => x);
	}
}
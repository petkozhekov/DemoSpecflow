using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemo.Utils
{
	public class BrowserManager : IDisposable
	{
		private static BrowserManager instance = null;
		private RemoteWebDriver driver = null;

		public static BrowserManager GetInstance()
		{
			if (instance == null)
			{
				instance = new BrowserManager();
			}
			return instance;
		}

		public RemoteWebDriver GetDriver()
		{
			// In case it is already loaded.
			if (driver != null)
			{
				return driver;
			}
			ChromeOptions chromeOptions = new ChromeOptions();
			driver = new ChromeDriver(chromeOptions);
			driver.Manage().Window.Maximize();

			return driver;
		}

		protected ChromeOptions ChromeOptions()
		{
			var chromeOptions = new ChromeOptions();

			chromeOptions.AddArguments("--disable-web-security");
			chromeOptions.AddArguments("--allow-running-insecure-content");
			chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
			chromeOptions.AddUserProfilePreference("download.directory_upgrade", true);
			chromeOptions.AddUserProfilePreference("plugins.plugins_disabled", "Chrome PDF Viewer");
			chromeOptions.AddUserProfilePreference("plugins.always_open_pdf_externally", true);

			return chromeOptions;
		}

		public void Dispose()
		{
			driver = null;
		}
	}
}

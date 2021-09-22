using SpecFlowDemo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Hooks
{
	[Binding]
	public sealed class Hooks
	{
		[BeforeScenario]
		public void BeforeScenario()
		{
			BrowserManager.GetInstance().GetDriver();
		}

		[AfterScenario]
		public void AfterScenario()
		{
			BrowserManager.GetInstance().GetDriver();
		}

		[AfterTestRun]
		public static void AfterTestRun()
		{
			BrowserManager.GetInstance().GetDriver().Quit();
			BrowserManager.GetInstance().Dispose();
		}
	}
}

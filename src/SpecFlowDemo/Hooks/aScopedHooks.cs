using SpecFlowDemo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Hooks
{
	[Binding]
	public sealed class aScopedHooks
	{
		[BeforeScenario("memes")]
		public void BeforeScenario()
		{
			BrowserManager.GetInstance().GetDriver().Navigate().GoToUrl("https://9gag.com/");
			Thread.Sleep(2000);
		}

		[AfterScenario("party")]
		public void AfterScenario()
		{
			BrowserManager.GetInstance().GetDriver().Navigate().GoToUrl("https://www.youtube.com/watch?v=JuM7hObGjWI");
			Thread.Sleep(200000);
		}
	}
}

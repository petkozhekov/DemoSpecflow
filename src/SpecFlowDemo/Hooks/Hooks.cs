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
		private ScenarioContext _scenarioContext;

		public Hooks(ScenarioContext context)
		{
			_scenarioContext = context;
		}

		[BeforeScenario]
		public void BeforeScenario()
		{
		}

		[AfterScenario]
		public void AfterScenario()
		{
			if(_scenarioContext.ScenarioExecutionStatus == ScenarioExecutionStatus.OK)
				_scenarioContext.Add("Did I pass?", "probably");
		}

		[AfterTestRun]
		public static void AfterTestRun()
		{
			BrowserManager.GetInstance().GetDriver().Quit();
			BrowserManager.GetInstance().Dispose();
		}
	}
}

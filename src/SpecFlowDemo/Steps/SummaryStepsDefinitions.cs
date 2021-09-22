using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Steps
{
	[Binding]
	public sealed class SummaryStepsDefinitions
	{
		private readonly ScenarioContext _scenarioContext;

		public SummaryStepsDefinitions(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}
	}
}

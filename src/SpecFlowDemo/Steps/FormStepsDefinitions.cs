using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Steps
{
	[Binding]
	public sealed class FormStepsDefinitions
	{
		private readonly ScenarioContext _scenarioContext;

		public FormStepsDefinitions(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}


	}
}

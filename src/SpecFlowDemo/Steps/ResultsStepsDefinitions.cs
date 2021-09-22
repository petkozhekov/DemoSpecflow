using NUnit.Framework;
using SpecFlowDemo.Pages;
using SpecFlowDemo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Steps
{
	[Binding]
	public sealed class ResultsStepsDefinitions
	{
		private ResultsPage _resultsPage;

		private readonly CustomContext _customContext;

		public ResultsStepsDefinitions(CustomContext scenarioContext)
		{
			_resultsPage = new ResultsPage();
			_customContext = scenarioContext;
		}

		[Then(@"The results should be displayed")]
		public void ResultsShouldBeDisplayed()
		{
			_resultsPage.WaitToLoad();
		}

		[Then(@"Student's full name should be correct")]
		public void VerifyStudentsFullName()
		{
			string fullName = string.Format($"{_customContext.GetValue("firstName")} {_customContext.GetValue("lastName")}");
			Assert.AreEqual(fullName, _resultsPage.FullName.Text);
		}

		[Then(@"Student's email should be correct")]
		public void VerifyStudentsEmail()
		{
			Assert.AreEqual(_customContext.GetValue("email").ToString(), _resultsPage.StudentEmail.Text);
		}

		[Then(@"Student's gender should be correct")]
		public void VerifyStudentsGender()
		{
			Assert.AreEqual(_customContext.GetValue("gender").ToString(), _resultsPage.Gender.Text);
		}

		[Then(@"Student's phone should be correct")]
		public void VerifyStudentsPhone()
		{
			Assert.AreEqual(_customContext.GetValue("phone").ToString(), _resultsPage.Mobile.Text);
		}

		[Then(@"Student's date of birth should be correct")]
		public void VerifyStudentsDateOfBirth()
		{
			DateTime date = (DateTime)_customContext.GetValue("dateOfBirth");

			Assert.AreEqual(date.ToString("dd MMMM,yyyy"), _resultsPage.DateOfBirth.Text);
		}
	}
}

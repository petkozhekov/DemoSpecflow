using OpenQA.Selenium;
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
	public sealed class StudentFormStepsDefinitions
	{
		private FormPage _studentsFormPage;
		private readonly CustomContext _customContext;

		public StudentFormStepsDefinitions(CustomContext scenarioContext)
		{
			_studentsFormPage = new FormPage();
			_customContext = scenarioContext;
		}

		[When(@"I type '(.*)' as student's first name")]
		public void TypeStudentFirstName(string name)
		{
			_customContext.SetValue("firstName", name);
			_studentsFormPage.FirstName.SendKeys(name);
		}

		[When(@"I type '(.*)' as student's last name")]
		public void TypeStudentLastName(string name)
		{
			_customContext.SetValue("lastName", name);
			_studentsFormPage.LastName.SendKeys(name);
		}

		[When(@"I type '(.*)' as student's email")]
		public void TypeStudentsEmail(string email)
		{
			_customContext.SetValue("email", email);
			_studentsFormPage.Email.SendKeys(email);
		}

		[When(@"I select male gender")]
		public void SelectMaleGender()
		{
			_customContext.SetValue("gender", "Male");
			_studentsFormPage.MaleGender.Click();
		}

		[When(@"I type '(.*)' as student's phone")]
		public void TypeStudentsPhone(string phone)
		{
			_customContext.SetValue("phone", phone);
			_studentsFormPage.MobileNumber.SendKeys(phone);
		}

		[When(@"I type '(.*)' as student's date of birth")]
		public void TypeStudentsDateOfBirth(string date)
		{
			_customContext.SetValue("dateOfBirth", DateTime.Parse(date));
			_studentsFormPage.SetDateOfBirth(date);
		}

		[When(@"I submit the student's form")]
		public void SubmitStudentsForm()
		{
			_studentsFormPage.SubmitForm();
		}
	}
}

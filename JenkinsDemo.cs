using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using SeleniumDemo.PageFactoryDemo;
using SeleniumDemo.Extensions;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumDemo
{
    [TestClass]
    public class JenkinsDemo 
    {

        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        //public PageObjectFactory _pageObject;
        //public AddProjectPage _addProjectPage;
        //public UpdateProjectPage _updateProjectPage;


        [TestInitialize]
        public void SetUp()
        {

            this.Driver = new FirefoxDriver();
           // this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
            Driver.Manage().Timeouts().ImplicitlyWait(Config.ImplicitWait);
            
            


                


        //    obj = new PageObjectFactory(this.Driver);
        
        }

        [TestCleanup]
        public void TearDown()
        {
            this.Driver.Quit();
        
        }

        [TestMethod, Priority(1)]
        public void TypeSearch_Test()
        {
           PageObjectFactory obj = new PageObjectFactory(this.Driver);
            obj.Navigate();
            obj.Search("SeleniumDemo");
            obj.ClickOnly();
            AddProjectPage obj2 = new AddProjectPage(this.Driver);
            obj2.AddProject();

            UpdateProjectPage obj3 = new UpdateProjectPage(this.Driver);
            obj3.UpdateProject();
        }


        //[TestMethod, Priority(2)]
        //public void UpdateProject_Test()
        //{
            
        //}


        //[TestMethod, Priority(2)]
        //public void Confirmation_Test()
        //{
        //    obj.Navigate();
        //    var result= obj.ConfirmationNameTitle("SeleniumDemo");
        //    Assert.AreEqual("Project SeleniumDemo", result);
        //}


        //[TestMethod, Priority(3)]
        //public void Description_Test()
        //{

        //    obj.Navigate();
        //    var result = obj.DescriptionTitleValid("SeleniumDemo");
        //    Assert.AreEqual("Hello", result);
        //}

        /*

        [TestMethod]
        public void ProjectDescription_Test()
        {
            PageObjectFactory obj = new PageObjectFactory(this.Driver);
            obj.Navigate();
            var result = obj.ProjectDescriptionInformation();
            Assert.AreEqual("Hello World", result);
        }




        [TestMethod]
        public void ProjectConfirmation_Test()
        {

            PageObjectFactory obj  = new PageObjectFactory(this.Driver);
            obj.Navigate();
            var result=obj.ConfirmationName("SeleniumDemo");
            //Assert.IsNull("SeleniumDemo", result);


        }
     
        */


    }
}

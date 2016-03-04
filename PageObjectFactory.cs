using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace SeleniumDemo.PageFactoryDemo
{
    public class PageObjectFactory 
    {
        //http://automatetheplanet.com/page-object-pattern/
        //https://ci.angularjs.org/
       //9225020240
       private readonly IWebDriver driver;
       private readonly string url = "http://localhost:8080";


       public PageObjectFactory(IWebDriver _driver)
       {
           driver = _driver;
           PageFactory.InitElements(_driver, this);
           
       }


       [FindsBy(How = How.Id, Using = "search-box")]
       public IWebElement SearchBox { get; set; }

       

       [FindsBy(How = How.XPath, Using = ".//*[@id='tasks']/div[1]/a[2]")]
       public IWebElement NewItemLink { get; set; }

       [FindsBy(How = How.XPath, Using = ".//*[@id='name']")]
       public IWebElement ProjectName { get; set; }

       
       [FindsBy(How = How.XPath, Using = ".//*[@id='main-panel']/form/table/tbody/tr[3]/td/input")]
       public IWebElement ProjectSelection { get; set; }

       [FindsBy(How = How.XPath, Using = ".//*[@id='ok-button']")]
       public IWebElement ProjectSaveButton { get; set; }

       [FindsBy(How = How.XPath, Using = ".//*[@id='yui-gen30-button']")]
       public IWebElement ProjectUpdate { get; set; }


       [FindsBy(How = How.XPath, Using = ".//*[@id='main-panel']/form/table/tbody/tr[3]/td[3]/textarea")]
       public IWebElement ProjectDescription { get; set; }

       
       [FindsBy(How = How.XPath, Using = ".//*[@id='description']/div[1]")]
       public IWebElement ProjectDescriptionTitle { get; set; }

       
       [FindsBy(How = How.XPath, Using = ".//*[@id='tasks']/div[6]/a[2]")]
       public IWebElement DeleteProject { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='tasks']/div[7]/a[2]")]
       public IWebElement ConfigureProject { get; set; }


       [FindsBy(How = How.XPath, Using = ".//*[@id='main-panel']/form/table/tbody/tr[1]/td[3]/input")]
        public IWebElement testName { get; set; }



       [FindsBy(How = How.XPath, Using = ".//*[@id='main-panel']/h1")]
       public IWebElement ProjectTitle { get; set; }

       [FindsBy(How = How.Id, Using = "description-link")]
       public IWebElement AddDescriptionLink { get; set; }

       [FindsBy(How = How.XPath, Using = ".//*[@id='description']/form/table/tbody/tr[1]/td[3]/textarea")]
       public IWebElement DescriptionArea { get; set; }


            [FindsBy(How = How.Id, Using = "yui-gen2-button")]
       public IWebElement DescriptionButton { get; set; }




            [FindsBy(How = How.XPath, Using = ".//*[@id='description']/div[1]")]
       public IWebElement DescriptionTitle { get; set; }



       public void Navigate()
       {
           this.driver.Navigate().GoToUrl(url);
       
       }

       public void Search(string value)
       {

           SearchBox.Clear();
           SearchBox.SendKeys(value);
           SearchBox.SendKeys(Keys.Enter);
       
       }

       

       public string ProjectDescriptionInformation()
       {
           NewItemLink.Click();
           ProjectName.SendKeys("Test Project");
           ProjectSelection.Click();
           ProjectSaveButton.Click();
           ProjectDescription.SendKeys("Hello World");
           ProjectUpdate.Click();
           return ProjectDescriptionTitle.Text;
       
       }


       public void ClickOnly()
       {

            NewItemLink.Click();
            ////driver.Url = "http://localhost:8080/view/All/newJob";
            //ProjectName.SendKeys("Test Project");
            //ProjectSelection.Click();
            //ProjectSaveButton.Click();
       
       }


       public string ConfirmationName(string value)
        {
            Search(value);
            ConfigureProject.Click();
            var result = testName.Text;
            return result;
   
        }


       public string ConfirmationNameTitle(string value)
       {
           Search(value);
           var result = ProjectTitle.Text;
           return result;

       }
       public string DescriptionTitleValid(string value)
       {
           Search(value);
           AddDescriptionLink.Click();
           DescriptionArea.Clear();
           DescriptionArea.SendKeys("Hello");
           DescriptionButton.Click();
           return DescriptionTitle.Text;
       
       }



    }
}

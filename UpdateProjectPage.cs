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


namespace SeleniumDemo.PageFactoryDemo
{
   public class UpdateProjectPage 
    {

       private readonly IWebDriver driver;

       public UpdateProjectPage(IWebDriver _driver)
       {
           driver = _driver;
           PageFactory.InitElements(_driver, this);
           
       }




       [FindsBy(How = How.XPath, Using = ".//*[@id='yui-gen30-button']")]
       public IWebElement ProjectUpdate { get; set; }


       [FindsBy(How = How.XPath, Using = ".//*[@id='main-panel']/form/table/tbody/tr[3]/td[3]/textarea")]
       public IWebElement ProjectDescription { get; set; }



       public void UpdateProject()
       {

           ProjectDescription.SendKeys("Hello World");
           ProjectUpdate.Click();
       
       }


    }
}

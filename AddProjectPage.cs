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
using SeleniumDemo.Extensions;


namespace SeleniumDemo.PageFactoryDemo
{
    public class AddProjectPage 
    {
    private readonly IWebDriver driver;
    


    public AddProjectPage(IWebDriver _driver)
       {
           driver = _driver;
           PageFactory.InitElements(_driver, this);
           
       }


    [FindsBy(How = How.XPath, Using = ".//*[@id='name']")]
    public IWebElement ProjectName { get; set; }


    [FindsBy(How = How.XPath, Using = ".//*[@id='main-panel']/form/table/tbody/tr[3]/td/input")]
    public IWebElement ProjectSelection { get; set; }

    [FindsBy(How = How.XPath, Using = ".//*[@id='ok-button']")]
    public IWebElement ProjectSaveButton { get; set; }

    public void AddProject()
    {
       
        ProjectName.SendKeys("Test Project");
        ProjectSelection.Click();
        ProjectSaveButton.Click();


    }


    }
}

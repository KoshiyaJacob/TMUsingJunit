using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TimeAndMaterialUsingJunit.ClassesFolder
{
    public class TimeAndMaterial
    {
        public void Click_TM_and_Create(IWebDriver driver)
        {
            IWebElement clickadministration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            clickadministration.Click();



            IWebElement clickTM = driver.FindElement(By.LinkText("Time & Materials"));
            clickTM.Click();
            Console.WriteLine("User clicked on Time and Materials");

        }
    }
}

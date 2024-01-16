using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TimeAndMaterialUsingJunit.ClassesFolder
{
    public class LoginPage
    {
        public void Login_HomePage_Verification(IWebDriver driver)
        {

            //Entering name, password and click on login
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("Hari");


            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");


            IWebElement clicklogin = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            clicklogin.Click();



            //Verify logged in or nor 

            IWebElement verificationText = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            Assert.That(verificationText.Text.Equals("Hello hari!"), "TurnUp Potal Logged in Successfully");

            //if (verificationText.Text == "Hello hari!")
            //{
            //    Console.WriteLine("TurnUp Potal Logged in Successfully");
            //}

            //else
            //{
            //    Console.WriteLine("User not able to login");
            //}



        }


    }
}

    


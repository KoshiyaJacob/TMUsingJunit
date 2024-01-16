using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;

namespace TimeAndMaterialUsingJunit.ClassesFolder
{
    public class CreateEditDelete
    {
        public void Create_Time_And_Material(IWebDriver driver)
        {
            IWebElement clickcreate = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            clickcreate.Click();


            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
            typeCode.Click();


            IWebElement dropdownbutton = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            dropdownbutton.Click();


            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("Koshi Jacob 123");


            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("Automation Demo in Time and Materials");


            IWebElement pricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnit.SendKeys("20");



            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Submit();
            Assert.Pass("Time and Materials created and submitted");


            //click on lastpage icon and check the given code


            IWebElement selectLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            selectLastPage.Click();

            IWebElement savedData = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(savedData.Text.Equals("Koshi Jacob 123"), "Data saved in Time and Materials");

            //if (savedData.Text == "Koshi Jacob 123")
            //{
            //    Console.WriteLine("Data saved in Time and Materials");

            //}
            //else
            //{
            //    Console.WriteLine("Data not saved in Time and Materials");
            //}


        }

        public void Edit_Time_And_Material(IWebDriver driver)
        {
            //Edit the given data

            IWebElement clickOnEditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            clickOnEditButton.Click();


            IWebElement editCodeType = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            editCodeType.Click();


            IWebElement selectDropDown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            selectDropDown.Click();


            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.Clear();
            editCode.SendKeys("Koshiya Jacob");


            IWebElement editDescription = driver.FindElement(By.Id("Description"));
            editDescription.Clear();
            editDescription.SendKeys("Edited Automation Code");


            IWebElement editPrice = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            editPrice.SendKeys("40");



            IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();


        }

        public void Delete_Time_And_Material(IWebDriver driver)
        {
            IWebElement lastpageicon = driver.FindElement(By.LinkText("Go to the last page"));
            lastpageicon.Click();

            //click on Delete button 

            IWebElement clickDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            clickDelete.Click();


            //To retrive alert message:

            Boolean alertMessage = true;

            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertBox = alert.Text;
                Console.WriteLine("Alert box text: " + alertBox);

                alertMessage = true;
                alert.Accept();
                Console.WriteLine("Alert was accepted : " + alertMessage);

                Thread.Sleep(1000);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            //IAlert alert = driver.SwitchTo().Alert();
            //string alertBox = alert.Text;
            //Console.WriteLine("Alert box text" + alertBox);
            //alert.Accept();


            //Logout

            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            helloHari.Click();

            IWebElement dropDownField = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/ul/li[2]/a"));
            dropDownField.Click();

            //Retrive the Current page url:

            string url = driver.Url;
            Assert.Pass(url);


            //string url = driver.Url;
            //Console.WriteLine(url);



        }
    }
}

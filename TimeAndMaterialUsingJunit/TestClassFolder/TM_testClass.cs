using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TimeAndMaterialUsingJunit.ClassesFolder;
using TimeAndMaterialUsingJunit.Utilities;

namespace TimeAndMaterialUsingJunit.TestClassFolder
{
    [TestFixture]
   
    public class TM_testClass : Commondriver
    {

        
        [SetUp]
        public void Set_Up_TM()
        {
            driver = new ChromeDriver();


            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            LoginPage loginPage_Obj = new LoginPage();
            loginPage_Obj.Login_HomePage_Verification(driver);

            TimeAndMaterial timeAndMaterial_Obj = new TimeAndMaterial();
            timeAndMaterial_Obj.Click_TM_and_Create(driver);

        }

        //test-01
        [Test, Order(1)]
        
        public void Create_TM_Record()
        {
            CreateEditDelete createEditDelete_Obj = new CreateEditDelete();
            createEditDelete_Obj.Create_Time_And_Material(driver);
        }

        //Test-02
        [Test, Order(2)]
        
        public void Edit_Time_Record()
        {
            CreateEditDelete createEditDelete_Obj = new CreateEditDelete();
            createEditDelete_Obj.Edit_Time_And_Material(driver);
        }

        //Test-03

        [Test, Order(3)]
        public void Delete_Time_Record()
        {
            CreateEditDelete createEditDelete_Obj = new CreateEditDelete();
            createEditDelete_Obj.Delete_Time_And_Material(driver);
        }

        [TearDown]
        public void CloseTest()
        {
            driver.Close();


        }
    }
}

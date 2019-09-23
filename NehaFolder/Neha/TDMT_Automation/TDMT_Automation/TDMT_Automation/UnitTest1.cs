using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Data;


namespace TDMT_Automation
{
    [TestClass]

   
    public class UnitTest1 :BaseTest
    {
        [TestInitialize]
        public void Setup()
        {
            SetUp();
        }
        [TestMethod]
        //[DeploymentItem("SampleAutomationProject", "SampleAutomationProject")]
        [DeploymentItem("TestData", "TestData")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData.xml", "DataRefreshEntities", DataAccessMethod.Sequential)]

        public void TestMethod1()
        {
            DataRefreshEntities dataRefreshEntities = new DataRefreshEntities(BaseTest.testContext.DataRow);
            IWebDriver driver = BaseTest.GetDriver();
            driver.Navigate().GoToUrl("http://ausuwestlabmgr2.aus.amer.dell.com/");
            BaseTest.SetWaitTimeout(15);
            var objWfDataRefresh = new WFDataRefresh();
            objWfDataRefresh.MethodDataRefreshGloviaDIT(driver);
           // driver.Quit();
            //driver.Dispose();
        }
    }
}

using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;



namespace TDMT_Automation
{
    public class WFDataRefresh : DataRefreshPage
    {
        private IWebDriver driver = BaseTest.GetDriver();
        DataRefreshEntities dataRefreshEntities = new DataRefreshEntities(BaseTest.testContext.DataRow);
        public void MethodDataRefreshGloviaDIT(IWebDriver driver)
        {
            DataImportExport().Click();
            var obj = Tab_DataCenter();
            Assert.IsTrue(obj.Displayed, "Data Import/Export Exists", "Data Import/Exists Doesnot Exists");
            Tab_DataCenter().Click();
          //  BaseTest.HighLightText(driver, Tab_DataCenter());
            DDl_Application().SelectByText(DataRefreshEntities.application);
            DDl_Region().SelectByText(DataRefreshEntities.region);
            DDl_SrcEnv().SelectByText(DataRefreshEntities.src_env);
            DDl_DestiEnv().SelectByText(DataRefreshEntities.dest_env);
            Txt_ItemSKUOrder().SendKeys(DataRefreshEntities.item);
            DDl_CCN().SelectByText(DataRefreshEntities.ccn);
            BaseTest.TakeScreenshot(driver);
            Btn_DataRefresh().Click();
            BaseTest.SetWaitTimeout(30);
            Thread.Sleep(300000);
            var count = listDiv().Count;
            
        }
    }
}

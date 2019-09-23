
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace TDMT_Automation
{
    public class DataRefreshPage : BasePage
    {
        public By id = By.XPath("//a[@id='dataimpexp']");
        public By dataCenter = By.XPath("//a[contains(text(),'Data Center')]");
        public By dd_Application = By.XPath("//select[@id='ddlApplication']");
        public By dd_Region = By.XPath("//select[@id='ddlRegions']");
        public By dd_ScrEnv = By.XPath("//select[@id='ddlSourceEnv']");
        public By dd_DestiEnv = By.XPath("//select[@id='ddlDestinationEnv']");
        public By text_itemSkuOrder = By.XPath("//textarea[@id='txtItem']");
        public By dd_CCN = By.XPath("//select[@id='ddlCCN']");
        public By btn_DataRefresh = By.XPath("//input[@id='btnDataRefresh']");
        public By btn_Reset = By.XPath("//input[@id='btnReset']");
        public IWebElement DataImportExport()
        {
            return base.GetWebElement(id);
        }
        protected IWebElement Tab_DataCenter()
        {
            return base.GetWebElement(dataCenter);
        }
        protected SelectElement DDl_Application()
        {
            return base.GetSelect(dd_Application);
        }
        protected SelectElement DDl_Region()
        {
            return base.GetSelect(dd_Region);
        }
        protected SelectElement DDl_SrcEnv()
        {
            return base.GetSelect(dd_ScrEnv);
        }
        protected SelectElement DDl_DestiEnv()
        {
            return base.GetSelect(dd_DestiEnv);
        }
        protected IWebElement Txt_ItemSKUOrder()
        {
            return base.GetWebElement(text_itemSkuOrder);
        }
        protected SelectElement DDl_CCN()
        {
            return base.GetSelect(dd_CCN);
        }
        protected IWebElement Btn_DataRefresh()
        {
            return base.GetWebElement(btn_DataRefresh);
        }
        protected IWebElement Btn_Reset()
        {
            return base.GetWebElement(btn_Reset);
        }

        //result div
        public By result_Scenario = By.XPath("//div[@id='divScenarioInfo']");
        protected IWebElement Result()
        {
            return base.GetWebElement(result_Scenario);
        }
        public By list_div = By.XPath("//div[@class='s_results']/ul");
        protected IList<IWebElement> listDiv()
        {
            return base.GetWebElements(list_div);
        }
    }
}

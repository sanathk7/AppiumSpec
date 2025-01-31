using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AppiumSpecFlowProject1.Pages
{
    public class webView
    {
        public webView(AndroidDriver androidDriver)
        {

            PageFactory.InitElements(androidDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text=\"󰖟\"]")]
        private IWebElement webViewButton { get; set; }
        public void webClick()
        {
            webViewButton.Click();
        }
    }
}

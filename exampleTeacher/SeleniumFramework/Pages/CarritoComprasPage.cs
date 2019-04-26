using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    class CarritoComprasPage : BasePage
    {

        RemoteWebDriver _webDriver;
        public CarritoComprasPage()
        {
            _webDriver = base.webDriver;
        }

        public By txt_name_v = By.Id("ZANZEA L-6XL Plus Women Off Shoulder Cocktail Evening Party Short Mini Dress New"); 
        public string verificarnombre()
        {
            waitForLocator(txt_name_v);
            return GetElementText(txt_name_v);
        }

    }
}

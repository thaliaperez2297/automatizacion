using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    class ResultBusquedaPage : BasePage
    {
        RemoteWebDriver _webDriver;
        public ResultBusquedaPage()
        {
            _webDriver = base.webDriver;
        }
        public By mouse_list = By.ClassName("icon-view-grid");
        public By link = By.LinkText("ZANZEA L-6XL Plus Women Off Shoulder Cocktail Evening Party Short Mini Dress New");
        public By link2 = By.LinkText("Women Summer Boho Short Maxi Dress Evening Cocktail Party Beach Dresses Sundress");
        public By list = By.LinkText("List View");
        
        public void mouse_lista()
        {
            MouseOverElement(mouse_list);
        }

        public void cliclista()
        {
            ClickOn(list);
            Thread.Sleep(10000);
        }

        public void clic_link()
        {
            ClickOn(link);
        }
        
        public void clic_link2()
        {
            ClickOn(link2);
        }
    }
}
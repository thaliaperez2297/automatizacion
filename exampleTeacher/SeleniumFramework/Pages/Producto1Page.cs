using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    class Producto1Page : BasePage
    {
        RemoteWebDriver _webDriver;
        public Producto1Page()
        {
            _webDriver = base.webDriver;
        }

        public By combo_color = By.Id("msku-opt-3");
        public By combo_size = By.Id("msku-opt-4");
        public By btn_agregarcarro = By.Id("isCartBtn_btn");
        public By span_namep1 = By.Id("");
        public By combo_size2 = By.Id("msku-opt-43"); 
        public By combo_color2 = By.Id("msku-opt-12");
        public void select_color(string location)
        {
            selectComboboxText(combo_color, location);
        }
        public void select_size(string location)
        {
            selectComboboxText(combo_size, location);
        }

        public void clic_agregar()
        {
            ClickOn(btn_agregarcarro);
        }
        public void verificar_namep1()
        {
           
        }

        public void select_color2(string location)
        {
            selectComboboxText(combo_color2, location);
        }
        public void select_size2(string location)
        {
            selectComboboxText(combo_size2, location);
        }
    }
}

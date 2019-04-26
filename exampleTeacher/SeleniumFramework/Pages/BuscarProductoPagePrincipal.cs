using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    class BuscarProductoPagePrincipal : BasePage
    {
        RemoteWebDriver _webDriver;
        public  BuscarProductoPagePrincipal()
        {
            _webDriver = base.webDriver;}

        public By txt_buscar = By.Id("gh-ac");
        public By btn_buscar = By.Id("gh-btn");
        public By span_wait = By.Id("");

        public void ingresar_busqueda(String producto)
        {
            SendKeysOn(txt_buscar, producto);
        }
        public void clic_buscar()
        {
            ClickOn(btn_buscar);
        }
        public void wait_paginaresult()
        {
            waitForLocator(span_wait);
        }

    }
}

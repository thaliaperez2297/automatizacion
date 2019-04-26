using NUnit.Framework;
using SeleniumFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace SeleniumFramework.StepDefinitions
{
    [Binding]
    public class PracticaSteps
    {
        BuscarProductoPagePrincipal buscarproducto = new BuscarProductoPagePrincipal();
        ResultBusquedaPage resultproducto = new ResultBusquedaPage();
        Producto1Page rproduc1 = new Producto1Page();
        CarritoComprasPage verificar = new CarritoComprasPage();

        [Given(@"ingresa a url ""(.*)""")]
        public void GivenIngresaAUrl(string url)
        {
            buscarproducto.Navigate(url);
        }
        
        [When(@"ingresa busqueda ""(.*)""")]
        public void WhenIngresaBusqueda(string text)
        {
            buscarproducto.ingresar_busqueda(text);
        }
        
        [When(@"clic boton buscar")]
        public void WhenClicBotonBuscar()
        {
            buscarproducto.clic_buscar();
        }
        //

        [When(@"sobrepongo el mouse")]
        public void WhenSobrepongoElMouse()
        {
            resultproducto.mouse_lista();
        }
        [When(@"clic en lista")]
        public void WhenClicEnLista()
        {
            resultproducto.cliclista();
        }

        [When(@"clic producto")]
        public void WhenClicProducto()
        {
            resultproducto.clic_link();
        }
        [When(@"clic en seleccionar color ""(.*)""")]
        public void WhenClicEnSeleccionarColor(string location)
        {
            rproduc1.select_color(location);
        }

        [When(@"clic en seleccionar size ""(.*)""")]
        public void WhenClicEnSeleccionarSize(string location)
        {
            rproduc1.select_size(location);
        }
        [When(@"clic agregar a carrito")]
        public void WhenClicAgregarACarrito()
        {
            rproduc1.clic_agregar();
        }
        [When(@"clic en link del producto")]
        public void WhenClicEnLinkDelProducto()
        {
             resultproducto.clic_link2();
        }
        [When(@"clic en select color ""(.*)""")]
        public void WhenClicEnSelectColor(string location)
        {
            rproduc1.select_color2(location);
        }

        [When(@"clic en select size ""(.*)""")]
        public void WhenClicEnSelectSize(string location)
        {
            rproduc1.select_size2(location);
        }
         
        [Then(@"verificar name(.*) ""(.*)""")]
        public void ThenVerificarName( string resultado)
        {
            Assert.IsTrue(verificar.verificarnombre().Contains(resultado));
        }



    }
}

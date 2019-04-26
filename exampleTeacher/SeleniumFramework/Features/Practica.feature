Feature: Practica 
@Chrome
Scenario: carrito de compras
Given ingresa a url "https://www.ebay.com/"
When ingresa busqueda "DRESS"
And clic boton buscar
And sobrepongo el mouse
And clic en lista
And clic producto
And clic en seleccionar color "Purple"
And clic en seleccionar size "US 6/M"
And clic agregar a carrito 
When ingresa busqueda "DRESS"
And clic boton buscar
And clic en link del producto 
And clic en select color "#6"
And clic en select size "M"
And clic agregar a carrito
Then verificar name "US $12.50"
And verificar name ""







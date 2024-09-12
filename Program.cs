using Practica01.Domain;
using Practica01.Services;

Articulo articulo;
Articulo articulo2;
List<DetalleFactura> detalleFacturas;
FormaPago formaPago;
Factura factura;

FacturaManager facturaManager = new FacturaManager();

articulo = new Articulo(1, "Galleta", 1000);
articulo2 = new Articulo(2, "Alfajor", 1500);

formaPago = new FormaPago(1, "Efectivo");

detalleFacturas = new List<DetalleFactura>();

detalleFacturas.Add(new DetalleFactura(1, articulo, 3));
detalleFacturas.Add(new DetalleFactura(2, articulo2, 2));


factura = new Factura(1, "Pepe", formaPago, detalleFacturas);


if (facturaManager.SaveFactura(factura))
{
    Console.WriteLine("Factura registrada exitosamente!");
}
else
{ 
    Console.WriteLine("Factura no se pudo registrar!");
}


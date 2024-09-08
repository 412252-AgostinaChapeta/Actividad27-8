


using Practica01.Domain;

Articulo articulo;
Articulo articulo2;
List<DetalleFactura> detalleFacturas;
FormaPago formaPago;
Factura factura;

articulo = new Articulo(1, "Papel", 1000);
articulo2 = new Articulo(2, "Papel2", 1002);

formaPago = new FormaPago(1, "Efectivo");


detalleFacturas = new List<DetalleFactura>();

detalleFacturas.Add(new DetalleFactura(1, articulo, 3));
detalleFacturas.Add(new DetalleFactura(2, articulo2, 2));


factura = new Factura(1, "Pepe", formaPago, detalleFacturas);


Console.WriteLine(factura.ToString());


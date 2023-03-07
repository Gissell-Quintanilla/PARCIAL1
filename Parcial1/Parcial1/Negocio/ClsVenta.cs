using Parcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Negocio
{
    internal class ClsVenta
    {
        /*Perfumes*/
        Venta vCoco = new Venta(1, "Coco-chanel", "Perfume de ambarino", 150.00, 100);
        Venta vFlower = new Venta(2, "Flower bomb", "Perfume de flores frescas", 70.00, 50);
        Venta vCarolina = new Venta(3, "Carolina Herrera Good Girl", "Perfume de jasmin", 107.00, 30);

        /*Maquillaje*/
        Venta vBase = new Venta(4, "Base liquida", "Proporciona un acabado natural", 20.00, 100);
        Venta vBrochas = new Venta(5, "Brochas", "Suave textura", 15.00, 200);
        Venta vPolvo = new Venta(1, "Polvo traslucido", "Acabado mate y suave", 10.00, 300);
        public void cobro()
        {
            Console.WriteLine(
                "\n----------Menu----------" +
                "\n1- Maquillaje" +
                "\n2- Perfume" +
                "\n------------------------\n"
                );
            Console.WriteLine("Seleccione una opcion: ");
            String opcion = Console.ReadLine();

            if (opcion.Equals("1"))
            {
                Console.WriteLine(
                "\n----------Menu----------" +
                "\n1- Base liquida" +
                "\n2- Brochas" +
                "\n3- Polvo Translucido" +
                "\n------------------------\n"
                );

                Console.WriteLine("Seleccione un producto: ");
                String opc2 = Console.ReadLine();
                if (opc2 == "1")
                {
                    Console.WriteLine("Cantidad que desea comprar: ");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    vBase.CantidadDeProducto1 = vBase.CantidadDeProducto1 - cantidad;

                    String nombre = vBase.NombreDelProducto1;
                    String descripcion = vBase.DescripcionDelProducto1;
                    Double precioOriginal = vBase.PrecioDelProducto1;
                    Double total = vBase.PrecioDelProducto1 * cantidad;

                    if (total >= 50)
                    {
                        Double precioConDescuento = total - 10;
                        Console.WriteLine(
                            "\nNombre del producto: " + nombre +
                            "\nDescripcion del producto: " + descripcion +
                            "\nPrecio por unidad: " + precioOriginal +
                            "\nPrecio total: " + total +
                            "\nPrecio con descuento: " + precioConDescuento +
                            "\nTotal a pagar:  " + precioConDescuento
                            );
                    }
                    else {
                        Console.WriteLine(
                            "\nNombre del producto: " + nombre +
                            "\nDescripcion del producto: " + descripcion +
                            "\nPrecio por unidad: " + precioOriginal +
                            "\nTotal a pagar:  " + total
                            );

                    }
                }else if (opc2 == "2")
                {
                    Console.WriteLine("Cantidad que desea comprar: ");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    vBrochas.CantidadDeProducto1 = vBrochas.CantidadDeProducto1 - cantidad;

                    String nombre = vBrochas.NombreDelProducto1;
                    String descripcion = vBrochas.DescripcionDelProducto1;
                    Double precioOriginal = vBrochas.PrecioDelProducto1;
                    Double total = vBrochas.PrecioDelProducto1 * cantidad;

                    if (total >= 50)
                    {
                        Double precioConDescuento = total - 10;
                        Console.WriteLine(
                            "\nNombre del producto: " + nombre +
                            "\nDescripcion del producto: " + descripcion +
                            "\nPrecio por unidad: " + precioOriginal +
                            "\nPrecio total: " + total +
                            "\nPrecio con descuento: " + precioConDescuento +
                            "\nTotal a pagar:  " + precioConDescuento
                            );
                    }
                    else
                    {
                        Console.WriteLine(
                            "\nNombre del producto: " + nombre +
                            "\nDescripcion del producto: " + descripcion +
                            "\nPrecio por unidad: " + precioOriginal +
                            "\nTotal a pagar:  " + total
                            );

                    }
                }
                else if (opc2 == "3")
                {
                    Console.WriteLine("Cantidad que desea comprar: ");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    vPolvo.CantidadDeProducto1 = vPolvo.CantidadDeProducto1 - cantidad;

                    String nombre = vPolvo.NombreDelProducto1;
                    String descripcion = vPolvo.DescripcionDelProducto1;
                    Double precioOriginal = vPolvo.PrecioDelProducto1;
                    Double total = vPolvo.PrecioDelProducto1 * cantidad;

                    if (total >= 50)
                    {
                        Double precioConDescuento = total - 10;
                        Console.WriteLine(
                            "\nNombre del producto: " + nombre +
                            "\nDescripcion del producto: " + descripcion +
                            "\nPrecio por unidad: " + precioOriginal +
                            "\nPrecio total: " + total +
                            "\nPrecio con descuento: " + precioConDescuento +
                            "\nTotal a pagar:  " + precioConDescuento
                            );
                    }
                    else
                    {
                        Console.WriteLine(
                            "\nNombre del producto: " + nombre +
                            "\nDescripcion del producto: " + descripcion +
                            "\nPrecio por unidad: " + precioOriginal +
                            "\nTotal a pagar:  " + total
                            );

                    }
                }
            }
            else if (opcion.Equals("2"))
            {
                Console.WriteLine(
                "\n----------Menu----------" +
                "\n1- Coco-chanel" +
                "\n2- Flower bomb" +
                "\n3- Carolina Herrera Good Girl" +
                "\n------------------------\n"
                );

                Console.WriteLine("Seleccione un producto: ");
                String opc3 = Console.ReadLine();

                if (opc3 == "1")
                {
                    Console.WriteLine("Cantidad que desea comprar: ");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    vCoco.CantidadDeProducto1 = vCoco.CantidadDeProducto1 - cantidad;

                    String nombre = vCoco.NombreDelProducto1;
                    String descripcion = vCoco.DescripcionDelProducto1;
                    Double precioOriginal = vCoco.PrecioDelProducto1;
                    Double total = vCoco.PrecioDelProducto1 * cantidad;

                    if (total >= 50)
                    {
                        Double precioConDescuento = total - 10;
                        Console.WriteLine(
                            "\nNombre del producto: " + nombre +
                            "\nDescripcion del producto: " + descripcion +
                            "\nPrecio por unidad: " + precioOriginal +
                            "\nPrecio total: " + total +
                            "\nPrecio con descuento: " + precioConDescuento +
                            "\nTotal a pagar:  " + precioConDescuento
                            );
                    }
                    else
                    {
                        Console.WriteLine(
                            "\nNombre del producto: " + nombre +
                            "\nDescripcion del producto: " + descripcion +
                            "\nPrecio por unidad: " + precioOriginal +
                            "\nTotal a pagar:  " + total
                            );

                    }
                }
                else if (opc3 == "2")
                {
                    Console.WriteLine("Cantidad que desea comprar: ");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    vFlower.CantidadDeProducto1 = vFlower.CantidadDeProducto1 - cantidad;

                    String nombre = vFlower.NombreDelProducto1;
                    String descripcion = vFlower.DescripcionDelProducto1;
                    Double precioOriginal = vFlower.PrecioDelProducto1;
                    Double total = vFlower.PrecioDelProducto1 * cantidad;

                    if (total >= 50)
                    {
                        Double precioConDescuento = total - 10;
                        Console.WriteLine(
                            "\nNombre del producto: " + nombre +
                            "\nDescripcion del producto: " + descripcion +
                            "\nPrecio por unidad: " + precioOriginal +
                            "\nPrecio total: " + total +
                            "\nPrecio con descuento: " + precioConDescuento +
                            "\nTotal a pagar:  " + precioConDescuento
                            );
                    }
                    else
                    {
                        Console.WriteLine(
                            "\nNombre del producto: " + nombre +
                            "\nDescripcion del producto: " + descripcion +
                            "\nPrecio por unidad: " + precioOriginal +
                            "\nTotal a pagar:  " + total
                            );

                    }
                }
                else if (opc3 == "3")
                {
                    Console.WriteLine("Cantidad que desea comprar: ");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    vCarolina.CantidadDeProducto1 = vCarolina.CantidadDeProducto1 - cantidad;

                    String nombre = vCarolina.NombreDelProducto1;
                    String descripcion = vCarolina.DescripcionDelProducto1;
                    Double precioOriginal = vCarolina.PrecioDelProducto1;
                    Double total = vCarolina.PrecioDelProducto1 * cantidad;

                    if (total >= 50)
                    {
                        Double precioConDescuento = total - 10;
                        Console.WriteLine(
                            "\nNombre del producto: " + nombre +
                            "\nDescripcion del producto: " + descripcion +
                            "\nPrecio por unidad: " + precioOriginal +
                            "\nPrecio total: " + total +
                            "\nPrecio con descuento: " + precioConDescuento +
                            "\nTotal a pagar:  " + precioConDescuento
                            );
                    }
                    else
                    {
                        Console.WriteLine(
                            "\nNombre del producto: " + nombre +
                            "\nDescripcion del producto: " + descripcion +
                            "\nPrecio por unidad: " + precioOriginal +
                            "\nTotal a pagar:  " + total
                            );

                    }
                }
            }
            else
            {
                Console.WriteLine("Error, opcion inexistente");
            }
        }
    }
}

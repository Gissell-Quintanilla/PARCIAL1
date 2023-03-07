using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Entidades
{
    public class Venta
    {
        private int IdentificadorDeProducto;
        private String NombreDelProducto;

        private String DescripcionDelProducto;

        private Double PrecioDelProducto;

        private int CantidadDeProducto;

        public Venta()
        {

        }

        public Venta(int identificadorDeProducto, string nombreDelProducto, string descripcionDelProducto, double precioDelProducto, int cantidadDeProducto)
        {
            IdentificadorDeProducto1 = identificadorDeProducto;
            NombreDelProducto1 = nombreDelProducto;
            DescripcionDelProducto1 = descripcionDelProducto;
            PrecioDelProducto1 = precioDelProducto;
            CantidadDeProducto1 = cantidadDeProducto;
        }

        public int IdentificadorDeProducto1 { get => IdentificadorDeProducto; set => IdentificadorDeProducto = value; }
        public string NombreDelProducto1 { get => NombreDelProducto; set => NombreDelProducto = value; }
        public string DescripcionDelProducto1 { get => DescripcionDelProducto; set => DescripcionDelProducto = value; }
        public double PrecioDelProducto1 { get => PrecioDelProducto; set => PrecioDelProducto = value; }
        public int CantidadDeProducto1 { get => CantidadDeProducto; set => CantidadDeProducto = value; }
    }
}

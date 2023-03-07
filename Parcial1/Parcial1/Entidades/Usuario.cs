using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Entidades
{
    public class Usuario
    {
        private String nombre;
        private String contra;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contra { get => contra; set => contra = value; }

        public Usuario() { }

        public Usuario(string nombre, string contra)
        {
            Nombre = nombre;
            Contra = contra;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Negocio
{
    internal class ClsUsuario
    {
        String nombre = "Gisell";
        String contra = "123";

        public Boolean acceso(String nombre, String contra)
        {
            Boolean res = false;

            if (this.nombre.Equals(nombre) && this.contra.Equals(contra))
            {
                res = true;
                Console.WriteLine("Inicio de sesión correcto");
            }
            else
            {
                Console.WriteLine("Usuario o contraseña incorrectos");
            }
            return res;
        }

    }
}

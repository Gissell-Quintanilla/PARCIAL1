
using Parcial1.Entidades;
using Parcial1.Negocio;

Console.WriteLine("Ingrese un usuario: ");
String nombre = Console.ReadLine();

Console.WriteLine("Ingrese una contraseña: ");
String contra = Console.ReadLine();

Usuario usu = new Usuario(nombre, contra);

ClsUsuario cls = new ClsUsuario();
ClsVenta clsv = new ClsVenta(); 

if (cls.acceso(usu.Nombre, usu.Contra))
{
    clsv.cobro();
}
else
{
    Console.WriteLine("Programa finalizado.");
}



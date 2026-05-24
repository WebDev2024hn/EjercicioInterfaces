using EjercicioInterfaces.Clases;
using EjercicioInterfaces.Classes;

namespace EjercicioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefono telefono = new Telefono
            {
                Marca = "Samsung",
                Modelo = "Galaxy S23",
                EstaEncendido = false
            };

            Laptop laptop = new Laptop
            {
                Marca = "Dell",
                Modelo = "XPS 15",
                EstaEncendido = false,
                NivelBateria = 85
            };

            Console.WriteLine("=== ESTADO INICIAL ===\n");

            telefono.MostrarEstado();
            laptop.MostrarEstado();

            Console.WriteLine("=== ENCENDIENDO DISPOSITIVOS ===\n");

            telefono.Encender();
            laptop.Encender();

            Console.WriteLine();

            telefono.MostrarEstado();
            laptop.MostrarEstado();

            Console.WriteLine("=== APAGANDO DISPOSITIVOS ===\n");

            telefono.Apagar();
            laptop.Apagar();

            Console.WriteLine();

            telefono.MostrarEstado();
            laptop.MostrarEstado();
        }
    }
}
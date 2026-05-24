using EjercicioInterfaces.Interfaces;

namespace EjercicioInterfaces.Classes
{
    public class Telefono : IDispositivoElectronico
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool EstaEncendido { get; set; }

        public void Encender()
        {
            EstaEncendido = true;
            Console.WriteLine($"El telefono {Marca} {Modelo} se ha encendido.");
        }

        public void Apagar()
        {
            EstaEncendido = false;
            Console.WriteLine($"El telefono {Marca} {Modelo} se ha apagado.");
        }

        public void MostrarEstado()
        {
            string estado = EstaEncendido ? "Encendido" : "Apagado";

            Console.WriteLine("***** Teléfono *****");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Estado: {estado}");
            Console.WriteLine();
        }
    }
}
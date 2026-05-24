using EjercicioInterfaces.Interfaces;

namespace EjercicioInterfaces.Clases
{
    public class Laptop : IDispositivoElectronico
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool EstaEncendido { get; set; }
        public int NivelBateria { get; set; }

        public void Encender()
        {
            EstaEncendido = true;
            Console.WriteLine($"La laptop {Marca} {Modelo} se ha encendido.");
        }

        public void Apagar()
        {
            EstaEncendido = false;
            Console.WriteLine($"La laptop {Marca} {Modelo} se ha apagado.");
        }

        public void MostrarEstado()
        {
            string estado = EstaEncendido ? "Encendida" : "Apagada";

            Console.WriteLine("----- Laptop -----");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Estado: {estado}");
            Console.WriteLine($"Nivel de batería: {NivelBateria}%");
            Console.WriteLine();
        }
    }
}
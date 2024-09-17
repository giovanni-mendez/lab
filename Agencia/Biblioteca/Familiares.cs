
namespace Biblioteca
{
    public class Familiares : AutoCombustion
    {
        public int CantidadPasajeros { get; set; }

        public Familiares(string NumeroSerieMotor, string Marca, int Año, decimal Precio, int kilometraje, string PaisFabricacion, string Color)
        : base(NumeroSerieMotor, Marca, Año, Precio, kilometraje, PaisFabricacion, Color)
        {
            this.CantidadPasajeros = CantidadPasajeros;

        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"NumeroSerie: {NumeroSerieMotor}Marca: {Marca}, Año: {Año}, Precio: {Precio:C}, Kilometraje: {kilometraje} km");
        }

        public override double CalcularConsumo(double km)
        {
            // Autos compactos consumen 13 km por litro
            return km / 13;
        }

    }
}


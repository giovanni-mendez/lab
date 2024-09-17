
namespace Biblioteca
{
    public class Camionetas : AutoCombustion
    {
        public int CapacidadCarga { get; set; }
        public int CantidadEjes { get; set; }

        public Camionetas(string NumeroSerieMotor, string Marca, int Año, decimal Precio, int kilometraje, string PaisFabricacion, string Color)
        : base(NumeroSerieMotor, Marca, Año, Precio, kilometraje, PaisFabricacion, Color)
        {
            this.CapacidadCarga = CapacidadCarga;
            this.CantidadEjes = CantidadEjes;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"NumeroSerie: {NumeroSerieMotor}Marca: {Marca}, Año: {Año}, Precio: {Precio:C}, Kilometraje: {kilometraje} km");
        }

        public override double CalcularConsumo(double km)
        {
            // Consumo: 10 km por litro
            return km / 10; 
        }
    }
}
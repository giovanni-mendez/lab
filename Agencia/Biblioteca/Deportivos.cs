
namespace Biblioteca
{
    public class Deportivos : AutoElectrico
    {
        public Deportivos(string NumeroSerieMotor, string Marca, int Año, decimal Precio, int kilometraje, string PaisFabricacion, string Color)
        : base(NumeroSerieMotor, Marca, Año, Precio, kilometraje, PaisFabricacion, Color)
        {
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"NumeroSerie: {NumeroSerieMotor}Marca: {Marca}, Año: {Año}, Precio: {Precio:C}, Kilometraje: {kilometraje} km");
        }

        public override double CalcularConsumo(double km)
        {
            // Consumo estimado: 20 kWh por kilómetro
            return km * 20;
        }

    }
}
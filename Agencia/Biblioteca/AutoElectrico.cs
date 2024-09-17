namespace Biblioteca;

public class AutoElectrico : Autos
{
    public double DimensionBateria { get; set; }
    public AutoElectrico(string NumeroSerieMotor, string Marca, int Año, decimal Precio, int kilometraje, string PaisFabricacion, string Color) : base(NumeroSerieMotor, Marca, Año, Precio, kilometraje, PaisFabricacion, Color)
    {
        this.DimensionBateria = DimensionBateria;
    }


    public override double CalcularConsumo(double km)
    {
        // Consumo estimado: 20 kWh por kilómetro
        return km * 20;
    }

    public override string TipoMotor => "Eléctrico";
}
namespace Biblioteca
{
    public class AutoCombustion : Autos
    {
        public double VolumenTanque { get; set; }

        public AutoCombustion(string NumeroSerieMotor, string Marca, int Año, decimal Precio, int kilometraje, string PaisFabricacion, string Color)
        : base(NumeroSerieMotor, Marca, Año, Precio, kilometraje, PaisFabricacion, Color)
        {
            this.VolumenTanque = VolumenTanque;
        }

        public override double CalcularConsumo(double km)
        {
            return km / 13;
        }

        public override string TipoMotor => "Combustión";
    }
}

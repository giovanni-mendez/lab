namespace Biblioteca
{
    public abstract class Autos : IconsumoAuto
    {
        public required string NumeroSerieMotor { get; set; }
        public required string Marca { get; set; }
        public int Año { get; set; }
        public decimal Precio { get; set; }
        public int kilometraje { get; set; }
        public string PaisFabricacion { get; set; }
        public string Color { get; set; }
        public abstract string TipoMotor { get; }

        // Constructor
        public Autos(string NumeroSerieMotor, string Marca, int Año, decimal Precio, int kilometraje, string PaisFabricacion, string Color)
        {
            this.NumeroSerieMotor = NumeroSerieMotor;
            this.Marca = Marca;
            this.Año = Año;
            this.Precio = Precio;
            this.kilometraje = kilometraje;
            this.PaisFabricacion = PaisFabricacion;
            this.Color = Color;
        }

        public abstract double CalcularConsumo(double km);
    }
}

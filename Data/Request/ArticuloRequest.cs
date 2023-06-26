namespace Alquilandome.Data.Request
{
    // Clase ArticuloRequest
    public class ArticuloRequest
    {
        public int Id { get; set; }
        public string Referencia { get; set; } = null!;
        public string Descripción { get; set; } = null!;
        public int Cantidad { get; set; }
        public decimal PrecioAlquiler { get; set; }
    }

}

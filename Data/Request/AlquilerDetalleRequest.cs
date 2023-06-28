using Alquilandome.Data.Response;

namespace Alquilandome.Data.Request
{
    // Clase AlquilerDetalle
    public class AlquilerDetalleRequest
    {
        public int Id { get; set; }
        public int AlquilerId { get; set; }
        public int ArticuloId { get; set; }
        public string? Descripción { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioAlquiler { get; set; }
        public decimal SubTotal => (Cantidad * PrecioAlquiler) * Dias;
        public decimal Dias { get; set; } = totalDays;

        public static AlquilerRequest request { get; set; } = new AlquilerRequest();
        static DateTime startDate = request.Fecha;
        static DateTime endDate = request.FechaDeEntrega;
        static int totalDays = (int)(endDate - startDate).TotalDays;
    }

}

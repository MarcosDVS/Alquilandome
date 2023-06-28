using System.ComponentModel.DataAnnotations.Schema;
using Alquilandome.Data.Request;

namespace Alquilandome.Data.Response
{
    // Clase AlquilerDetalle
    public class AlquilerDetalleResponse
    {
        public int Id { get; set; }
        public int AlquilerId { get; set; }
        public ArticuloResponse Articulo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioAlquiler { get; set; }
        public decimal Dias { get; set; } = totalDays;

        [NotMapped]
        public decimal SubTotal => Cantidad * PrecioAlquiler * Dias;

        public static AlquilerResponse response { get; set; } = new AlquilerResponse();
        static DateTime startDate = response.Fecha;
        static DateTime endDate = response.FechaDeEntrega;
        static int totalDays = (int)(endDate - startDate).TotalDays;

    }

}

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

        [NotMapped]
        public decimal SubTotal => Cantidad * PrecioAlquiler;

    }

}

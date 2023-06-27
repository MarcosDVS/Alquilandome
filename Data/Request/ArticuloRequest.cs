using System.ComponentModel.DataAnnotations;

namespace Alquilandome.Data.Request
{
    // Clase ArticuloRequest
    public class ArticuloRequest
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "La referencia del articulo es obligatoria")]
        public string Referencia { get; set; } = null!;
        [Required(ErrorMessage = "La descripcion del articulo es obligatoria")]
        public string Descripción { get; set; } = null!;
        [Required(ErrorMessage = "La cantidad del articulo es obligatoria")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "El precio de alquiler del articulo es obligatorio")]
        public decimal PrecioAlquiler { get; set; }
    }

}

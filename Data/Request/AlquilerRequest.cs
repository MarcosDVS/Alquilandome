namespace Alquilandome.Data.Request
{
    public class AlquilerRequest
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public virtual ICollection<AlquilerDetalleRequest> Detalles { get; set; } 
        = new List<AlquilerDetalleRequest>();
        public decimal SubTotal => 
        Detalles != null ? 
        Detalles.Sum(d=>d.SubTotal)
        :
        0;
    }
}

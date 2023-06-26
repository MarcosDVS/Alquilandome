namespace Alquilandome.Data.Request;
    public class ClienteRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Cedula { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string? Correo { get; set; }
        public string Sexo { get; set; } = null!;
    }

namespace Alquilandome.Data.Request;
    // Clase Usuario
    public class UsuarioRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Nickname { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Rol { get; set; }
    }



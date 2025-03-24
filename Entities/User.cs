namespace Talent_SV.Entities
{
    public class User
    {

        public string Nombre { get; set; } = string.Empty;


        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Avatar { get; set; } = string.Empty;

        public DateTime FechaRegistro { get; set; }

        public bool Activo { get; set; }
    }
}
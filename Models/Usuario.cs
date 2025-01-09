using System.ComponentModel.DataAnnotations;

namespace MvcWithSQLite.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Email { get; set; }
    }
}


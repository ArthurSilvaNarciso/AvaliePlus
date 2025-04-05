using System.ComponentModel.DataAnnotations;

namespace AvalieMais.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Username { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; } // Senha criptografada

        [Required]
        public string Role { get; set; } // Adiciona a propriedade role
    }
}

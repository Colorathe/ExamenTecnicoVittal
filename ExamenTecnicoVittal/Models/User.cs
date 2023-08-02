using System.ComponentModel.DataAnnotations;

namespace ExamenTecnicoVittal.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
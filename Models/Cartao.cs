using System.ComponentModel.DataAnnotations;

namespace VaiVoaAPI.Models
{
    public class Cartao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int NumeroCartao { get; set; }
    }
}
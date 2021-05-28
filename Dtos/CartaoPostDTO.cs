using System.ComponentModel.DataAnnotations;

namespace VaiVoaAPI.Dtos
{
    public class CartaoPostDTO
    {
        [Required]
        public string Email { get; set; }
    }
}
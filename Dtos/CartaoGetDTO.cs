using System.ComponentModel.DataAnnotations;

namespace VaiVoaAPI.Dtos
{
    public class CartaoGetDTO
    {
        [Required]
        public string Email { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace VaiVoaAPI.Dtos
{
    public class CartaoGetDTO
    {
        public long Id { get; set; }
        public long NumeroCartao { get; set; }
    }
}
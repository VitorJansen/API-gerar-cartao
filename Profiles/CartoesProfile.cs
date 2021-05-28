using AutoMapper;
using VaiVoaAPI.Dtos;
using VaiVoaAPI.Models;

namespace VaiVoaAPI.Profiles
{
    public class CartosProfile : Profile
    {
        public CartosProfile()
        {
            CreateMap<CartaoGetDTO, Cartao>();
            CreateMap<CartaoPostDTO, Cartao>();
        }
    }
}
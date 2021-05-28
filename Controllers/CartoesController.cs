using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VaiVoaAPI.Data;
using VaiVoaAPI.Dtos;
using VaiVoaAPI.Models;

namespace VaiVoaAPI.Controllers
{
    [Route("api/cartoes")]
    [ApiController]
    public class CartoesController : ControllerBase
    {
        private readonly IRepositorio _repositorio;
        private readonly IMapper _mapper;

        public CartoesController(IRepositorio repositorio, IMapper mapper)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }

        [HttpGet("{email}")]
        public ActionResult<IEnumerable<CartaoGetDTO>> ListarCartoes(string email)
        {
            var validacaoEmail = _repositorio.ValidarEmail(email);
            if (validacaoEmail == null)
            {
                return NotFound();
            }

            var itens = _repositorio.ListarCartoes(email);
            return Ok(_mapper.Map<IEnumerable<CartaoGetDTO>>(itens));
        }

        [HttpPost]
        public ActionResult<CartaoGetDTO> CriarNovoCartao(CartaoPostDTO cartaoPostDTO)
        {
            var model = _mapper.Map<Cartao>(cartaoPostDTO);

            Random rnd = new Random();
            string numAleatorio = string.Empty;

            for (int i = 0; i < 16; i++)
            {
                numAleatorio += rnd.Next(0, 9).ToString();
            }

            model.NumeroCartao = long.Parse(numAleatorio);

            _repositorio.CriarNovoCartao(model);
            _repositorio.SaveChanges();

            var cartaoGetDTO = _mapper.Map<CartaoGetDTO>(model);
            return cartaoGetDTO;
        }
    }
}
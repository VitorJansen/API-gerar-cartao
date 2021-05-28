using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VaiVoaAPI.Data;
using VaiVoaAPI.Models;

namespace VaiVoaAPI.Controllers
{
    [Route("api/cartoes")]
    [ApiController]
    public class CartoesController : ControllerBase
    {
        private readonly IRepositorio _repositorio;

        public CartoesController(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet("{email}")]
        public ActionResult<IEnumerable<Cartao>> ListarCartoes(string email)
        {
            var itens = _repositorio.ListarCartoes(email);

            if (itens != null)
                return Ok(itens);
            else
                return NotFound();
        }
    }
}
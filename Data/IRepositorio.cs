using System.Collections.Generic;
using VaiVoaAPI.Models;

namespace VaiVoaAPI.Data
{
    public interface IRepositorio
    {
        bool SaveChanges();
        IEnumerable<Cartao> ListarCartoes(string email);
        Cartao CriarNovoCartao(string email);
    }
}
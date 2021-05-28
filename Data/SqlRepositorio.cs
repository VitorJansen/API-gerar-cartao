using System.Collections.Generic;
using System.Linq;
using VaiVoaAPI.Models;

namespace VaiVoaAPI.Data
{
    public class SqlRepositorio : IRepositorio
    {
        private readonly CartoesContext _context;

        public SqlRepositorio(CartoesContext context)
        {
            _context = context;
        }
        public Cartao CriarNovoCartao(string email)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Cartao> ListarCartoes(string email)
        {
            return _context.Cartoes
                .ToList()
                .Where(e => e.Email == email)
                .OrderBy(i => i.Id);
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}
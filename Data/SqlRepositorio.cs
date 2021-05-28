using System;
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
        public void CriarNovoCartao(Cartao cartao)
        {
            if (cartao == null)
            {
                throw new ArgumentNullException(nameof(cartao));
            }

            _context.Cartoes.Add(cartao);
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
            return (_context.SaveChanges() >= 0);
        }

        public Cartao ValidarEmail(string email)
        {
            return _context.Cartoes.FirstOrDefault(e => e.Email == email);
        }
    }
}
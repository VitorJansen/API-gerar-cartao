using System.Collections.Generic;
using VaiVoaAPI.Models;
using System.Linq;
using System;

namespace VaiVoaAPI.Data
{
    public class MockRepositorio : IRepositorio
    {
        public Cartao CriarNovoCartao(string email)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Cartao> ListarCartoes(string email)
        {
            var dados = new List<Cartao>
            {
                new Cartao{Id = 0, Email="teste@hotmail.com", NumeroCartao=1234123412341234},
                new Cartao{Id = 1, Email="teste@hotmail.com", NumeroCartao=1234123412341234},
                new Cartao{Id = 2, Email="user@gmail.com", NumeroCartao=1234123412341234}
            };

            var cartoes = dados.FindAll(e => e.Email == email);

            return cartoes;
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}
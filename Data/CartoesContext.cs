using Microsoft.EntityFrameworkCore;
using VaiVoaAPI.Models;

namespace VaiVoaAPI.Data
{
    public class CartoesContext : DbContext
    {
        public CartoesContext(DbContextOptions<CartoesContext> opt) : base(opt)
        {

        }

        public DbSet<Cartao> Cartoes { get; set; }
    }
}
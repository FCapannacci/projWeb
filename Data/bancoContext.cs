using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
    public class bancoContext : DbContext
    {
        public bancoContext(DbContextOptions<bancoContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Clientes { get; set; }

    }
}

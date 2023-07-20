using ControleDeContatos.Data;
using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly bancoContext _bancoContext;

        public ClienteRepositorio(bancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }
           public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Clientes.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }
    }
}

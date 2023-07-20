using ControleDeContatos.Models;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace ControleDeContatos.Repositorio
{
    public interface IClienteRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}

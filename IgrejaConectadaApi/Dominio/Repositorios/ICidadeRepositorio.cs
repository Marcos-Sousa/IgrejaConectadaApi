using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public interface ICidadeRepositorio
    {
        Task Cadastrar(Cidade cidade);
        Task Atualizar(Cidade cidade);
        Task Deletar(Guid Id);
        Task<Igreja> BuscarPorId(Guid Id);
        Task<IEnumerable<Cidade>> BuscarTodos(Guid Id);
    }
}

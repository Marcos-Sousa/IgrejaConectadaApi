using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public interface IIgrejaRepositorio
    {
        Task Cadastrar(Igreja igreja);
        Task Atualizar(Igreja igreja);
        Task Deletar(Guid Id);
        Task<Igreja> BuscarPorId(Guid Id);
        Task<IEnumerable<Igreja>> BuscarTodos(Guid Id);
    }
}

using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public interface IEstadoRepositorio
    {
        Task Cadastrar(Estado estado);
        Task Atualizar(Estado estado);
        Task Deletar(Guid Id);
        Task<Igreja> BuscarPorId(Guid Id);
        Task<IEnumerable<Estado>> BuscarTodos(Guid Id);
    }
}

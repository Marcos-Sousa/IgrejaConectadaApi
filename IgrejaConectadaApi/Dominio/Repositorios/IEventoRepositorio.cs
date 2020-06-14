using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public interface IEventoRepositorio
    {
        Task Cadastrar(Evento evento);
        Task Atualizar(Evento evento);
        Task Deletar(Guid Id);
        Task<Igreja> BuscarPorId(Guid Id);
        Task<IEnumerable<Evento>> BuscarTodos(Guid Id);
    }
}

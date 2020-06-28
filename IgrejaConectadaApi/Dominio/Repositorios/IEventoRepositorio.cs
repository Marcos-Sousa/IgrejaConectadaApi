using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public interface IEventoRepositorio
    {
        void Cadastrar(Evento evento);
        void Atualizar(Evento evento);
        void Deletar(Guid Id);
        Task<Evento> BuscarPorId(Guid Id);
        Task<IEnumerable<Evento>> BuscarTodos(Guid Id);
    }
}

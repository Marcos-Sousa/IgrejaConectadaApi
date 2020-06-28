using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public interface IIgrejaRepositorio
    {
        void Cadastrar(Igreja igreja);
        void Atualizar(Igreja igreja);
        void Deletar(Guid Id);
        Task<Igreja> BuscarPorId(Guid Id);
        Task<IEnumerable<Igreja>> BuscarTodos();
    }
}

using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public interface IGrupoRepositorio
    {
        void Cadastrar(Grupo grupo);
        void Atualizar(Grupo grupo);
        void Deletar(Guid Id);
        Task<Grupo> BuscarPorId(Guid Id);
        Task<IEnumerable<Grupo>> BuscarTodos(Guid Id);
    }
}

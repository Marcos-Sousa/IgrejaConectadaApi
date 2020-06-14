using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public  interface IGrupoRepositorio
    {
        Task Cadastrar(Grupo grupo);
        Task Atualizar(Grupo grupo);
        Task Deletar(Guid Id);
        Task<Igreja> BuscarPorId(Guid Id);
        Task<IEnumerable<Grupo>> BuscarTodos(Guid Id);
    }
}

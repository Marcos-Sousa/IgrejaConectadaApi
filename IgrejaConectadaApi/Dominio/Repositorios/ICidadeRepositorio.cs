using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public interface ICidadeRepositorio
    {
        void Cadastrar(Cidade cidade);
        void Atualizar(Cidade cidade);
        void Deletar(Guid Id);
        Task<Cidade> BuscarPorId(Guid Id);
        Task<IEnumerable<Cidade>> BuscarTodos();
    }
}

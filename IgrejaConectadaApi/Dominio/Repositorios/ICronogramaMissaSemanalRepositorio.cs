using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public  interface ICronogramaMissaSemanalRepositorio
    {
        void Cadastrar(CronogramaMissaSemanal cronogramaMissaSemanal);
        void Atualizar(CronogramaMissaSemanal cronogramaMissaSemanal);
        void Deletar(Guid Id);
        Task<Igreja> BuscarPorId(Guid Id);
        Task<IEnumerable<CronogramaMissaSemanal>> BuscarTodos(Guid Id);
    }
}

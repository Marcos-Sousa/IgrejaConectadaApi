using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public  interface ICronogramaMissaSemanalRepositorio
    {
        Task Cadastrar(CronogramaMissaSemanal cronogramaMissaSemanal);
        Task Atualizar(CronogramaMissaSemanal cronogramaMissaSemanal);
        Task Deletar(Guid Id);
        Task<Igreja> BuscarPorId(Guid Id);
        Task<IEnumerable<CronogramaMissaSemanal>> BuscarTodos(Guid Id);
    }
}

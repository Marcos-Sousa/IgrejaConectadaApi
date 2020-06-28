using Dapper;
using Dominio.Entidades;
using Dominio.Repositorios;
using Infra.DbInfra;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public class CronogramaMissaSemanalRepositorio : ICronogramaMissaSemanalRepositorio
    {
        private readonly IDB _db;

        public CronogramaMissaSemanalRepositorio(IDB db)
        {
            _db = db;
        }

        public void Cadastrar(CronogramaMissaSemanal cronogramaMissaSemanal)
        {
            string sql = "INSERT INTO CronogramaMissaSemanal (Id, Id_Igreja, MaterialApoio, Data, Horario_Inicio, Horario_Termino) VALUES " +
                "(@Id, @Id_Igreja, @MaterialApoio, @Data, @Horario_Inicio, @Horario_Termino)";
            using (var db = _db.GetConexao())
            {
                db.Execute(sql, new
                {
                    @Id = cronogramaMissaSemanal.Id,
                    @Id_Igreja = cronogramaMissaSemanal.Id_Igreja,
                    @MaterialApoio = cronogramaMissaSemanal.MaterialApoio,
                    @Data = cronogramaMissaSemanal.Data,
                    @Horario_Inicio = cronogramaMissaSemanal.Horario_Inicio,
                    @Horario_Termino = cronogramaMissaSemanal.Horario_Termino
                });
            }

        }
        public void Atualizar(CronogramaMissaSemanal cronogramaMissaSemanal)
        {
            string sql = "UPDATE CronogramaMissaSemanal SET MaterialApoio = @MaterialApoio, Data = @Data, " +
                "Horario_Inicio = @Horario_Inicio, Horario_Termino = @Horario_Termino WHERE Id = @Id";
            using (var db = _db.GetConexao())
            {
                db.Execute(sql, new
                {
                    @Id = cronogramaMissaSemanal.Id,
                    @MaterialApoio = cronogramaMissaSemanal.MaterialApoio,
                    @Data = cronogramaMissaSemanal.Data,
                    @Horario_Inicio = cronogramaMissaSemanal.Horario_Inicio,
                    @Horario_Termino = cronogramaMissaSemanal.Horario_Termino
                });
            }

        }

        public async Task<Igreja> BuscarPorId(Guid Id)
        {
            var sql = "SELECT * FROM CronogramaMissaSemanal WHERE Id = @Id";
            using (var db = _db.GetConexao())
            {
                return await db.QueryFirstOrDefault(sql, new { Id = Id });
            }
        }

        public async Task<IEnumerable<CronogramaMissaSemanal>> BuscarTodos(Guid Id)
        {
            var sql = "SELECT * FROM CronogramaMissaSemanal";
            using (var db = _db.GetConexao())
            {
                return await db.QueryAsync<CronogramaMissaSemanal>(sql);
            }
        }

        public void Deletar(Guid Id)
        {
            var sql = "DELETE ROM CronogramaMissaSemanal WHERE Id = @Id";
            using (var db = _db.GetConexao())
            {
                db.Execute(sql, new { Id = Id });
            }
        }
    }
}

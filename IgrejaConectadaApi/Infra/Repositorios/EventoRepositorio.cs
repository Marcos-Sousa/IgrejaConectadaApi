using Dapper;
using Dominio.Entidades;
using Dominio.Repositorios;
using Infra.DbInfra;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public class EventoRepositorio : IEventoRepositorio
    {
        private readonly IDB _db;

        public EventoRepositorio(IDB db)
        {
            _db = db;
        }

        public void Cadastrar(Evento evento)
        {
            string sql = "INSERT INTO Evento (Id, Id_igreja, Imagem, Horario_Inicio, Horario_Termino, Data_Inicio, Data_Termino, Descricao) VALUES" +
                "(@Id, @Id_igreja, @Imagem, @Horario_Inicio, @Horario_Termino, @Data_Inicio, @Data_Termino, @Descricao)";
            using (var db = _db.GetConexao())
            {
                db.Execute(sql, new
                {
                    @Id = evento.Id,
                    @Id_igreja = evento.Id_igreja,
                    @Imagem = evento.Imagem,
                    @Horario_Inicio = evento.Horario_Inicio,
                    @Horario_Termino = evento.Horario_Termino,
                    @Data_Inicio = evento.Data_Inicio,
                    @Data_Termino = evento.Data_Termino,
                    @Descricao = evento.Descricao
                });
            }
        }
        public void Atualizar(Evento evento)
        {
            var sql = "UPDATE Evento SET Imagem = @Imagem, Horario_Inicio = @Horario_Inicio, Horario_Termino = @Horario_Termino, Data_Inicio = @Data_Inicio" +
                "Data_Termino = @Data_Termino, Descricao = @Descricao WHERE Id = @Id";
            using (var db = _db.GetConexao())
            {
                db.Execute(sql, new
                {
                    @Id = evento.Id,
                    @Imagem = evento.Imagem,
                    @Horario_Inicio = evento.Horario_Inicio,
                    @Horario_Termino = evento.Horario_Termino,
                    @Data_Inicio = evento.Data_Inicio,
                    @Data_Termino = evento.Data_Termino,
                    @Descricao = evento.Descricao
                });
            }
        }

        public async Task<Evento> BuscarPorId(Guid Id)
        {
            string sql = "SELECT * FROM Evento WHERE Id = @Id";
            using (var db = _db.GetConexao())
            {
                return await db.QueryFirstOrDefaultAsync(sql, new { Id = Id });
            }
        }

        public async Task<IEnumerable<Evento>> BuscarTodos(Guid Id)
        {
            string sql = "SELECT * FROM Evento";
            using (var db = _db.GetConexao())
            {
                return await db.QueryAsync<Evento>(sql);
            }
        }

        public void Deletar(Guid Id)
        {
            string sql = "DELETE FROM Evento WHERE Id = @Id";
            using (var db = _db.GetConexao())
            {
                db.Execute(sql, new { Id = Id });
            }
        }
    }
}

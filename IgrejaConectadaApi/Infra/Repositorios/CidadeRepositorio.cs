using Dapper;
using Dominio.Entidades;
using Dominio.Repositorios;
using Infra.DbInfra;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public class CidadeRepositorio : ICidadeRepositorio
    {
        private readonly IDB _db;

        public CidadeRepositorio(IDB dB)
        {
            _db = dB;
        }

        public void Cadastrar(Cidade cidade)
        {
            var sql = "INSERT INTO Cidade (Id, Id_Estado, Nome) VALUES (@Id, Id_Estado, Nome)";
            using var db = _db.GetConexao();
            db.Execute(sql, new
            {
                @Id = cidade.Id,
                @Id_Estado = cidade.Id_Estado,
                @Nome = cidade.Nome
            });
        }

        public void Atualizar(Cidade cidade)
        {
            var sql = "UPDATE Cidade SET  Id_Cidade = @Id_Cidade, Nome = @Nome WHER Id = @Id";
            using var db = _db.GetConexao();
            db.Execute(sql, new
            {
                @Id = cidade.Id,
                @Id_Estado = cidade.Id_Estado,
                @Nome = cidade.Nome
            });
        }

        public async Task<Igreja> BuscarPorId(Guid Id)
        {
            var sql = "SELECT * FROM Cidade WHERE Id  = @Id";
            using (var db = _db.GetConexao())
            {
                return await db.QueryFirstOrDefault(sql, new { Id = Id });
            }
        }

        public async Task<IEnumerable<Cidade>> BuscarTodos()
        {
            var sql = "SELECT * FROM Cidade";
            using (var db = _db.GetConexao())
            {
                return await db.QueryAsync<Cidade>(sql);
            }
        }



        public void Deletar(Guid Id)
        {
            var sql = "DELETE FROM Cidade WHERE ID = @Id";
            using (var db = _db.GetConexao())
            {
                db.Execute(sql, new { Id = Id });
            }
        }
    }
}

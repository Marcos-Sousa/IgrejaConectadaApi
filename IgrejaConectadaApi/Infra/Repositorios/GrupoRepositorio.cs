using Dapper;
using Dominio.Entidades;
using Dominio.Repositorios;
using Infra.DbInfra;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public class GrupoRepositorio : IGrupoRepositorio
    {
        private readonly IDB _db;
        public GrupoRepositorio(IDB db)
        {
            _db = db;
        }

        public void Cadastrar(Grupo grupo)
        {
            string sql = "INSERT INT Grupo (Id, Id_Igreja, Imagem, Horario_Inicio, Horario_Termino, Coordenador, Descricao) VALUES" +
                "(@Id, @Id_Igreja, @Imagem, @Horario_Inicio, @Horario_Termino, @Coordenador, @Descricao)";
            using (var db = _db.GetConexao())
            {
                db.Execute(sql, new
                {
                    @Id = grupo.Id,
                    @Id_Igreja = grupo.Id_Igreja,
                    @Imagem = grupo.Imagem,
                    @Horario_Inicio = grupo.Horario_Inicio,
                    @Horario_Termino = grupo.Horario_Termino,
                    @Coordenador = grupo.Coordenador,
                    @Descricao = grupo.Descricao
                });
            }
        }
        public void Atualizar(Grupo grupo)
        {
            string sql = "UPDATE Grupo SET Grupo Imagem = @Imagem, Horario_Inicio = @Horario_Inicio, Horario_Termino = @Horario_Termino," +
                "Coordenador = @Coordenador,  = @Descricao WHERE Id = Id";
            using (var db = _db.GetConexao())
            {
                db.Execute(sql, new
                {
                    @Id = grupo.Id,
                    @Imagem = grupo.Imagem,
                    @Horario_Inicio = grupo.Horario_Inicio,
                    @Horario_Termino = grupo.Horario_Termino,
                    @Coordenador = grupo.Coordenador,
                    @Descricao = grupo.Descricao
                });
            }
        }

        public async Task<Grupo> BuscarPorId(Guid Id)
        {
            string sql = "SELECT * FROM Grupo WHERE Id = @Id";
            using (var db = _db.GetConexao())
            {
                return await db.QueryFirstOrDefaultAsync(sql, new { Id = Id });
            }
        }

        public async Task<IEnumerable<Grupo>> BuscarTodos(Guid Id)
        {
            string sql = "SELECT * FROM Grupo";
            using (var db = _db.GetConexao())
            {
                return await db.QueryAsync<Grupo>(sql);
            }
        }

        public void Deletar(Guid Id)
        {
            string sql = "DELETE FROM Grupo WHERE Id = @Id";
            using (var db = _db.GetConexao())
            {
                db.Execute(sql, new { Id = Id });
            }
        }
    }
}

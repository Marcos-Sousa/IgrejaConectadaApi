using Dapper;
using Dominio.Entidades;
using Dominio.Repositorios;
using Infra.DbInfra;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public class IgrejaRepositorio : IIgrejaRepositorio
    {
        private readonly IDB _db;
        public IgrejaRepositorio(IDB db)
        {
            _db = db;
        }

        public void Cadastrar(Igreja igreja)
        {
            string sql = "INSERT INTO Igreja (Id, Id_Cidade, Imagem, Rua, CEP, Bairro, Numero, Complemento) VALUES " +
                  "(@Id, @Id_Cidade, @Imagem, @Rua, @CEP, @Bairro, @Numero, @Complemento)";

            using (var db = _db.GetConexao())
            {
                db.Execute(sql, new
                {
                    @Id = igreja.Id,
                    @Id_Cidade = igreja.Id_Cidade,
                    @Imagem = igreja.Imagem,
                    @Rua = igreja.Rua,
                    @CEP = igreja.CEP,
                    @Bairro = igreja.Bairro,
                    @Numero = igreja.Numero,
                    @Complemento = igreja.Complemento
                });
            }
        }

        public void Atualizar(Igreja igreja)
        {
            string sql = "UPDATE Igreja SET Imagem = @Imagem, Rua = @Rua, CEP = @CEP, Bairro = @Bairro, " +
                "Numero = @Numero, Complemento = @Complemento WHERE Id = @Id";
            using (var db = _db.GetConexao())
            {
                db.Execute(sql, new
                {
                    @Id = igreja.Id,
                    @Imagem = igreja.Imagem,
                    @Rua = igreja.Rua,
                    @CEP = igreja.CEP,
                    @Bairro = igreja.Bairro,
                    @Numero = igreja.Numero,
                    @Complemento = igreja.Complemento
                });
            }
        }

        public async Task<Igreja> BuscarPorId(Guid Id)
        {
            string sql = "SELECT * FROM Igreja WHERE Id = @Id";
            using (var db = _db.GetConexao())
            {
                return await db.QueryFirstOrDefault(sql, new { Id = Id });
            }
        }

        public async Task<IEnumerable<Igreja>> BuscarTodos()
        {
            string sql = "SELECT * FROM Igreja";
            using (var db = _db.GetConexao())
            {
                return await db.QueryAsync<Igreja>(sql);
            }
        }

        public void Deletar(Guid Id)
        {
            string sql = "DELETE FROM Igreja WHERE Id = @Id";
            using (var db = _db.GetConexao())
            {
                db.Execute(sql, new { Id = Id });
            }
        }
    }
}

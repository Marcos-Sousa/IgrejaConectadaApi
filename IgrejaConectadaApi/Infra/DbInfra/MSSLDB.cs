using Infra.Configuracao;
using System.Data;
using System.Data.SqlClient;

namespace Infra.DbInfra
{
    public class MSSLDB : IDB
    {
        private SqlConnection _conexao;
        private string _configuracao;

        public MSSLDB(IDbConfiguracao dbConfiguracao)
        {
            _configuracao = dbConfiguracao.StringConexao;
        }
        public void Dispose()
        {
            _conexao.Close();
            _conexao.Dispose();
        }

        public IDbConnection GetConexao()
        {
           if(_conexao == null)
            {
                return _conexao = new SqlConnection(_configuracao);
            }
            else
            {
                if (_conexao.State != ConnectionState.Open)
                    _conexao.ConnectionString = _configuracao;
            }
            return _conexao;
        }
    }
}

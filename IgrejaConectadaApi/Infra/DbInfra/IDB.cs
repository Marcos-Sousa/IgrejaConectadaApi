using System;
using System.Data;

namespace Infra.DbInfra
{
    public interface IDB : IDisposable
    {
        IDbConnection GetConexao();
    }
}

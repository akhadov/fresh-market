using Npgsql;
using System.Data;

namespace Infrastructure.Persistence;

internal sealed class DbConnectionFactory(NpgsqlDataSource dataSource)
{
    public IDbConnection OpenConnection()
    {
        NpgsqlConnection connection = dataSource.OpenConnection();

        return connection;
    }
}
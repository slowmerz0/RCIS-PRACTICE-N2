using Npgsql;
using System;
namespace GarageConsoleApp
{
    public static class DatabaseService
    {
        private static NpgsqlConnection? _connection;
        private static string GetConnectionString()
        {
            return @"Host=10.30.0.137;Port=5432;Database=gr612_badan;Username=gr612_badan;Password=zxcdsaqwe8912fof13";
        }
        public static NpgsqlConnection GetSqlConnection()
        {
            if (_connection is null)
            {
                _connection = new NpgsqlConnection(GetConnectionString());
                _connection.Open();
            }
        
            return _connection;
        }
    }    
}

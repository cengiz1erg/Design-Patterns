using AbstractFactoryV2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryV2
{
    public class DbClient
    {
        Connection _connection;
        Command _command;
        IDbFactory _dbFactory;

        public DbClient(IDbFactory dbFactory, string connectionString)
        {
            _dbFactory = dbFactory;
            _connection = _dbFactory.GetConnection();
            _connection.ConnectionString = connectionString;
            _command = _dbFactory.GetCommand();
        }

        public void Do(string query)
        {
            _command.Query = query;
            _connection.Open();
            _command.Execute();
            _connection.Close();
        }
    }
}

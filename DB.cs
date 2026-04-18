using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace ProjectAvtoMoika
{
    internal class DB : IDisposable
    {
        private MySqlConnection connection;

        public DB()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString;

           
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = "server=localhost;port=3306;username=root;password=root;database=avtomoika";
                Console.WriteLine("ВНИМАНИЕ: Строка подключения не найдена в App.config! Используется заглушка.");
            }

            connection = new MySqlConnection(connectionString);
        }

     
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

    
        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        
        public void Dispose()
        {
            CloseCon();
            connection?.Dispose();
        }
    }
}
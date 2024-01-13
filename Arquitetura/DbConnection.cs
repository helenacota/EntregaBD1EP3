using Npgsql;
using System;
using System.Data;
using System.Text;

namespace MisPeliculas.Arquitetura
{
    public class DbConnection : IDisposable
    {
        public string search_path = "SET search_path TO MisPeliculas;";
        public NpgsqlConnection Connection { get; set; }

        public DbConnection()
        {
            Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=MisPeliculas;User Id=postgres;Password=admin;");
            Connection.Open();
        }

        public NpgsqlCommand execCommand(string sSql)
        {
            NpgsqlCommand command = new NpgsqlCommand(sSql, this.Connection);
            command.ExecuteNonQuery();
            return command;
        }

        public NpgsqlDataReader getReader(string sSql)
        {
            NpgsqlCommand command = new NpgsqlCommand(sSql, this.Connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public DataTable getDataTable(string sSql)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlCommand command = new NpgsqlCommand(sSql, this.Connection))
            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
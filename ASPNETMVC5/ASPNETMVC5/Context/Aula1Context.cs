using ASPNETMVC5.Models;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Entity;

namespace ASPNETMVC5.Context
{
    public class Aula1Context : DbContext
    {
        public Aula1Context(): base("Aula1Context")
        {
            MySqlDataReader rdr = null;
        }
        public DbSet<Cliente> Clientes { get; set; }

        public int ReaderCountRows(MySqlDataReader reader)
        {
            DataTable dt = new DataTable();
            dt.Load(reader);
            int numberOfResults = dt.Rows.Count;
            return numberOfResults;
        }
    }
}
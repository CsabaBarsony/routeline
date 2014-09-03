using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using RouteLineUI.Classes;
using System.Threading;

namespace RouteLineUI.Classes
{
    public class SqlReader
    {
        private NpgsqlConnection conn;

        public SqlReader(String connString)
        {
            conn = new NpgsqlConnection(connString);
            conn.Open();
        }

        public List<Location> readLocations(String query)
        {
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            List<Location> locations = new List<Location>();

            try
            {
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    locations.Add(Location.create(reader));
                }
            }
            finally
            {
                //conn.Close();
            }

            return locations;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using RouteLineUI.Classes;
using System.Threading;
using System.Text.RegularExpressions;

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

        public List<Location> readLocations(String query, String variables)
        {
            NpgsqlCommand command = new NpgsqlCommand(substituteQuery(query, variables), conn);
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

        public static String substituteQuery(String query, String variableString)
        {
            query = query + " ";
            String result = "";
            int i = 0;
            bool inVariable = false;

            while (query.Length > i)
            {
                if (!inVariable && query[i] == '$')
                {
                    result += query.Substring(0, i);
                    query = query.Substring(i, query.Length - i);
                    inVariable = true;
                    i = 0;
                }
                else if (inVariable && query[i] == ' ')
                {
                    String key = query.Substring(1, i - 1);
                    String toAdd = getVariableValue(variableString, key);
                    result += toAdd;
                    query = query.Substring(i, query.Length - i);
                    inVariable = false;
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            return (result + query).Trim();
        }

        public static String getVariableValue(String variableString, String key)
        {
            String result = "";
            String[] variables = variableString.Split(';');

            foreach (String variable in variables)
            {
                String[] keyAndValue = variable.Split('=');
                if (keyAndValue[0] == key)
                {
                    result = keyAndValue[1];
                    break;
                } 
            }

            return result;
        }
    }
}

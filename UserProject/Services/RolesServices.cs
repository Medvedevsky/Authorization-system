using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UserProject.Models;

namespace UserProject.Services
{
    public class RolesServices
    {
        private SqlConnection _connection;

        public RolesServices(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public List<Roles> GetAll()
        {
            string sql = "SELECT * FROM [Roles]";

            List<Roles> roles = new List<Roles>();
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(sql, _connection);

                using(var reder = command.ExecuteReader())
                {
                    while(reder.Read())
                    {
                        Roles dataRole = new Roles
                        {
                            Id = reder.GetInt32(0),
                            Role = reder.GetString(1)
                        };

                        roles.Add(dataRole);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return roles;
        }
    }
}

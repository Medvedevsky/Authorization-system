using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UserProject.Models;

namespace UserProject.Services
{
    public class UsersServices
    {
        private SqlConnection _connection;
        public UsersServices(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public List<Users> GetAll()
        {
            string sql = @"SELECT [Users].[Id], [Users].[Name], [Users].[PhoneNumber], [Roles].[Role]
                           FROM [Users] LEFT JOIN [Roles]
                           ON [Users].[RoleId] = [Roles].[Id]";

            List<Users> listUsers = new List<Users>();

            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(sql, _connection);

                using(var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Roles dataRole = new Roles
                        {
                            Id = reader.GetInt32(0),
                            Role = reader.GetString(3)
                        };

                        Users dataUser = new Users
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            PhoneNumber = reader.GetString(2),
                            RoleId = reader.GetInt32(0),
                            Roles = dataRole
                        };

                        listUsers.Add(dataUser);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return listUsers;
        }

        public void Add(Users data)
        {
            string sql = "INSERT INTO [Users] ([Name], [PhoneNumber], [RoleId]) VALUES (@Name, @PhoneNumber, @RoleId)";
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand(sql, _connection);
                command.Parameters.AddWithValue("@Name", data.Name);
                command.Parameters.AddWithValue("@PhoneNumber", data.PhoneNumber);
                command.Parameters.AddWithValue("@RoleId", data.RoleId);

                command.ExecuteNonQuery();
            }
            finally
            {
                _connection.Close();
            }
        }

        public void ChangeData(int id, Users data)
        {
            string sql = "UPDATE [Users] SET [Name] = @Name, [PhoneNumber] = @PhoneNumber, [RoleId] = @RoleId WHERE [Id] = @Id";

            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(sql, _connection);

                command.Parameters.AddWithValue("@Name", data.Name);
                command.Parameters.AddWithValue("@PhoneNumber", data.PhoneNumber);
                command.Parameters.AddWithValue("@RoleId", data.RoleId);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}

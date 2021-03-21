using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UserProject.Services
{
    public static class SqlConnectionToDataBase
    {
        public static string ConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = @"ANDREYPC\SQLEXPRESS";
            builder.InitialCatalog = "UserStorage";
            builder.IntegratedSecurity = true;

            return builder.ConnectionString;
        }
    }
}

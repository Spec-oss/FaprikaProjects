using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace DataAccess.Concrete.Dapper
{
    public class FaprikaProjectContext
    {
        public static DbConnection GetOpenConnection()
        {
            var connection = new SqlConnection(@"Server=DESKTOP-EOISGJ5;Database=FaprikaProject;Trusted_Connection=true");
            connection.Open();
            return connection;
        }
    }
}

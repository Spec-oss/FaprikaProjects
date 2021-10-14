using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DataAccess.Concrete.Dapper
{
    public class FaprikaProjectContext
    {
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-EOISGJ5;Database=FaprikaProject;Trusted_Connection=true");
    }
}

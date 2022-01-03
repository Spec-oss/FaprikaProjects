using Entities.Concrete;
using LinqToDB;
using LinqToDB.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.LinqtoDb
{
    public class FaprikaProjectContext:LinqToDB.Data.DataConnection
    {
        public ITable<Product> Products => GetTable<Product>();
        public ITable<Category> Categories => GetTable<Category>();
    }
}

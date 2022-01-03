using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product, FaprikaProjectContext>,IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using(FaprikaProjectContext context=new FaprikaProjectContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto { ProductName = p.ProductName, CategoryName = c.CategoryName, Price = p.Price, StockQuantity = p.StockQuantity };
                return result.ToList();
            }
        }
    }
}

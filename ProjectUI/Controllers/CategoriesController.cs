using Bussiness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectUI.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public CategoriesController(IProductService productService,ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        public IActionResult Categories()
        {
            var model = _categoryService.GetAll();
            return View(model.Data);
        }
        public IActionResult CategoryDetails(int id)
        {
            var categoryid = _productService.GetProductByCategoryId(id);
            return View(categoryid.Data);
            
        }
    }
}

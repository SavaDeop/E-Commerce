using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerc.Entites.Concrete;
using ECommerce.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerc.UserInterface.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        } 
        
        [HttpPost]
        public IActionResult Add(Category category)
        {

            _service.Add(category);

            return View();
        }
        
    }
}

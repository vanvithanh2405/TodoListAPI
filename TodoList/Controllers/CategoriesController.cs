using Asenda.DHP.API.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using TodoList.Core.Interfaces;
using TodoList.Core.Models.Categories;

namespace TodoList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : BaseApiController
    {
        private readonly ICategoryServices _categoryServices;
        public CategoriesController(
            ICategoryServices categoryServices    
        ) { 
            _categoryServices = categoryServices;
        }

        [HttpPost]
        public IActionResult CreateCategory(CategoryRequest request)
        {
            return null;
        }

    }
}

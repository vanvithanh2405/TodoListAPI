

using Asenda.DHP.SharedKernel.IRepository;
using Microsoft.AspNetCore.Identity;
using TodoList.Core.Interfaces;
using TodoList.Core.Models.Categories;
using TodoList.Infrastructure.Data.Entities;

namespace TodoList.Infrastructure.Services
{

    public class CategoryService : ICategoryServices
    {
        private readonly IGenericRepository<Categories> _categories;

        public CategoryService()
        {

        }
        public IdentityResult? CreateCategory(CategoryRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

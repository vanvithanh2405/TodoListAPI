using Microsoft.AspNetCore.Identity;
using TodoList.Core.Models.Categories;

namespace TodoList.Core.Interfaces
{
    public interface ICategoryServices
    {
         IdentityResult? CreateCategory(CategoryRequest request);
    }
}

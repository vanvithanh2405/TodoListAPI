using Asenda.DHP.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using TodoList.Core.Interfaces;

namespace TodoList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : BaseApiController
    {
       private readonly ITodoServices _todoService;
       public TodoListController(
           ITodoServices todoServices
       )
       {
            _todoService = todoServices;
       }

    }
}

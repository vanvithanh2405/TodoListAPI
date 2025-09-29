using Asenda.DHP.Core.Constants;
using Microsoft.AspNetCore.Mvc;

namespace Asenda.DHP.API.Controllers
{
    public abstract class BaseApiController : ControllerBase
    {
        internal ObjectResult InternalServerError(object? responseContent = null)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, responseContent ?? new { message = Messages.ApiErrors.General500Message });
        }

        internal ObjectResult NotImplemented(object? responseContent = null)
        {
            return StatusCode(StatusCodes.Status501NotImplemented, responseContent ?? new { message = Messages.ApiErrors.General501Message });
        }

        internal ObjectResult Forbidden(object? responseContent = null)
        {
            return StatusCode(StatusCodes.Status403Forbidden, responseContent ?? new { message = Messages.ApiErrors.General403Message });
        }
    }
}
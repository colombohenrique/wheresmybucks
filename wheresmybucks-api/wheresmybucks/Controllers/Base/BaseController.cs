using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace wheresmybucks.Controllers.Base
{
    [Authorize]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        protected ActionResult ApiResponse<T>(ResultModel<T>? result = null) where T : class
        {
            if (result is null) return Ok();

            if (!result.HasErrors())
            {
                if (result.Data == null)
                {
                    return result.HasMessages() ? Ok(new { Messages = result.Messages.ToArray() }) : NotFound();
                }

                return Ok(result.Data);
            }
            return BadRequest(new { Messages = result.Messages.ToArray() });
        }

        protected ActionResult ApiResponse(ResultModel<bool>? result = null)
        {
            if (result is null) return Ok();

            if (!result.HasErrors())
            {
                return result.HasMessages() ? Ok(new { Messages = result.Messages.ToArray() }) : Ok(result.Success);
            }
            return BadRequest(new { Messages = result.Messages.ToArray() });
        }
    }
}

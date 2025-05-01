using Microsoft.AspNetCore.Mvc;

namespace Application.API.Controllers.Base
{
    [Route("api/[controller]/[Action]")]
    //[Authorize]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
    }
}

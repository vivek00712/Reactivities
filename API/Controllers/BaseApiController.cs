using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        protected IMediator _mediator;

        protected IMediator Mediator => _mediator ??=
            HttpContext.RequestServices.GetService<IMediator>();

    }
}
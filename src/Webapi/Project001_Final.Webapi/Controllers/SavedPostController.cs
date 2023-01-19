using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project001_Final.Application.Features.Commands.SavedPost.CreateSavedPost;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project001_Final.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SavedPostController : ControllerBase
    {
        IMediator _mediator;
        public SavedPostController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[Authorize]
        [HttpPost]
       [Route("Create")]
       public async Task<IActionResult> Create(CreateSavedPostCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}

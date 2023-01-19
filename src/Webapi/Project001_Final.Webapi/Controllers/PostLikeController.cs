using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project001_Final.Application.Features.Commands.PostLike;
using Project001_Final.Application.Features.Commands.PostLike.DeletePostLike;
using Project001_Final.Application.Features.Queries.PostLike.GetLikesByPostIdQuery;
using Project001_Final.Application.Features.Queries.PostLike.GetPostLikeById;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project001_Final.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostLikeController : ControllerBase
    {
        IMediator _mediator;
        public PostLikeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[Authorize]
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(CreatePostLikeCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpGet]
        [Route("GetLikesByPostId")]
        public async Task<IActionResult> GetLikesByPostId(int postId)
        {
            var query = new GetLikesByPostIdQuery()
            {
                PostId = postId
            };
            return Ok(await _mediator.Send(query));
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetPostLikeByIdQuery()
            {
                Id = id
            };
            return Ok(await _mediator.Send(query));
        }
        //[Authorize]
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete([FromQuery] DeletePostLikeCommand query)
        {
            return Ok(await _mediator.Send(query));
        }


    }
}

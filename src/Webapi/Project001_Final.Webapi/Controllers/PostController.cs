using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project001_Final.Application.Features.Commands.Post;
using Project001_Final.Application.Features.Queries.Post.GetPostById;
using Project001_Final.Application.Features.Queries.Post.GetPostsQuery;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project001_Final.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        IMediator _mediator;
        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get(string searchInput, bool isActive)
        {
            var query = new GetPostsQuery()
            {
                SearchInput = searchInput == null || searchInput == "null" ? "" : searchInput,
                IsActive = isActive
            };
            return Ok(await _mediator.Send(query));
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetPostByIdQuery()
            {
                Id = id
            };
            return Ok(await _mediator.Send(query));
        }
       // [Authorize]
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromForm]CreatePostCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}

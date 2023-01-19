using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project001_Final.Application.Features.Commands.PostComment.CreatePostCommentCommand;
using Project001_Final.Application.Features.Queries.PostComment;
using Project001_Final.Application.Features.Queries.PostComment.GetPostCommentByPostId;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project001_Final.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostCommentController : ControllerBase
    {
        IMediator _mediator;

        public PostCommentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get(string searchInput,bool isActive)
        {
            var query = new GetPostCommentQuery()
            {
                SearchInput = searchInput == null || searchInput == "null" ? "" : searchInput,
                IsActive = isActive
            };
            return Ok(await _mediator.Send(query));
        }

        [HttpGet]
        [Route("GetByPostId")]
        public async Task<IActionResult> GetByPostId(int postId)
        {
            var query = new GetPostCommentByPostIdQuery()
            {
                PostId = postId
            };
            return Ok(await _mediator.Send(query));
        }
        //[Authorize]
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(CreatePostCommentCommand query)
        {
            return Ok(await _mediator.Send(query));
        }

    }
}

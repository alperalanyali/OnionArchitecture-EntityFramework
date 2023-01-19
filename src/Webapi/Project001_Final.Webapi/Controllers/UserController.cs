using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project001_Final.Application.Features.Commands.User.CreateUserCommand;
using Project001_Final.Application.Features.Commands.User.UpdateUserCommand;
using Project001_Final.Application.Features.Queries.User.GetUserById;
using Project001_Final.Application.Features.Queries.User.GetUsers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project001_Final.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get(string searchInput,bool isActive)
        {
            var query = new GetAllUsersQuery()
            {
                SearchInput = searchInput == null ? "" : searchInput,               
            };
            return Ok(await _mediator.Send(query));
        }
        
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetUserByIdQuery()
            {
                Id = id
            };
            return Ok(await _mediator.Send(query));
        }
        
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(CreateUserCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(UpdateUserCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project001_Final.Application.Features.Commands.NavigationItemRole.CreateNavigationItemRole;
using Project001_Final.Application.Features.Commands.NavigationItemRole.UpdateNavigationItemRoleCommand;
using Project001_Final.Application.Features.Queries.NavigationItemRole.GetAllUserNavigationItemRole;
using Project001_Final.Application.Features.Queries.NavigationItemRole.GetNavigationItemRoleById;
using Project001_Final.Application.Interface.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project001_Final.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NavigationItemRoleController : ControllerBase
    {       
        IMediator _mediator;

        public NavigationItemRoleController(INavigationItemRoleRepository navItemRoleRepo,IMediator mediator)
        {          
            _mediator = mediator;
        }
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get( string searchInput,bool isActive)
        {
            var query = new GetAllUserNavigationItemRoleQuery()
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
            var query = new GetNavigationItemRoleByIdQuery()
            {
                Id = id
            };
            return Ok(await _mediator.Send(query));
        }
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateAsync(CreateNavigationItemRoleCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(UpdateNavigationItemRoleCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}

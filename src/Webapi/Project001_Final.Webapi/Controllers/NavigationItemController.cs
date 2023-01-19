using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project001_Final.Application.Features.Commands.NavigationItem.CreateNavigationItem;
using Project001_Final.Application.Features.Commands.NavigationItem.UpdateNavigationItemCommand;
using Project001_Final.Application.Features.Queries.NavigationItem.GetAllNavigationItem;
using Project001_Final.Application.Features.Queries.NavigationItem.GetNavigationItemById;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project001_Final.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NavigationItemController : ControllerBase
    {
        IMediator _mediator;

        public NavigationItemController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[Authorize]
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get(string searchInput,bool isActive)
        {
            var query = new GetAllNavigationItemQuery() {
                SearchInput = searchInput == null || searchInput == "null" ? "" : searchInput,
                IsActive = isActive
            };
            return Ok(await _mediator.Send(query));
        }
        //[Authorize]
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetNavigationItemByIdQuery()
            {
                Id = id
            };
            return Ok(await _mediator.Send(query));
        }
        //[Authorize]
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(CreateNavigationItemCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        //[Authorize]
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(UpdateNavigationItemCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}

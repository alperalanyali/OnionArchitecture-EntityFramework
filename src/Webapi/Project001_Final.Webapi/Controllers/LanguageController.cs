using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project001_Final.Application.Features.Commands.Language.CreateLanguage;
using Project001_Final.Application.Features.Commands.Language.UpdateLanguage;
using Project001_Final.Application.Features.Queries.Language.GetAllLanguage;
using Project001_Final.Application.Features.Queries.Language.GetLanguageByIdQuery;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project001_Final.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LanguageController : ControllerBase
    {
        IMediator _mediator;
        public LanguageController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get(string searchInput,bool isActive)
        {
            var query = new GetAllLanguageQuery()
            {
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
            var query = new GetLanguageByIdQuery()
            {
                Id = id
            };
            return Ok(await _mediator.Send(query));
        }
        //[Authorize]
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] CretaLanguageCommand command) {
            return Ok(await _mediator.Send(command));
        }
        //[Authorize]
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Put([FromBody] UpdateLanguageCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}

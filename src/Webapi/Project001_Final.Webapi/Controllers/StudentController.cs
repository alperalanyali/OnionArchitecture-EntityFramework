using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
//using Project001_Final.Application.Features.Commands;
using Project001_Final.Application.Features.Queries.GetStudentById;
using Project001_Final.Application.Features.Queries.GetStudents;
using Project001_Final.Application.Interface.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project001_Final.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // Artık buna gerek kalmadı. Çünkü mapping ile sorunu çözdük
        // private readonly IStudentRepository _studentRepository;
        private readonly IMediator _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllStudentQuery();

            return Ok(await _mediator.Send(query));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetStudentByIdQuery() { Id = id };
            return Ok(await _mediator.Send(query));
        }
       // [HttpPost]
        /*public async Task<IActionResult> Post(CreateStudentCommand command)
        {

            return Ok(await _mediator.Send(command));
        }*/
    }
}

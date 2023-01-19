using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Project001_Final.Application.Features.Commands.User.CreateUserCommand;
using Project001_Final.Application.Features.Queries.User.Login;
using Project001_Final.Application.Interface.JWT;
using Project001_Final.Application.Interface.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project001_Final.Persistence.Repositories
{
 
    [ApiController]
    [Route("api/[controller]")]
    public class UserOperationController : ControllerBase
    {
        IMediator _mediator;
        IJwtAuthenticationManager _jwtManager;
 
        IUserRepository _userRepo;
        public UserOperationController(IMediator mediator,IJwtAuthenticationManager jwtAuthenticationManager,IUserRepository userRepo)
        {
            _mediator = mediator;
            _jwtManager = jwtAuthenticationManager;
            _userRepo = userRepo;
   
        }
        //[AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginQuery login)
        {
            var token = _jwtManager.Authencate(_userRepo, login);
            if (token == null)
            {
                return NotFound("User Not Found!!");
            }
            return Ok(token);
        }
        //[AllowAnonymous]
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(CreateUserCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

       
    }
}

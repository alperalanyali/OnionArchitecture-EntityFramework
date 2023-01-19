using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Project001_Final.Application.Features.Queries.User.Login;
using Project001_Final.Application.Interface.JWT;
using Project001_Final.Application.Helpers;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;
using System.Threading.Tasks;

namespace Project001_Final.Application.Helpers
{
    public class JwtAuthencationManager : IJwtAuthenticationManager
    {
        private readonly IUserRepository _userRepo;
        private readonly string _key;
        
        public JwtAuthencationManager(/*IUserRepository userRepo,*/string key)
        {
           // _userRepo = userRepo;
            _key = key;
        }
        public  async Task<ServiceResponse<string>> Authencate(IUserRepository userRepo ,LoginQuery query)
        {
            //var user = await userRepo.CheckUserExists(query);
            //if (user == null)
            //{
            //    return null;
            //}
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(_key);
            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject= new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name,query.LoginId)
                }),
                Expires = DateTime.UtcNow.AddMinutes(Constants.JwtExpires),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),SecurityAlgorithms.HmacSha256Signature)

            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new ServiceResponse<string>(tokenHandler.WriteToken(token));
        }

        
    }
}

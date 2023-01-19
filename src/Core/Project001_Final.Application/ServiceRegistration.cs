using System;
using System.Reflection;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Project001_Final.Application.Helpers;
using Project001_Final.Application.Interface.JWT;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Project001_Final.Application.Interface.Repositories;

namespace Project001_Final.Application
{
    public static class ServiceRegistration
    {     
        public static void AddApplicationRegistration(this IServiceCollection services)
        {
           
            var key = "This is my test key";
            var assembly = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assembly);
            services.AddMediatR(assembly);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddCookie().AddJwtBearer(x =>
               {
                   
                   x.RequireHttpsMetadata = false;
                   x.SaveToken = true;
                   x.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuerSigningKey = true,
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                       ValidateIssuer = false,
                       ValidateAudience = false,
                       RequireExpirationTime = true,
                       ClockSkew = TimeSpan.Zero,

                   };

               }
            );
            services.AddSingleton<IJwtAuthenticationManager>(new JwtAuthencationManager(key));
          

        }
    }
}

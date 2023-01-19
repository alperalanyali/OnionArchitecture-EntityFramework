using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project001_Final.Application.Features.Queries.User.GetUsers;
using Project001_Final.Application.Features.Queries.User.Login;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Domain.Entities;
using Project001_Final.Persistence.Context;
using Project001_Final.Application.Helpers;
namespace Project001_Final.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CheckUserExists(LoginQuery query)
        {
            var user = await _dbContext.Set<User>().Where(x => x.LoginId == query.LoginId && x.Password == PasswordEncryptDecrypt.EncryptPassword(query.Password)).FirstOrDefaultAsync();
            var result = user != null ? true : false;
            return result;
        }

        public async Task<List<User>> ListAsync(GetAllUsersQuery query)
        {
            return await _dbContext.Set<User>().Where(x =>
           query.SearchInput != null && (
               x.LoginId.ToLower().Contains(query.SearchInput.ToLower())
               || x.Name.ToLower().Contains(query.SearchInput.ToLower())
               || x.Surname.ToLower().Contains(query.SearchInput.ToLower())
               || x.Phone.ToLower().Contains(query.SearchInput.ToLower())
               || x.Email.ToLower().Contains(query.SearchInput.ToLower())
           )
           ).ToListAsync();
        }

        public async Task<User> Login(LoginQuery query)
        {
            var user = new User();
            try
            {
                var enPassword = PasswordEncryptDecrypt.EncryptPassword(query.Password);
                user = await _dbContext.Set<User>().Where(x => x.LoginId == query.LoginId
                                   && x.Password == enPassword).FirstOrDefaultAsync();
            }   catch (Exception ex)
            {

            }     
            return user;
        }
    }
}

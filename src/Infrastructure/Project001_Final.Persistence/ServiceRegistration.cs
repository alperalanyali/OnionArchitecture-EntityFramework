using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Persistence.Context;
using Project001_Final.Persistence.Repositories;

namespace Project001_Final.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));

            // service.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IStatusRepository, StatusRepository>();
            services.AddTransient<IStatusRepository, StatusRepository>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IUserRoleRepository, UserRoleRepository>();
            services.AddTransient<INavigationItemRepository, NavigationItemRepository>();
            services.AddTransient<INavigationItemRoleRepository, NavigationItemRoleRepository>();
            services.AddTransient<IFormRepository, FormRepository>();
            services.AddTransient<ILanguageRepository, LanguageRepository>();
            services.AddTransient<IPostRepository, PostRepository>();
            services.AddTransient<IPostLikeRepository, PostLikeRepository>();
            services.AddTransient<IPostCommentRepository, PostCommentRepository>();
            services.AddTransient<ISavedPostRepository, SavedPostRepository>();
        }
    }
}

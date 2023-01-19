using System;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Domain.Entities;
using Project001_Final.Persistence.Context;

namespace Project001_Final.Persistence.Repositories
{
    public class SavedPostRepository : BaseRepository<SavedPost>, ISavedPostRepository
    {
        public SavedPostRepository(ApplicationDbContext dbContext):base(dbContext)
        {
        }
    }
}

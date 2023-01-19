using System;
using Project001_Final.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Project001_Final.Persistence.Context
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<NavigationItem> NavigationItem { get; set; }
        public DbSet<Form> Form { get; set; }
        public DbSet<NavigationItemRole> NavigationItemRole { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostLike> PostLike { get; set; }
        public DbSet<PostComment> PostComment { get; set; }
        public DbSet<SavedPost> SavedPost { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public ApplicationDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Project001;Trusted_Connection=True;integrated security=false;User ID=sa;Password=metallica1;");
            }
        
        }
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            /*  modelBuilder.Entity<Student>().HasData(
                  new Student()
                  {
                      Id=1,
                      Name = "Alper",
                      Surname="Alanyali",
                      BirthDate=DateTime.Today,
                      CreatedDate=DateTime.Now
                  },
                    new Student()
                    {
                        Id = 2,
                        Name = "Mert",
                        Surname = "Alanyali",
                        BirthDate = DateTime.Today,
                        CreatedDate = DateTime.Now
                    },
                      new Student()
                      {
                          Id = 3,
                          Name = "Ayşen",
                          Surname = "Alanyali",
                          BirthDate = DateTime.Today,
                          CreatedDate = DateTime.Now
                      }
                  );*/
            modelBuilder.Entity<UserRole>()
                .HasOne(u => u.User)
                .WithMany(r => r.UserRoles).
                HasForeignKey(x => x.UserId);
            modelBuilder.Entity<PostLike>()
                .HasOne(u => u.User)
                .WithMany(p => p.PostLikes)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PostComment>()
                 .HasOne(s => s.User)
                 .WithMany(u => u.PostComments)
                 .HasForeignKey(x => x.UserId)
                 .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<SavedPost>()
             .HasOne(s => s.User)
             .WithMany(u => u.SavedPosts)
             .HasForeignKey(x => x.UserId)
             .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(modelBuilder);
         
        }
    }
}

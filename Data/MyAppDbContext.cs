using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using auct.Models;

namespace auct.Data   // ← Make sure this matches your project’s root namespace (e.g. if your project is called "auct")
{
    public class MyAppDbContext : DbContext
    {
        // 1) EF Core will inject the options (including your SQLite conn string) here:
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaskItem> Tasks { get; set; }
        // 2) Add one DbSet<T> per entity/table you want:
        //    public DbSet<YourEntity> YourEntities { get; set; }
    }

     public class ApplicationDbContext : IdentityDbContext
      {
          public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
              : base(options)
          {
          }

          // Define DbSet properties for your entities here
      }
}

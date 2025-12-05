using Microsoft.EntityFrameworkCore;
using YourPlatform.Models;

namespace YourPlatform.DBContext
{
    public class MyAppContext: DbContext
    {

        public MyAppContext(DbContextOptions<MyAppContext> options)
                : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}

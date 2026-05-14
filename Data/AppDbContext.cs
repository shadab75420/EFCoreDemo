// this will act as a bridge between application and database 
// It is responsible for DB communication  
// it tracks entity changes 

using Microsoft.EntityFrameworkCore;
using EFCoreDemo.Models;

namespace EFCoreDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> students { get; set; }

        // above property is used for accessing student class members as properties
    }
}
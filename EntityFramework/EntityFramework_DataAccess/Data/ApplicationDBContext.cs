using EntityFramework_Model.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_DataAccess.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
        {

        }

        public DbSet<Authors> Authors { get; set; }
        public DbSet<Titles> Titles { get; set; }
        public DbSet<Publishers> Publishers { get; set; }


        //public DbSet<Category> Categories { get; set; }

    }
}

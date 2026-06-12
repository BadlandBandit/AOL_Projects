using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstStudent;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StudentDB;Trusted_Connection=True;");
    }
}

using api_crud.Students;
using Microsoft.EntityFrameworkCore;

namespace api_crud.Data;

public class AppDbContext: DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString: "Data Source=Banco.sqlite");
        optionsBuilder.LogTo(Console.WriteLine);
        base.OnConfiguring(optionsBuilder);
    }
}
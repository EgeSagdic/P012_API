using Microsoft.EntityFrameworkCore;

namespace P012_API.Models
{
    public class DataContext:DbContext 
    { 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-FEBL0K35\SQLEXPRESS;Database=P012_API;Trusted_Connection=true;encrypt=false");
        }


        public DbSet<Film> Film { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace BlogAPI.DataAccsessLayer
{
    public class Contextt:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=305-08;Database=Db_BlogCoreeAPI;User=WebMobile_302;Password=WebMobile.302;");

        }
        public DbSet<Employee> Employees { get; set; }
    }
}

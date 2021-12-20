using Microsoft.EntityFrameworkCore;
using FirstWebApp.Model;
namespace FirstWebApp
{
    public class MyDbContext:DbContext
    {
        public DbSet<Student> students{get;set;}
        public MyDbContext(DbContextOptions options):base(options){

        }
    }
}
using Microsoft.EntityFrameworkCore;
using Student_Backend.Models;

namespace ReactAspCrud.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("SERVER=localhost;PORT=3306;DATABASE=lbs;USER=root;PASSWORD=;SSL MODE=none;");
        }
    }
}
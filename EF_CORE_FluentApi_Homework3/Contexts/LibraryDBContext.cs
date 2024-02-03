using EF_CORE_FluentApi_Homework3.Configurations;
using EF_CORE_FluentApi_Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_FluentApi_Homework3.Contexts
{
    public class LibraryDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;Trust Server Certificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Pres> Press {  get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<T_Card> TCards { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Lib> Libs { get; set; }
        public DbSet<S_Card> SCards { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using System;

namespace s2.DAL
{
    public class OfficeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;initial catalog=project;integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }

        public void AddJavaScriptVariable(string v, object p)
        {
            throw new NotImplementedException();
        }

        public object AddJavaScriptFunction(string v)
        {
            throw new NotImplementedException();
        }
    }

    public class User
    {
        public int UserId { get; set; }

        public string Username { get; set; }

        public string Passsword { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }


    }
}

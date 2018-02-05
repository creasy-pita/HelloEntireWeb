using HelloEntireWeb.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloEntireWeb.Models
{
    public class InMemoryBloggingContext : DbContext
    {
        public string connectionStr;
        public string dbtype;

        public InMemoryBloggingContext(string connectionStr, string dbtype)
        {
            
        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=192.168.11.83;Database=blogging;Uid=root;Pwd=root;Encrypt=true");
            
        }


    }
}


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= BUDOTEKNO\\SQLEXPRESS;  database = CoreAndFood;"+
                "integrated security = true;");

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods{ get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Service> Services{ get; set; }
        public DbSet<About> Abouts{ get; set; }
        public DbSet<AboutList> AboutLists{ get; set; }
        public DbSet<ServiceList> ServiceLists{ get; set; }
        public DbSet<AboutUser> AboutUsers { get; set; }
        public DbSet<AboutYorum> AboutYorums  { get; set; }
    }
}

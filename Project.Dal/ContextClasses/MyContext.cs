using Microsoft.EntityFrameworkCore;
using Project.Conf.Options;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Dal.ContextClasses
{
    public class MyContext : DbContext
    {

        public MyContext(DbContextOptions<MyContext> opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AppUserConfigration());
            modelBuilder.ApplyConfiguration(new AppUserProfileConfigration());
            modelBuilder.ApplyConfiguration(new CategoryConfigration());
            modelBuilder.ApplyConfiguration(new ProductConfigration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfigration());
            modelBuilder.ApplyConfiguration(new OrderConfigration());
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUseProfiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
        
}


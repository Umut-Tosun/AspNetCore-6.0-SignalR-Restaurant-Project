using Microsoft.EntityFrameworkCore;
using SignalRProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=UMUTTOSUN\\SQLEXPRESS;initial catalog=SignalRDb;integrated security=true");
        }
        public DbSet<About> abouts { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Discount> discounts { get; set; }
        public DbSet<Feature> features { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; } 
        public DbSet<Testimonial> testimonials { get; set;}
    
        
    }
}

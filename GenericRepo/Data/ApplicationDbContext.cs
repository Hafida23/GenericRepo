using GenericRepo.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Apple iPad", Price = 1000 },
                new Product() { Id = 2, Name = "Samsung Smart Tv", Price = 1500 },
                new Product() { Id = 3, Name = "HP Laptop", Price = 1200 });



            modelBuilder.Entity<Customer>().HasData(
               new Customer() { Id = 1, FirstName = "Kenan", LastName = "Kurda", Email = "kenan@gmail.com", Phone = "123456" },
               new Customer() { Id = 2, FirstName = "Jan", LastName = "De Grote", Email = "Jan@gmail.com", Phone = "65231" },
               new Customer() { Id = 3, FirstName = "Tim", LastName = "Kleine", Email = "Tim@gmail.com", Phone = "4445556" });
        }
    }
}

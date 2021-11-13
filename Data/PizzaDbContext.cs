using IlmhubPizza.Entities;
using Microsoft.EntityFrameworkCore;

namespace IlmhubPizza.Data
{
    public class PizzaDbContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        
        
        public PizzaDbContext(DbContextOptions options)
            : base(options) { }            
        
    }
}
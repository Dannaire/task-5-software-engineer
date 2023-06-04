using Customer_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Customer_Api.Data
{
    public class CustomerDb : DbContext
    {
         public CustomerDb(DbContextOptions options) : base(options) 
        { 
        }

        public DbSet<Customer> Customers { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Api3.Models;

namespace Api3
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set;}
    }
}
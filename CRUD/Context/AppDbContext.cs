using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> clientes { get; set; }
    }
}

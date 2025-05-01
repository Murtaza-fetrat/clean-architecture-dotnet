
using Application.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Presistence.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<TestTakers> TestTakers { get; set; }
    }
}

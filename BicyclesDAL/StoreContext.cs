using BicyclesDAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BicyclesDAL
{
    public class StoreContext : DbContext
    {
        public DbSet<Bicycle> Bicycles { get; set; }
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }
    }
}

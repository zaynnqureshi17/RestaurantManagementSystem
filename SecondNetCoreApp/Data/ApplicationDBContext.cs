using Microsoft.EntityFrameworkCore;
using SecondNetCoreApp.Models;

namespace SecondNetCoreApp.Data

{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<PizzaOrders> PizzaOrders { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {

        }
    }
}

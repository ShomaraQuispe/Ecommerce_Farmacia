using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Farmacia.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions <AppDbContext> options) : base(options)
        {

        }

    }
}

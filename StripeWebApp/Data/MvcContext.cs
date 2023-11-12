using Microsoft.EntityFrameworkCore;
using StripeWebApp.Models;

namespace StripeWebApp.Data
{
    public class MvcContext :DbContext
    {
        public MvcContext(DbContextOptions<MvcContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}

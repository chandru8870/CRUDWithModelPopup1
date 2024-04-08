using CRUDWithModelPopup1.Models.DBEntites;
using Microsoft.EntityFrameworkCore;

namespace CRUDWithModelPopup1.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
    }
}

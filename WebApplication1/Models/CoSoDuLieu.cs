using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class CoSoDuLieu : DbContext
    {
        public CoSoDuLieu(DbContextOptions<CoSoDuLieu> options)
            : base(options)
        {
        }
        public DbSet<Userss> Userss { get; set; }
    }
}
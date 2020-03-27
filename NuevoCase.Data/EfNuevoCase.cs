using Microsoft.EntityFrameworkCore;
using NuevoCase.Data.Models;

namespace NuevoCase.Data
{
    public class EfNuevoCase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ALIPC;Database=NuevoCase;Password=1;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public EfNuevoCase() : base() { }
        public EfNuevoCase(DbContextOptions<EfNuevoCase> options)
           : base(options)
        { }
        public virtual DbSet<Urls> Urls { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}

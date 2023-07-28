using Microsoft.EntityFrameworkCore;

namespace vendaLanches.Context
{
    public class appDbContext : DbContext
    {
        public appDbContext(DbContextOptions<appDbContext> options) : base(options) 
        {
        }
        
            
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
    }
}

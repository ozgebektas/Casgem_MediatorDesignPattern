using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Casgem_MediatorDesignPattern.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }    
    }
}

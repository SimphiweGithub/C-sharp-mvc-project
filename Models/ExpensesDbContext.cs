using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class ExpensesDbContext :DbContext
    {
        
       public DbSet<Expenses> Expensess { get; set; }

        public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options) :base(options) { 
        
        
        }
    }
}

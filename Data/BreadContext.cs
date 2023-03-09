using Breadwatch.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Breadwatch.Data
{
    public class BreadContext : DbContext
    {
        public BreadContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Budgets> Budgets { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryBudgetMapping> CategoryBudgetMapping { get; set; }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseType> ExpenseType { get; set; }
        public DbSet<User> User { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breadwatch.DataModels
{
    //Categories that are mapped to budgets
    public class CategoryBudgetMapping
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BudgetId { get; set; }
        public int CategoryId { get; set; }
    }
}
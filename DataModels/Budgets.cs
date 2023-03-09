using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breadwatch.DataModels
{
    public class Budgets
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? BudgetName { get; set; }
        public float Amount { get; set; }
    }
}
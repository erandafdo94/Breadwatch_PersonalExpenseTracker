using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breadwatch.DataModels
{
    public class Expense
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Description { get; set; }
        public int AcccountId { get; set; }
        public int CategoryId { get; set; }
        public float Amount { get; set; }
        public int ExpenseType { get; set; }
    }
}
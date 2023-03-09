using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breadwatch.DataModels
{
    public class Accounts
    {
        public int Id { get; set; }
        public string? AccountName { get; set; }
        public string? AccountType { get; set; }
        public float Balance { get; set; }

        
    }
}
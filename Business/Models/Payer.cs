using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class Payer
    {
        public Guid Id { get; set; }
        public Key Key { get; set; }
        public string  Name { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}

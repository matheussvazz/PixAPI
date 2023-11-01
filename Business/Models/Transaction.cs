using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public Payer Payer { get; set; }
        public Receiver Receiver { get; set; }

    }
}

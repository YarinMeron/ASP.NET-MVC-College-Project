using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShenkinStore.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; } // primary key
        [Display(Name = "Transaction Date")]
        public DateTime TransactionDate { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }

      
        public Product Product { get; set; }
        public User User { get; set; }
    }
}

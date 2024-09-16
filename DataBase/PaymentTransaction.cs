using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Centric_Payment_API.DataBase
{
    public class PaymentTransaction
    {
        [Key]
        public int? TransactionId { get; set; }

        [ForeignKey("BillingAccount")]  
        public string? BillingAccount { get; set; }
        public int? AmountPaid { get; set; }
        public string? TransactionDate { get; set; }
        public string? Status { get; set; }
    }
}


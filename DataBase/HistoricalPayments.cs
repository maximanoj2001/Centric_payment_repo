using Centric_Payment_API.DataBase;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Centric_Payment_API.DataBase
{
    public class HistoricalPayments
    {
        public string? PaymentTransactionId { get; set; }
        public string? SalesforceBillingAccountId { get; set; }
        public decimal? AmountPaid { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? Status { get; set; }
       
    }
}


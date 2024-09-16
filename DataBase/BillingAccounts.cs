using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;

namespace Centric_Payment_API.DataBase
{
    public class BillingAccounts
    {
        [Key]
        public  int?   BillingAccountId { get; set; } 
        public string? CustomerAccountId { get; set; }
        public string? AccountOwner { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public bool? EnableAutoPay { get; set; }
        public string? BillCycle { get; set; }
        public string? BillDeliveryMethod { get; set; }
        public string? BillFormat { get; set; }
        public string? BillFrequency { get; set; }
        public string? BillingStreet { get; set; }
        public string? BillingCity { get; set; }
        public string? BillingState { get; set; }
        public string? BillingZip { get; set; }
        public string? BillingCountry { get; set; }
        public string? BillingPostcode { get; set; }
        public int? ContactId { get; set; }
        public string? ServiceLine { get; set; }

    }
}



 
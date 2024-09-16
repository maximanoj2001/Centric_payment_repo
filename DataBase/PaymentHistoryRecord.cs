using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Centric_Payment_API.DataBase
{
    public class PaymentHistoryRecord
    {
       
        public int? recorded_id { get; set; }
        public int? transaction_id { get; set; }
        public string? salesforce_acct_id { get; set; }   
        public int? old_acct_id { get; set; }    
        public int? transaction_type { get; set; }
        public string? transaction_desc { get; set; }           
        public int? transaction_amount { get; set; }
        public int? transaction_applied_amount { get; set; }
        public string? transaction_currency { get; set; }
        public string? transaction_create_date { get; set; }
        public int? statement_no { get; set; }
        public string? client_receipt_id { get; set; }
        public string? transaction_comments { get; set; }
        public int? transaction_source_id { get; set; }
        public string? transaction_ref_code { get; set; }
    }
}





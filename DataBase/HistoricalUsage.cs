using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Centric_Payment_API.DataBase
{
    public class HistoricalUsage
    {
        [Key]
        public string? usage_id { get; set; }

        [ForeignKey("salesforce_billing_account_id")]
        public string? salesforce_billing_account_id { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? end_date { get; set; }
        public int? quantity { get; set; }
        public decimal? unit_price { get; set; }
        public decimal? total_amount { get; set; }  
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Centric_Payment_API.DataBase
{
    public class HistoricalStatement
    {

        [Key]
        public string? invoice_id { get; set; }

        [ForeignKey("salesforce_billingaccount_id")]
        public string? salesforce_billingaccount_id { get; set; }
        public decimal? invoice_amount { get; set; }
        public DateTime? invoice_date { get; set; }
        public string? S3fileurl { get; set; }
    }
}
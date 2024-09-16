namespace Centric_Payment_API.Models
{
    public class StatementData
    {
        public int? ErrorCode { get; set; }
        public string? ErrorMessage { get; set; }
        public int? InvoiceNo { get; set; }
        public int? UnappliedPamentSummary { get; set; }
        public int? AccountBalance { get; set; }
        public string? SentStatus { get; set; }
        public string? DateSent { get; set; }
    }
}



namespace Centric_Payment_API
{
    public class PaymentHistoryReq
    {
        public string? client_acct_id { get; set; }
        public string? start_date { get; set; }
        public string? end_date { get; set; }
    }
}

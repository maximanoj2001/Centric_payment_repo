namespace Centric_Payment_API.Models
{
    public class UsageHistoryResponse
    {
        public int? ResponseCode { get; set; }
        public bool? IsSuccess  { get; set; }
        public UsageData? data { get; set; }
        public string? Message { get; set; }
    }
}
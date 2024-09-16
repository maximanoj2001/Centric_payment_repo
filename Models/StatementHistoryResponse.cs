namespace Centric_Payment_API.Models
{
    public class StatementHistoryResponse
    {
        public int? ResponseCode { get; set; }
        public bool? IsSuccess { get; set; }
        public StatementData? data { get; set; }
        public string? Message { get; set; }
    }
}


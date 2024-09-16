namespace Centric_Payment_API.Models
{
    public class UsageData
    {
        public int? ErrorCode { get; set; }
        public string? ErrorMessage { get; set; }
        public int? LocalAcccNo { get; set; }
        public string? LocalAccName { get; set; }
        public int? FilteredUsageCount { get; set; }
    }
}


using System.ComponentModel.DataAnnotations;

namespace Centric_Payment_API.DataBase
{
    public class UsageHistorySource
    {
        [Key]
        public int? account_no { get; set; }
        public int? location_no { get; set; }
        public string? date_installed { get; set; }
        public int? meter_no { get; set; }
        public int? MIU_number { get; set; }
        public string? manufacturer { get; set; }
        public int? model_no { get; set; }
        public string? end_read_date { get; set; }
        public int? actual_usage { get; set; }
        public int? start_read { get; set; }
        public int? end_read { get; set; }
        public string? city { get; set; }
        public int? reading_days { get; set; }
        public string? revenue_class { get; set; }
        }
    }

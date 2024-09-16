using System.ComponentModel.DataAnnotations;

namespace Centric_Payment_API.DataBase
{
    public class UsageHistoryRecord

    {
        public int? recorded_id { get; set; }
        public int? old_acct_id { get; set; }
        public string? salesforce_acct_id { get; set; }
        public int? billable_acct_no { get; set; }
        public string? client_billable_acct_id { get; set; }
        public int? plan_instance_id { get; set; }
        public string? client_plan_instance_id { get; set; }
        public int? usage_type_no { get; set; }
        public string? usage_type_description { get; set; }
        public string? usage_date { get; set; }
        public string? usage_time { get; set; }
        public int? units { get; set; }
        public string? units_description { get; set; }
        public string? usage_units_description { get; set; }
        public int? invoice_no { get; set; }
        public string? telco_To { get; set; }
        public string? telco_from { get; set; }
        public string? is_excluded { get; set; }
        public string? qualifier_1 { get; set; }
        public string? qualifier_2 { get; set; }
        public string? qualifier_3 { get; set; }
        public string? qualifier_4 { get; set; }
        public int? recorded_units { get; set; }
        public int? usage_record_no { get; set; }
        public string? usage_type_code { get; set; }
        public string? client_record_id { get; set; }
        public int? master_plan_instance_no { get; set; }
        public string? client_master_plan_instance_id { get; set; }
        public int? acct_locale_no { get; set; }
        public string? acct_locale_name { get; set; }
        public int? filtered_usage_count { get; set; }
        public int? location_no { get; set; }
        public string? date_installed { get; set; }
        public string? meter_no { get; set; }
        public string? MIU_no { get; set; }
        public string? manufacturer { get; set; }
        public string? model_no { get; set; }
        public string? end_read_date { get; set; }
        public int? actual_usage { get; set; }
        public int? start_read { get; set; }
        public int? end_read { get; set; }
        public int? reading_days { get; set; }
        public string? city { get; set; }
        public string? revenue_class { get; set; }



    }
}

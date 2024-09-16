using System.ComponentModel.DataAnnotations;

namespace Centric_Payment_API.DataBase
{
    public class StatementHistoryRecord
    {
        public int? recorded_id { get; set; }
        public int? statement_no { get; set; }
        public string? salesforce_acct_id { get; set; }
        public int? old_acct_id { get; set; }   
        public string? create_date { get; set; }
        public string? currency_cd { get; set; }
        public string? due_date { get; set; }
        public string? due_date_plus_grace_period { get; set; }
        public string? usage_type_description { get; set; }
        public int? new_charges_amount { get; set; }
        public int? new_payments_account { get; set; }
        public int? balance_forward_amount { get; set; }
        public int? total_amount { get; set; }
        public int? is_paid_ind { get; set; }
        public string? seq_statement_id { get; set; }
        public int? master_plan_instance_no { get; set; }
        public string? client_master_plan_instance_id { get; set; }
        public int? invoice_no { get; set; }
        public int? unapplied_pament_summary { get; set; }
        public int? account_balance { get; set; }
        public string? sent_status { get; set; }
        public string? date_sent { get; set; }
    }
}

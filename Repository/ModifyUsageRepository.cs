using Centric_Payment_API.DataBase;
using Centric_Payment_API.Interface;
using Centric_Payment_API.Models;
using Microsoft.EntityFrameworkCore;


namespace Centric_Payment_API.Repository  
{ 
    public class ModifyUsageRepository : IModifyUsgaeRepository                                              
    { 
        public readonly UsageEntities _usageEntities;                                                 
        public ModifyUsageRepository(UsageEntities usageEntities)                                          
        {
            _usageEntities = usageEntities;                           
        }
        public IEnumerable<UsageHistoryRecord> UpdateUsageHistory(string client_acct_id, string date_range_start, string date_range_end)
        {
            var records = _usageEntities.usageHistory?
       .FromSqlRaw("SELECT * FROM usageHistory WHERE salesforce_acct_id = {0} AND end_read_date  BETWEEN {1} AND {2}", client_acct_id, date_range_start, date_range_end)
       .ToList();
            if (records.Any())
            {
                var dbResult = records.First();
                UsageHistoryRecord usageHistory = new UsageHistoryRecord();
                {
                    usageHistory.recorded_id=dbResult.recorded_id;
                    usageHistory.salesforce_acct_id = dbResult.salesforce_acct_id;
                    usageHistory.billable_acct_no = dbResult.billable_acct_no;
                    usageHistory.client_billable_acct_id = dbResult.client_billable_acct_id;
                    usageHistory.plan_instance_id = dbResult.plan_instance_id;
                    usageHistory.client_plan_instance_id = dbResult.client_plan_instance_id;
                    usageHistory.usage_type_no = dbResult.usage_type_no;
                    usageHistory.usage_type_description = dbResult.usage_type_description;
                    usageHistory.usage_date = dbResult.usage_date;
                    usageHistory.usage_time = dbResult.usage_time;
                    usageHistory.units = dbResult.units;
                    usageHistory.units_description = dbResult.units_description;
                    usageHistory.invoice_no = dbResult.invoice_no;
                    usageHistory.telco_To = dbResult.telco_To;
                    usageHistory.telco_from = dbResult.telco_from;
                    usageHistory.is_excluded = dbResult.is_excluded;
                    usageHistory.qualifier_1 = dbResult.qualifier_1;
                    usageHistory.qualifier_2 = dbResult.qualifier_2;
                    usageHistory.qualifier_3 = dbResult.qualifier_3;
                    usageHistory.qualifier_4 = dbResult.qualifier_4;
                    usageHistory.recorded_units = dbResult.recorded_units;
                    usageHistory.usage_record_no = dbResult.usage_record_no;
                    usageHistory.usage_type_code = dbResult.usage_type_code;
                    usageHistory.client_record_id = dbResult.client_record_id;
                    usageHistory.master_plan_instance_no = dbResult.master_plan_instance_no;
                    usageHistory.client_master_plan_instance_id = dbResult.client_master_plan_instance_id;
                    usageHistory.acct_locale_no = dbResult.acct_locale_no;
                    usageHistory.acct_locale_name= dbResult.acct_locale_name;
                    usageHistory.filtered_usage_count=dbResult.filtered_usage_count;



                }
                return records;
            }

            else
                return null;

        }             
    }
} 

using Centric_Payment_API.DataBase;
using Centric_Payment_API.Interface;

namespace Centric_Payment_API.Services
{
    public class UsageHistory : IUsageHistory
    {
        public readonly IModifyUsgaeRepository _modifyUsageHistory;
        public readonly UsageEntities _usageEntities;
        public UsageHistory(IModifyUsgaeRepository modifyUsageHistory,UsageEntities usageEntities)
        {
            _modifyUsageHistory = modifyUsageHistory;
            _usageEntities = usageEntities;
        }

        public IEnumerable<UsageHistoryRecord> ModifyUsageHistory(string client_acct_id, string date_range_start, string date_range_end)

        {
            var result = _usageEntities.usageHistory?.Where(a => a.salesforce_acct_id == client_acct_id).ToList();

            if (result.Any())
            {
                var usageHistoryRecord = _modifyUsageHistory.UpdateUsageHistory(client_acct_id, date_range_start, date_range_end);
                return usageHistoryRecord;
            }
            return null;
        }
    }
}

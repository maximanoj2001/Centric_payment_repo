using Centric_Payment_API.Models;
using Centric_Payment_API.DataBase;

namespace Centric_Payment_API.Interface
{
    public interface IUsageHistory
    {
        IEnumerable<UsageHistoryRecord> ModifyUsageHistory(string client_acct_id, string date_range_start, string date_range_end); 
        
    }
}

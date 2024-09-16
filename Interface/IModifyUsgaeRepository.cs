using Centric_Payment_API.Models;
using Centric_Payment_API.DataBase;

namespace Centric_Payment_API.Interface
{
    public interface IModifyUsgaeRepository
    {
        IEnumerable<UsageHistoryRecord>UpdateUsageHistory(string client_Master_Plan_Instance_Id, string date_range_start, string date_range_end);
    }
}

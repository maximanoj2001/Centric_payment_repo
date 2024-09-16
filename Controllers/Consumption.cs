using Centric_Payment_API.Interface;               
using Centric_Payment_API.Models;         
using Centric_Payment_API.Services;                   
using Microsoft.AspNetCore.Mvc;    
using System.Runtime.InteropServices ;
using Centric_Payment_API.DataBase;

namespace Centric_Payment_API.Controllers                 
{
    [ApiVersion("1.0")]
    [Route("api/v1")]

    public class Consumption : Controller
    {
        public readonly IUsageHistory _usageHistory;
        public Consumption(IUsageHistory usageHistory)
        {
            _usageHistory = usageHistory;
        }

        [HttpPost, Route("consumption/view-usage-history")]
        
        public IEnumerable<UsageHistoryRecord> UpdateUsageHistory(string client_acct_id, string date_range_start,string date_range_end)
        {
           var result = _usageHistory.ModifyUsageHistory(client_acct_id, date_range_start,date_range_end);
            return result;
        }
    }
}


using Centric_Payment_API.DataBase;
using Centric_Payment_API.Interface;
using Centric_Payment_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Centric_Payment_API.Controllers
{    
        [ApiVersion("1.0")]
        [Route("api/v1")]

    public class Statement : Controller
    {
    public readonly IStatementHistory _statementHistory;
    public Statement(IStatementHistory statementHistory)
    {
        _statementHistory = statementHistory;
    }


        [HttpPost, Route("statements/view-statement-history")]

        public IEnumerable<StatementHistoryRecord> ViewStatementHistory(string client_acct_id, string start_date, string end_date)
        {
            var result = _statementHistory.ModifyStatementHistory(client_acct_id, start_date,end_date);
            return result;
        }
    }
}






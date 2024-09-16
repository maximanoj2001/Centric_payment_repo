﻿using Centric_Payment_API.DataBase;
using Centric_Payment_API.Models;

namespace Centric_Payment_API.Interface
{
    public interface IStatementHistory
    {
        IEnumerable<StatementHistoryRecord> ModifyStatementHistory(string client_acct_id, string start_date, string end_date);

    }
}



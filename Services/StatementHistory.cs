using Centric_Payment_API.DataBase;
using Centric_Payment_API.Interface;

namespace Centric_Payment_API.Services
{
    public class StatementHistory : IStatementHistory

    {
        public readonly IModifyStatementRepository _modifyStatementRepository;
        public readonly StatementEntities _statementEntities;
        public StatementHistory(IModifyStatementRepository modifyStatementRepository, StatementEntities statementEntities)
        { 
            _modifyStatementRepository = modifyStatementRepository;           
            _statementEntities = statementEntities;
        }

        public IEnumerable<StatementHistoryRecord> ModifyStatementHistory(string client_acct_id, string start_date, string end_date)
        {
           

            var result = _statementEntities.StatementHistoryRecord?.Where(a => a.salesforce_acct_id == client_acct_id).ToList();
            if (result.Any())
            {
                var statementhistoryrecord = _modifyStatementRepository.ViewStatementHistory(client_acct_id, start_date, end_date);
                return statementhistoryrecord;
            }
            return null;

        }
    } 
    
}


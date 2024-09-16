using Centric_Payment_API.DataBase;
using Centric_Payment_API.Interface;
using Centric_Payment_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Centric_Payment_API.Repository
{
    public class ModifyStatementRepository : IModifyStatementRepository
    {
        
            public readonly StatementEntities _statementEntities;
            public ModifyStatementRepository(StatementEntities statementEntities)
            {
                _statementEntities = statementEntities;
            }
            public IEnumerable<StatementHistoryRecord> ViewStatementHistory(string client_acct_id, string start_date, string end_date)
            {
            var records = _statementEntities.StatementHistoryRecord?
        .FromSqlRaw("SELECT * FROM StatementHistoryRecord WHERE salesforce_acct_id = {0} AND create_date BETWEEN {1} AND {2}", client_acct_id, start_date, end_date)
        .ToList();
            if (records.Any())
            {
                var dbResult = records.First();
                StatementHistoryRecord statementHistoryRecord = new StatementHistoryRecord();
                {
                    statementHistoryRecord.recorded_id = dbResult.recorded_id;
                    statementHistoryRecord.statement_no = dbResult.statement_no;
                    statementHistoryRecord.salesforce_acct_id = dbResult.salesforce_acct_id;
                    statementHistoryRecord.create_date = dbResult.create_date;
                    statementHistoryRecord.currency_cd = dbResult.currency_cd;
                    statementHistoryRecord.due_date = dbResult.due_date;
                    statementHistoryRecord.due_date_plus_grace_period = dbResult.due_date_plus_grace_period;
                    statementHistoryRecord.new_charges_amount = dbResult.new_charges_amount;
                    statementHistoryRecord.new_payments_account = dbResult.new_payments_account;
                    statementHistoryRecord.balance_forward_amount = dbResult.balance_forward_amount;
                    statementHistoryRecord.total_amount = dbResult.total_amount;
                    statementHistoryRecord.is_paid_ind = dbResult.is_paid_ind;
                    statementHistoryRecord.seq_statement_id = dbResult.seq_statement_id;
                    statementHistoryRecord.master_plan_instance_no = dbResult.master_plan_instance_no;
                    statementHistoryRecord.client_master_plan_instance_id = dbResult.client_master_plan_instance_id;


                }
                return records;
            }

            else
                return null;
        }
        }
}

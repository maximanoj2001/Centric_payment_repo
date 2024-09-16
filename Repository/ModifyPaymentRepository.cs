using Centric_Payment_API.DataBase;
using Centric_Payment_API.Interface;
using Centric_Payment_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Centric_Payment_API.Repository
{
    public class ModifyPaymentRepository : IModifyPaymentRepository
    {
        public readonly PaymentEntities _paymentEntities;
        public ModifyPaymentRepository(PaymentEntities paymentEntities)
        {
            _paymentEntities = paymentEntities;
        }
        //public IEnumerable<PaymentHistoryRecord> ViewPaymentHistory(string client_acct_id, string start_date, string end_date)

        //{
        //    var records = _paymentEntities.PaymentHistoryRecord?
        //   .FromSqlRaw("SELECT * FROM PaymentHistoryRecord WHERE salesforce_acct_id = {0} AND transaction_create_date  BETWEEN {1} AND {2}", client_acct_id, start_date, end_date)
        //   .ToList();
        //    if (records.Any())
        //    {
        //        var dbResult = records.First();
        //        PaymentHistoryRecord paymentHistoryRecord = new PaymentHistoryRecord();
        //        {
        //            paymentHistoryRecord.recorded_id = dbResult.recorded_id;
        //            paymentHistoryRecord.transaction_id = dbResult.transaction_id;
        //            paymentHistoryRecord.salesforce_acct_id = dbResult.salesforce_acct_id;
        //            paymentHistoryRecord.transaction_type = dbResult.transaction_type;
        //            paymentHistoryRecord.transaction_desc = dbResult.transaction_desc;
        //            paymentHistoryRecord.transaction_amount = dbResult.transaction_amount;
        //            paymentHistoryRecord.transaction_applied_amount = dbResult.transaction_applied_amount;
        //            paymentHistoryRecord.transaction_currency = dbResult.transaction_currency;
        //            paymentHistoryRecord.transaction_create_date = dbResult.transaction_create_date;
        //            paymentHistoryRecord.statement_no = dbResult.statement_no;
        //            paymentHistoryRecord.client_receipt_id = dbResult.client_receipt_id;
        //            paymentHistoryRecord.transaction_comments = dbResult.transaction_comments;
        //            paymentHistoryRecord.transaction_source_id = dbResult.transaction_source_id;
        //            paymentHistoryRecord.transaction_ref_code = dbResult.transaction_ref_code;
        //        }
        //        return records;
        //    }

        //    else
        //    {
        //        return null;
        //    }
        //}
        public IEnumerable<PaymentHistoryRecord> ViewPaymentHistory(string client_acct_id, string start_date, string end_date)
        {
            // Query the database
            var records = _paymentEntities.PaymentHistoryRecord?
                .FromSqlRaw("SELECT * FROM PaymentHistoryRecord WHERE salesforce_acct_id = {0} AND transaction_create_date BETWEEN {1} AND {2}", client_acct_id, start_date, end_date)
                .ToList();

            // Return an empty collection if no records are found
            if (records == null || !records.Any())
            {
                return Enumerable.Empty<PaymentHistoryRecord>();
            }

            // Create a list to hold the processed records
            var processedRecords = new List<PaymentHistoryRecord>();

            foreach (var dbResult in records)
            {
                var paymentHistoryRecord = new PaymentHistoryRecord
                {
                    recorded_id = dbResult.recorded_id,
                    transaction_id = dbResult.transaction_id,
                    salesforce_acct_id = dbResult.salesforce_acct_id,
                    transaction_type = dbResult.transaction_type,
                    transaction_desc = dbResult.transaction_desc,
                    transaction_amount = dbResult.transaction_amount,
                    transaction_applied_amount = dbResult.transaction_applied_amount,
                    transaction_currency = dbResult.transaction_currency,
                    transaction_create_date = dbResult.transaction_create_date,
                    statement_no = dbResult.statement_no,
                    client_receipt_id = dbResult.client_receipt_id,
                    transaction_comments = dbResult.transaction_comments,
                    transaction_source_id = dbResult.transaction_source_id,
                    transaction_ref_code = dbResult.transaction_ref_code
                };

                processedRecords.Add(paymentHistoryRecord);
            }

            return processedRecords;
        }

    }
}


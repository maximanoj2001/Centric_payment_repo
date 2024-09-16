using Centric_Payment_API.DataBase;
using Centric_Payment_API.Interface; 
using Centric_Payment_API.Models;

namespace Centric_Payment_API.Services
{
    public class PaymentHistory : IPaymentHistory
    {
        public readonly IModifyPaymentRepository _modifyPaymentHistoryRepository;
        public readonly PaymentEntities _paymentEntities;
        public PaymentHistory(IModifyPaymentRepository modifyPaymentHistoryRepository,PaymentEntities paymentEntities)
        {
            _modifyPaymentHistoryRepository = modifyPaymentHistoryRepository;
            _paymentEntities = paymentEntities;

        }
        public IEnumerable<PaymentHistoryRecord> ModifyPaymentHistory(string client_acct_id, string start_date, string end_date)
        {
        

            var result = _paymentEntities.PaymentHistoryRecord?.Where(a => a.salesforce_acct_id == client_acct_id).ToList();

            if(result.Any())
                {
                var paymentHistoryRecord = _modifyPaymentHistoryRepository.ViewPaymentHistory(client_acct_id, start_date, end_date);
                return paymentHistoryRecord;
                }
            return null;
        }
    }
}



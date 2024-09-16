using Centric_Payment_API.DataBase;
namespace Centric_Payment_API.Interface
{
    public interface IPaymentHistory
    {
        IEnumerable<PaymentHistoryRecord> ModifyPaymentHistory(string client_acct_id,  string start_date, string end_date);
    }
}
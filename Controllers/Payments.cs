//using Centric_Payment_API.DataBase;
//using Centric_Payment_API.Interface;
//using Microsoft.AspNetCore.Mvc;
//namespace Centric_Payment_API.Controllers
//{
//    [ApiVersion("1.0")]
//    [Route("api/v1")]
//    public class Payments : Controller
//    {

//        public readonly IPaymentHistory _paymentHistory;    
//        public Payments(IPaymentHistory paymentHistory)
//        {
//            _paymentHistory = paymentHistory;
//        }
//        [HttpPost, Route("payments/view-payment-history")]

//        // public IEnumerable<PaymentHistoryRecord>ViewPaymentHistory(string client_acct_id, string start_date, string end_date)
//        // {
//        //  var result = _paymentHistory.ModifyPaymentHistory(client_acct_id, start_date, end_date);
//        //    return result;
//        // }

//         public IEnumerable<PaymentHistoryRecord> ViewPaymentHistory([FromBody] PaymentHistoryReq request)
//        {
//            var result = _paymentHistory.ModifyPaymentHistory(request.client_acct_id, request.start_date, request.end_date);
//            return result;
//        }
//    }
//}

using Centric_Payment_API.DataBase;
using Centric_Payment_API.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Centric_Payment_API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v1")]
    [ApiController]  // This is crucial to enable the API behavior
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentHistory _paymentHistory;

        public PaymentsController(IPaymentHistory paymentHistory)
        {
            _paymentHistory = paymentHistory;
        }

        [HttpPost("payments/view-payment-history")]
        public IActionResult ViewPaymentHistory([FromBody] PaymentHistoryReq request)
        {
            if (request == null)
            {
                return BadRequest("Invalid request.");
            }

            var result = _paymentHistory.ModifyPaymentHistory(request.client_acct_id, request.start_date, request.end_date);

            return Ok(result);
        }
    }
}








using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using WAT.Admin.ValueObjects;

namespace WAT.Admin.Controllers
{
    public class BaseApiController : ApiController
    {
        public BaseApiController()
        {
        }

        protected string GetUri()
        {
            return Request.RequestUri.AbsoluteUri.Replace(Request.RequestUri.PathAndQuery, String.Empty);
        }

        /// <summary>
        /// Executes the specified service action.
        /// </summary>
        /// <typeparam name="K">Desired response type.</typeparam>
        /// <param name="serviceAction">The service action.</param>
        /// <returns>Response of desired type.</returns>
        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes",
            Justification = "Service methods should not return exceptions.")]
        protected ResponseData<K> Execute<K>(Func<K> serviceAction)
        {
            try
            {
                using (var tran = new System.Transactions.TransactionScope())
                {
                    var result = ResponseData<K>.CreateSuccessResponse(serviceAction.Invoke());
                    tran.Complete();
                    return result;
                }
            }
            catch (CustomBusinessException ex)
            {
                return ResponseData<K>.CreateErrorResponse(ex);
            }
            catch (UnauthorizedAccessException)
            {
                return ResponseData<K>.CreateAccessDeniedResponse();
            }
            catch (Exception ex)

            {
                return ResponseData<K>.CreateFatalResponse(ex.ToString());
            }
        }
    }
}
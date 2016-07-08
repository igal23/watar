using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WAT.Admin.ValueObjects
{
    [DataContract]
    public abstract class ResponseData
    {
        /// <summary>
        /// State of the request. Possible values are enumerated under StatusNames.
        /// </summary>
        [DataMember(Name = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Message to be displayed with the response.
        /// </summary>
        [DataMember(Name = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Code of the message to be displayed with the response. Used to provide multi-language messages.
        /// </summary>
        [DataMember(Name = "messageCode")]
        public string MessageCode { get; set; }

        /// <summary>
        /// Enumeration of possible DPNResponse states.
        /// </summary>
        public static class StatusNames
        {
            /// <summary>
            /// The request was performed without errors.
            /// </summary>
            public const string Success = "success";

            /// <summary>
            /// There were business errors during the execution of the request (ie: validation failed).
            /// </summary>
            public const string Error = "error";

            /// <summary>
            /// There were application errors during the execution of the request (ie: underlying service unavailable).
            /// </summary>
            public const string Fatal = "fatal";

            /// <summary>
            /// There were application unauthorized access during the execution of the request.
            /// </summary>
            public const string AccessDenied = "access-denied";
        }
    }

    /// <summary>
    /// Response wrapper that provides additional information of the status of the server on the response.
    /// </summary>
    /// <typeparam name="T">Results type to be wrapped into the response.</typeparam>
    public class ResponseData<T> : ResponseData
    {
        /// <summary>
        /// Response data to be used by the client.
        /// </summary>
        [DataMember(Name = "data")]
        public T Data { get; set; }

        public static ResponseData<T> CreateSuccessResponse(T data)
        {
            return new ResponseData<T>
            {
                Status = StatusNames.Success,
                Data = data
            };
        }

        public static ResponseData<T> CreateErrorResponse(CustomBusinessException ex)
        {
            return new ResponseData<T>
            {
                Status = StatusNames.Error,
                Message = ex.Message
            };
        }

        public static ResponseData<T> CreateFatalResponse(string errorMessage)
        {
            return new ResponseData<T>
            {
                Status = StatusNames.Fatal,
                Message = errorMessage
            };
        }

        public static ResponseData<T> CreateAccessDeniedResponse()
        {
            return new ResponseData<T>
            {
                Status = StatusNames.AccessDenied,
                Message = "You do not have permission to access this module."
            };
        }
    }
}
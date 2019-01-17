using System;
using System.Collections.Generic;
using System.Linq;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Exceptions;

namespace Technoforte.PALMS.WebServices
{
    [Serializable]
    public enum ServiceErrorType
    {
        NONE,
        REGISTER_ERROR,
        READ_ERROR,
        CACHE_PAGE_DATA_ERROR,
        GET_CACHED_DATA_ERROR,
        CLEAR_CACHED_DATA_ERROR,
        DEREGISTER_ERROR,
        PERFORMACTION_ERROR,
        EXPORT_TO_EXCEL_ERROR,
        SESSION_EXPIRY_ERROR
    }

    [Serializable]
    public enum ErrorCategory
    {
        SUCCESS,
        BUSINESS_LOGIC_ERROR,
        EXCEPTION
    }

    [Serializable]
    public class ErrorInformation
    {
        public ErrorCategory errorCategory { get; set; }
        public ServiceErrorType errorType { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public DateTime occurredAt { get; set; }
        public string source { get; set; }
        public string trace { get; set; }

        public bool isError
        {
            get { return (errorCategory != ErrorCategory.SUCCESS); }
        }

        public ErrorInformation() : this("", "")
        {
            ;
        }

        public ErrorInformation(string shortDescription, string longDescription)
        {
            SetErrorCategory(null);
            this.errorType = ServiceErrorType.NONE;
            this.shortDescription = shortDescription;
            this.longDescription = longDescription;
        }

        public ErrorInformation(Exception e, ServiceErrorType errorType)
        {
            SetErrorCategory(e);
            this.errorType = errorType;
        }

        public ErrorInformation(Exception e, ServiceErrorType errorType, string longDescription)
        {
            SetErrorCategory(e);
            this.errorType = errorType;
            this.longDescription = longDescription;
        }

        private void SetErrorCategory(Exception e)
        {
            this.occurredAt = DateTime.Now;

            if (e == null)
            {
                this.errorCategory = ErrorCategory.SUCCESS;
                this.source = "";
                this.trace = "";
            }
            else if (typeof(DalException).IsInstanceOfType(e) 
                || typeof(ValidationException).IsInstanceOfType(e) 
                || typeof(ComponentException).IsInstanceOfType(e) 
                || typeof(ServiceException).IsInstanceOfType(e))
            {
                this.errorCategory = ErrorCategory.BUSINESS_LOGIC_ERROR;
                this.source = "";
                this.trace = "";
                this.shortDescription = e.Message;

                if (typeof(ValidationException).IsInstanceOfType(e))
                {
                    ValidationException validationException = (ValidationException)e;
                    this.shortDescription = validationException.validationResults.GetString();
                }
            }
            else
            {
                this.errorCategory = ErrorCategory.EXCEPTION;
                this.source = "";
                this.trace = e.StackTrace;
                this.shortDescription = e.Message;
                this.longDescription = e.ToString();
            }
        }
    }
}
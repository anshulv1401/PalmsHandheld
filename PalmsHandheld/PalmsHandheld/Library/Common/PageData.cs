using System;
using System.Collections.Generic;
using System.Linq;
using Technoforte.PALMS.Entities;

namespace Technoforte.PALMS.WebServices
{
    [Serializable]
    public class PageData<T> where T : Entity
    {
        public long pagingClientID { get; set; }
        public List<T> data { get; set; }
        public ErrorInformation error { get; set; }

        public PageData()
        {
            this.error = new ErrorInformation("", "");
        }

        public PageData(long pagingClientID, List<T> data)
        {
            this.error = new ErrorInformation("", "");
            this.data = data;
            this.pagingClientID = pagingClientID;
        }

        public PageData(long pagingClientID, Exception e, ServiceErrorType errorType)
        {
            this.error = new ErrorInformation(e, errorType);
            this.data = null;
            this.pagingClientID = pagingClientID;
        }

        public PageData(long pagingClientID, ErrorInformation errorInfo)
        {
            this.error = errorInfo;
            this.data = null;
            this.pagingClientID = pagingClientID;
        }
    }
}

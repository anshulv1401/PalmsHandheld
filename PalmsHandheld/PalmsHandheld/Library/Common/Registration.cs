using System;
using System.Collections.Generic;
using System.Linq;

namespace Technoforte.PALMS.WebServices
{
    [Serializable]
    public class Registration
    {
        public long pagingClientID { get; set; }
        public ErrorInformation error { get; set; }

        public Registration()
        {
            error = new ErrorInformation("", "");
        }

        public Registration(long pagingClientID)
        {
            this.error = new ErrorInformation("", "");
            this.pagingClientID = pagingClientID;
        }

        public Registration(Exception e, ServiceErrorType errorType)
        {
            this.error = new ErrorInformation(e, errorType);
            this.pagingClientID = -1;
        }
    }
}

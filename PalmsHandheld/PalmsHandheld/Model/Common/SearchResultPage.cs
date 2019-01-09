using System;
using System.Collections.Generic;
using System.Linq;
using Technoforte.PALMS.Entities;

namespace Technoforte.PALMS.WebServices
{
    [Serializable]
    public class SearchResultPage<T> where T : Entity
    {
        public long pagingClientID { get; set; }
        public List<T> pageData { get; set; }
        public long totalPages { get; set; }
        public long totalRecords { get; set; }
        public long pageNo { get; set; }
        public long firstRecordNo { get; set; }
        public long lastRecordNo { get; set; }
        public string sortKey { get; set; }
        public bool isSortAscending { get; set; }
        public ErrorInformation error { get; set; }

        public SearchResultPage()
        {
            this.error = new ErrorInformation("", "");
        }

        public SearchResultPage(long pagingClientID, int pageNo, long limit, string sortKey, bool isSortAscending, List<T> pageData, int totalRecords)
        {
            this.error = new ErrorInformation("", "");
            this.firstRecordNo = (pageNo - 1) * limit + 1;
            this.lastRecordNo = pageNo * limit;
            this.isSortAscending = isSortAscending;
            this.pageData = pageData;
            this.pageNo = pageNo;
            this.pagingClientID = pagingClientID;
            this.sortKey = sortKey;
            this.totalPages = totalRecords % limit == 0 ? totalRecords / limit : totalRecords / limit + 1;
            this.totalRecords = totalRecords;
        }

        public SearchResultPage(long pagingClientID, Exception e, ServiceErrorType errorType, string sortKey, bool isSortAscending)
        {
            this.error = new ErrorInformation(e, errorType);
            this.firstRecordNo = 0;
            this.lastRecordNo = 0;
            this.isSortAscending = isSortAscending;
            this.pageData = null;
            this.pageNo = pageNo;
            this.pagingClientID = pagingClientID;
            this.sortKey = sortKey;
            this.totalPages = 0;
            this.totalRecords = 0;
        }

        public SearchResultPage(long pagingClientID, ErrorInformation error, string sortKey, bool isSortAscending)
        {
            this.error = error;
            this.firstRecordNo = 0;
            this.lastRecordNo = 0;
            this.isSortAscending = isSortAscending;
            this.pageData = null;
            this.pageNo = pageNo;
            this.pagingClientID = pagingClientID;
            this.sortKey = sortKey;
            this.totalPages = 0;
            this.totalRecords = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Technoforte.PALMS.Entities;

namespace Technoforte.PALMS.WebServices
{
    public interface ISearchAndActionProvider<E>
        where E : Entity
    {
        Registration Register(int pageSize);
        SearchResultPage<E> SearchRecords(long pagingClientID, E searchCriteria, long offset, string sortKey, bool isSortAscending);
        SearchResultPage<E> CachePageDataAndSearchRecords(long pagingClientID, E searchCriteria, long offset, string sortKey, bool isSortAscending, List<E> dataToBeCached);
        ErrorInformation CachePageData(long pagingClientID, List<E> dataToBeCached);
        PageData<E> GetCachedPageData(long pagingClientID);
        PageData<E> GetCachedPageDataAndWipeCache(long pagingClientID);
        PageData<E> GetCachedPageDataAndDeregister(long pagingClientID);
        ErrorInformation WipeCache(long pagingClientID);
        ErrorInformation Deregister(long pagingClientID);
        ErrorInformation PerformAction(long pagingClientID, string action);
        ErrorInformation PerformActionWithData(List<E> data, string action);
    }
}

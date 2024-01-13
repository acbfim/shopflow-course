using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopflow.contract.Model.Entities.Global;

namespace shopflow.contract.Extensions
{
    public static class EnumerableExtensions
    {
        public static PagedList<T> ToPagedList<T>(this IEnumerable<T> source, bool stillFetchable = false, int totalItems = 0)
        {
            if(source is null)
                throw new ArgumentNullException($"{nameof(source)} cannot be null");

            return new PagedList<T>(source, stillFetchable, totalItems);
        }
    }
}
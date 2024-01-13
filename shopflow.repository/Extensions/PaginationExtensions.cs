using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopflow.repository.Extensions
{
    public static class PaginationExtensions
    {
        public static IQueryable<T> AsPagination<T>(this IQueryable<T> query, int page, int itemsPerPage)
        {
            return query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);
        }
    }
}
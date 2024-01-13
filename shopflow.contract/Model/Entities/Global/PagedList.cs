using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopflow.contract.Model.Entities.Global
{
    public class PagedList<T>
    {
        public IEnumerable<T> Elements { get; set; }
        public bool StillFetchable { get; set; }
        public int TotalItems { get; set; }

        public PagedList(bool stillFetchable = false)
        {
            StillFetchable = stillFetchable;
            Elements = new List<T>();
        }

        public PagedList(IEnumerable<T> collection, bool stillFetchable = false, int totalItems = 0) : this(stillFetchable)
        {
            Elements = collection;
            TotalItems = totalItems;
        }

        public PagedList(int capacity, bool stillFetchable = false) : this (stillFetchable)
        {
            Elements = new List<T>(capacity);
            StillFetchable = stillFetchable;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shopflow.contract.Constants;
using shopflow.contract.Extensions;
using shopflow.contract.Model.Entities.Customer;
using shopflow.contract.Model.Entities.Global;
using shopflow.repository.Contexts;
using shopflow.repository.Contracts;
using shopflow.repository.Extensions;

namespace shopflow.repository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        private readonly DefaultContext _context;

        public CustomerRepository(DefaultContext context) : base(context)
        {
            _context = context;
        }

        public async Task<PagedList<Customer>> GetAll(int page = PageConstants.MIN_PAGE, int itemsPerPage = PageConstants.MIN_ITEMS, bool includeContacts = false, bool includeDocuments = false, bool includeAddresses = false)
        {
            IQueryable<Customer> query = _context.Customers.AsNoTracking();

            var totalRecords = await query.CountAsync();

            if (includeContacts)
                query = query.Include(x => x.Contacts);

            if (includeDocuments)
                query = query.Include(x => x.Documents);

            if (includeAddresses)
                query = query.Include(x => x.Addresses);

            var result = query.AsPagination(page,itemsPerPage);
            var list = await result.ToListAsync();

            var totalPages = (int)Math.Ceiling((double)totalRecords / itemsPerPage);

            return list.ToPagedList((page - 1) < totalPages - 1, totalRecords);
        }

        public async Task<Customer> GetById(long id, bool includeContacts = false, bool includeDocuments = false, bool includeAddresses = false)
        {
            IQueryable<Customer> query = _context.Customers.AsNoTracking();

            if (includeContacts)
                query = query.Include(x => x.Contacts);

            if (includeDocuments)
                query = query.Include(x => x.Documents);

            if (includeAddresses)
                query = query.Include(x => x.Addresses);

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<PagedList<Customer>> GetByName(string name, int page = PageConstants.MIN_PAGE, int itemsPerPage = PageConstants.MIN_ITEMS, bool includeContacts = false, bool includeDocuments = false, bool includeAddresses = false)
        {
            IQueryable<Customer> query = _context.Customers.AsNoTracking();

            query = query
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .Where(x => x.FullName.ToLower().Contains(name.ToLower()));

            var totalRecords = await query.CountAsync();

            if (includeContacts)
                query = query.Include(x => x.Contacts);

            if (includeDocuments)
                query = query.Include(x => x.Documents);

            if (includeAddresses)
                query = query.Include(x => x.Addresses);

            var list = await query.ToListAsync();

            var totalPages = (int)Math.Ceiling((double)totalRecords / itemsPerPage);

            return list.ToPagedList(page < totalPages - 1);
        }
    }
}
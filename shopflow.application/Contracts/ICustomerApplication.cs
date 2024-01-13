using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopflow.contract.Constants;
using shopflow.contract.Model.Entities.Customer;
using shopflow.contract.Model.Entities.Customer.Dtos;
using shopflow.contract.Model.Entities.Global;

namespace shopflow.application.Contracts
{
    public interface ICustomerApplication
    {
        public Task<Customer> Create(CreateCustomerDto customer);
        public Task<Customer> Update(Customer customer);
        public Task<bool> Delete(long id);

        public Task<PagedList<Customer>> GetAll(int page = PageConstants.MIN_PAGE, int itemsPerPage = PageConstants.MIN_ITEMS, bool includeContacts = false, bool includeDocuments = false, bool includeAddresses = false);
        public Task<Customer> GetById(long id, bool includeContacts = false, bool includeDocuments = false, bool includeAddresses = false);
        public Task<PagedList<Customer>> GetByName(string name, int page = PageConstants.MIN_PAGE, int itemsPerPage = PageConstants.MIN_ITEMS,bool includeContacts = false, bool includeDocuments = false, bool includeAddresses = false);

    }
}
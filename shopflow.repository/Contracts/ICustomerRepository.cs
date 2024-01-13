
using shopflow.contract.Constants;
using shopflow.contract.Model.Entities.Customer;
using shopflow.contract.Model.Entities.Global;

namespace shopflow.repository.Contracts
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        public Task<PagedList<Customer>> GetAll(int page = int.MinValue, int itemsPerPage = PageConstants.MIN_ITEMS, bool includeContacts = false, bool includeDocuments = false, bool includeAddresses = false);
        public Task<Customer> GetById(long id, bool includeContacts = false, bool includeDocuments = false, bool includeAddresses = false);
        public Task<PagedList<Customer>> GetByName(string name, int page = PageConstants.MIN_PAGE, int itemsPerPage = PageConstants.MIN_ITEMS,bool includeContacts = false, bool includeDocuments = false, bool includeAddresses = false);
    }
}
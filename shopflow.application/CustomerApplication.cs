using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using shopflow.application.Contracts;
using shopflow.contract.Constants;
using shopflow.contract.Exceptions;
using shopflow.contract.Model.Entities.Customer;
using shopflow.contract.Model.Entities.Customer.Dtos;
using shopflow.contract.Model.Entities.Global;
using shopflow.repository.Contracts;

namespace shopflow.application
{
    public class CustomerApplication : ICustomerApplication
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        public CustomerApplication(ICustomerRepository repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }
        public async Task<Customer> Create(CreateCustomerDto customer)
        {
            try
            {

                var customerMapped = _mapper.Map<Customer>(customer);

                _repository.AddAsync(customerMapped);

                if (await _repository.SaveChangesAsync())
                    return customerMapped;

                throw new Exception($"Error to create {nameof(Customer)}");

            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<Customer> Update(Customer customer)
        {
            try
            {
                var customerFound = await _repository.GetById(customer.Id);

                if(customerFound is null)
                    throw new EntityNotFoundException();

                
                _repository.Update(customer);

                if (await _repository.SaveChangesAsync())
                    return customer;

                throw new Exception($"Error to update {nameof(Customer)}");
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                var customerFound = await _repository.GetById(id);

                if (customerFound is null)
                    throw new Exception($"The {nameof(Customer)} not found with {id}.");

                _repository.Delete(customerFound);

                return await _repository.SaveChangesAsync();

            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<PagedList<Customer>> GetAll(int page = PageConstants.MIN_PAGE, int itemsPerPage = 10, bool includeContacts = false, bool includeDocuments = false, bool includeAddresses = false)
        {
            try
            {
                var list = await _repository.GetAll(page, itemsPerPage, includeContacts, includeDocuments, includeAddresses);
                return list;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<Customer> GetById(long id, bool includeContacts = false, bool includeDocuments = false, bool includeAddresses = false)
        {
            try
            {
                var customer = await _repository.GetById(id, includeContacts, includeDocuments, includeAddresses);

                return customer;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<PagedList<Customer>> GetByName(string name, int page = 1, int itemsPerPage = 10, bool includeContacts = false, bool includeDocuments = false, bool includeAddresses = false)
        {
            try
            {
                var list = await _repository.GetByName(name, page, itemsPerPage, includeContacts, includeDocuments, includeAddresses);
                return list;
            }
            catch (System.Exception)
            {
                throw;
            }
        }


    }
}
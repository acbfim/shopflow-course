using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopflow.contract.Model.Entities.Customer.Dtos
{
    public class CreateCustomerDto
    {
        public string FullName { get; set; }
        public List<CreateContactDto>? Contacts { get; set; }
        public List<CreateDocumentDto>? Documents { get; set; }
        public List<CreateAddressDto>? Addresses { get; set; }
    }
}
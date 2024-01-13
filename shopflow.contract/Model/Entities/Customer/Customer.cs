using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using shopflow.contract.Model.Entities.Global;

namespace shopflow.contract.Model.Entities.Customer
{
    public class Customer : BaseEntity
    {
        public string FullName { get; set; }

        public List<Contact>? Contacts { get; set; }
        public List<Document>? Documents { get; set; }
        public List<Address>? Addresses { get; set; }
    }
}
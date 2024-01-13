using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopflow.contract.Model.Entities.Customer.Dtos
{
    public class CreateAddressDto
    {
        public bool IsDefault { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string ReferencePoint { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
    }
}
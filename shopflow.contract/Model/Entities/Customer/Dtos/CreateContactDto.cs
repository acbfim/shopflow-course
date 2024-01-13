using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopflow.contract.Model.Entities.Customer.Dtos
{
    public class CreateContactDto
    {
        public string Value { get; set; }
        public long ContactTypeId { get; set; }
    }
}
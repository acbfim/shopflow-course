using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopflow.contract.Model.Entities.Customer.Dtos
{
    public class CreateDocumentDto
    {
        public string Value { get; set; }
        public string? UrlLocation { get; set; }
        public string? Filename { get; set; }

        public long DocumentTypeId { get; set; }
    }
}
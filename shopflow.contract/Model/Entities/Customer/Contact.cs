
using shopflow.contract.Model.Entities.Global;

namespace shopflow.contract.Model.Entities.Customer
{
    public class Contact : BaseEntity
    {
        public string Value { get; set; }

        public long ContactTypeId { get; set; }
        public ContactType ContactType { get; set; }
    }
}
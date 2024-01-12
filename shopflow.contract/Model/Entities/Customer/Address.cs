
using shopflow.contract.Model.Entities.Global;

namespace shopflow.contract.Model.Entities.Customer
{
    public class Address : BaseEntity
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

        public string FullAddress => string.Join(", ",
            (new [] { Street, Number, ReferencePoint, Country, $"{City}/{State}"} ).Where(s => 
                !string.IsNullOrEmpty(s)));
    }
}
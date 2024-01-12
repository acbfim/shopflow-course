using shopflow.contract.Model.Entities.Global;

namespace shopflow.contract.Model.Entities.Customer;

public class Document : BaseEntity
{
    public string Value { get; set; }
    public string? UrlLocation { get; set; }
    public string? Filename { get; set; }

    public long DocumentTypeId { get; set; }
    public DocumentType DocumentType { get; set; }

}

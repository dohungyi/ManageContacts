using ManageContacts.Model.Models.AddressTypes;
using ManageContacts.Model.Models.Contacts;

namespace ManageContacts.Model.Models.Addresses;

public class AddressModel
{
    public Guid Id { get; set; }
    public string Province { get; set; }
    public string Ward { get; set; }
    public string District { get; set; }
    public string Addresss { get; set; }
    public string? Type { get; set; }
    public string? FormattedType { get; set; }
    public Guid AddressTypeId { get; set; }
}
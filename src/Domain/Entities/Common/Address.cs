using Domain.Common;
using System.Reflection.Metadata;

namespace Domain.Entities.Common;

public class Address : BaseAuditableEntity
{

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string CountryId { get; set; }

    public string StateProvinceId { get; set; }
 
    public string City { get; set; }
  
    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string ZipPostalCode { get; set; }
  
    public string PhoneNumber { get; set; }

    public string FaxNumber { get; set; }

    public string Note { get; set; }

}

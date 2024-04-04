using Domain.Entities.Orders;

namespace Domain.Entities.Users;

public class User
{
    public string Username { get; set; }

    public string Email { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }


    public Address Address { get; set; }

}

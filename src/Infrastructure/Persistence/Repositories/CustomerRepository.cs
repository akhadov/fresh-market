using Domain.Customers;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class CustomerRepository : Repository<Customer, CustomerId>, ICustomerRepository
{
    private readonly ApplicationDbContext context;

    public CustomerRepository(ApplicationDbContext context) : base(context)
    {
        this.context = context;
    }

    public async Task<bool> IsEmailUniqueAsync(Email email)
    {
        return !await context.Customers.AnyAsync(c => c.Email == email);
    }

}

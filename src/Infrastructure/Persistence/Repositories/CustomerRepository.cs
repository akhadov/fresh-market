using Domain.Customers;

namespace Infrastructure.Persistence.Repositories;

public class CustomerRepository : Repository<Customer, CustomerId>, ICustomerRepository
{
    private readonly ApplicationDbContext context;

    public CustomerRepository(ApplicationDbContext context) : base(context)
    {
        this.context = context;
    }
}

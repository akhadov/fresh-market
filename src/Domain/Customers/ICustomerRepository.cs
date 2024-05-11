﻿using SharedKernel.Interfaces;

namespace Domain.Customers;

public interface ICustomerRepository : IRepository<Customer, CustomerId>
{
}

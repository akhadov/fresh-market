using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Basket;

public class BasketCheckout
{
    public string UserName { get; set; }
    public decimal TotalPrice { get; set; }

    public long AddressId { get; set; }
    public virtual Address? Address { get; set; }

}

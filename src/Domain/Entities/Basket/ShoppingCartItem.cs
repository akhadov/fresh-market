using Domain.Entities.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Basket;

public class ShoppingCartItem
{
    public int Quantity { get; set; }

    public decimal Total {  get; set; }

    public long ProductId { get; set; }
    public virtual Product? Product { get; set; }
}

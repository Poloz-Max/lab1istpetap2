using System;
using System.Collections.Generic;

namespace OrderingDomain.Model;

public partial class Good
{
    public int GoodsId { get; set; }

    public int PriceForOne { get; set; }

    public string GoodName { get; set; } = null!;

    public int Quantity { get; set; }

    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

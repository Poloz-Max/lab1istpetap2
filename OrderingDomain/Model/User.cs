using System;
using System.Collections.Generic;

namespace OrderingDomain.Model;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public int? PhoneNumber { get; set; }

    public int? GoodsShipping { get; set; }

    public virtual Good? GoodsShippingNavigation { get; set; }

    public virtual ICollection<Shipment> ShipmentShipmentSenderNavigations { get; set; } = new List<Shipment>();

    public virtual ICollection<Shipment> ShipmentShipmentWanterNavigations { get; set; } = new List<Shipment>();
}

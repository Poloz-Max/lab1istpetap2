using System;
using System.Collections.Generic;

namespace OrderingDomain.Model;

public partial class Shipment
{
    public int ShipmentId { get; set; }

    public string ShipmentName { get; set; } = null!;

    public DateTime ShipmentDate { get; set; }

    public int ShipmentSender { get; set; }

    public int TotalSum { get; set; }

    public int ShipmentWanter { get; set; }

    public int? GoodsId { get; set; }

    public virtual Good? Goods { get; set; }

    public virtual User ShipmentSenderNavigation { get; set; } = null!;

    public virtual User ShipmentWanterNavigation { get; set; } = null!;
}

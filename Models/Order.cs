namespace JPTrading.Web.Models;

public enum OrderStatus
{
    Placed,
    Confirmed,
    Shipped,
    InTransit,
    Customs,
    Delivered
}

public class Order
{
    public int Id { get; set; }
    public int VehicleId { get; set; }
    public string VehicleTitle { get; set; } = "";
    public string BuyerName { get; set; } = "";
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }
    public decimal TotalPkr { get; set; }
}
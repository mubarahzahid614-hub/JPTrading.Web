using JPTrading.Web.Models;

namespace JPTrading.Web.Services;

public class OrderService
{
    private readonly List<Order> _orders = new()
    {
        new() { Id = 1001, VehicleId = 1, VehicleTitle = "2018 Toyota Corolla Axio", BuyerName = "Ali Raza", OrderDate = DateTime.Today.AddDays(-20), Status = OrderStatus.InTransit, TotalPkr = 3200000 },
        new() { Id = 1002, VehicleId = 3, VehicleTitle = "2020 Suzuki Alto", BuyerName = "Ali Raza", OrderDate = DateTime.Today.AddDays(-5), Status = OrderStatus.Confirmed, TotalPkr = 1700000 },
        new() { Id = 1003, VehicleId = 4, VehicleTitle = "2017 Toyota Hilux", BuyerName = "Sara Khan", OrderDate = DateTime.Today.AddDays(-40), Status = OrderStatus.Delivered, TotalPkr = 6100000 }
    };

    public Task<List<Order>> GetAllAsync()
        => Task.FromResult(_orders.ToList());

    public Task<List<Order>> GetByBuyerAsync(string buyerName)
        => Task.FromResult(_orders.Where(o => o.BuyerName == buyerName).ToList());

    public Task<Order?> GetByIdAsync(int id)
        => Task.FromResult(_orders.FirstOrDefault(o => o.Id == id));

    public Task UpdateStatusAsync(int id, OrderStatus status)
    {
        var order = _orders.FirstOrDefault(o => o.Id == id);
        if (order != null) order.Status = status;
        return Task.CompletedTask;
    }
}
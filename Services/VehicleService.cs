using JPTrading.Web.Models;

namespace JPTrading.Web.Services;

public class VehicleService
{
    private readonly List<Vehicle> _vehicles = new()
    {
        new() { Id = 1, Make = "Toyota", Model = "Corolla Axio", Year = 2018, MileageKm = 54000, Transmission = "Automatic", FuelType = "Petrol", BodyType = "Sedan", Color = "White", AuctionGrade = "4", PriceJpy = 1250000 },
        new() { Id = 2, Make = "Honda", Model = "Civic", Year = 2019, MileageKm = 42000, Transmission = "Automatic", FuelType = "Petrol", BodyType = "Sedan", Color = "Black", AuctionGrade = "4.5", PriceJpy = 1800000 },
        new() { Id = 3, Make = "Suzuki", Model = "Alto", Year = 2020, MileageKm = 30000, Transmission = "Automatic", FuelType = "Petrol", BodyType = "Hatchback", Color = "Silver", AuctionGrade = "4", PriceJpy = 650000 },
        new() { Id = 4, Make = "Toyota", Model = "Hilux", Year = 2017, MileageKm = 78000, Transmission = "Manual", FuelType = "Diesel", BodyType = "Truck", Color = "White", AuctionGrade = "3.5", PriceJpy = 2400000 },
        new() { Id = 5, Make = "Nissan", Model = "Note", Year = 2018, MileageKm = 61000, Transmission = "Automatic", FuelType = "Hybrid", BodyType = "Hatchback", Color = "Blue", AuctionGrade = "4", PriceJpy = 980000 },
        new() { Id = 6, Make = "Mitsubishi", Model = "Canter", Year = 2016, MileageKm = 120000, Transmission = "Manual", FuelType = "Diesel", BodyType = "Truck", Color = "White", AuctionGrade = "3", PriceJpy = 2100000, Status = "Reserved" }
    };

    public Task<List<Vehicle>> GetAllAsync()
        => Task.FromResult(_vehicles.ToList());

    public Task<Vehicle?> GetByIdAsync(int id)
        => Task.FromResult(_vehicles.FirstOrDefault(v => v.Id == id));

    public Task<List<Vehicle>> SearchAsync(string? text, string? make, decimal? maxPriceJpy)
    {
        var query = _vehicles.AsEnumerable();

        if (!string.IsNullOrWhiteSpace(text))
            query = query.Where(v => v.Title.Contains(text, StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrWhiteSpace(make))
            query = query.Where(v => v.Make.Equals(make, StringComparison.OrdinalIgnoreCase));

        if (maxPriceJpy.HasValue)
            query = query.Where(v => v.PriceJpy <= maxPriceJpy.Value);

        return Task.FromResult(query.ToList());
    }
}
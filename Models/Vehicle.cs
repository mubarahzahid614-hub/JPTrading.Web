namespace JPTrading.Web.Models;

public class Vehicle
{
    public int Id { get; set; }
    public string Make { get; set; } = "";
    public string Model { get; set; } = "";
    public int Year { get; set; }
    public int MileageKm { get; set; }
    public string Transmission { get; set; } = "";
    public string FuelType { get; set; } = "";
    public string BodyType { get; set; } = "";
    public string Color { get; set; } = "";
    public string AuctionGrade { get; set; } = "";
    public decimal PriceJpy { get; set; }
    public string ImageUrl { get; set; } = "";
    public string Status { get; set; } = "Available";

    public string Title => $"{Year} {Make} {Model}";
}
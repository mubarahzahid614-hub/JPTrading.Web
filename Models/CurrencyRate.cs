namespace JPTrading.Web.Models;

public class CurrencyRate
{
    public string From { get; set; } = "JPY";
    public string To { get; set; } = "PKR";
    public decimal Rate { get; set; }
    public DateTime UpdatedAt { get; set; }
}
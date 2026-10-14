using JPTrading.Web.Models;

namespace JPTrading.Web.Services;

public class CurrencyService
{
    // Dummy rate. Real rate backend ke currency converter API se aayega.
    private readonly CurrencyRate _rate = new()
    {
        From = "JPY",
        To = "PKR",
        Rate = 1.85m,
        UpdatedAt = DateTime.Now
    };

    public Task<CurrencyRate> GetRateAsync()
        => Task.FromResult(_rate);

    public decimal Convert(decimal amountJpy, decimal rate)
        => Math.Round(amountJpy * rate, 0);
}
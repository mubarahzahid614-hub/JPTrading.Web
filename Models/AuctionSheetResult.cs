namespace JPTrading.Web.Models;

public class AuctionSheetResult
{
    public string FileName { get; set; } = "";
    public string OriginalText { get; set; } = "";
    public string TranslatedText { get; set; } = "";
    public string OverallGrade { get; set; } = "";
    public string InteriorGrade { get; set; } = "";
    public string ExteriorGrade { get; set; } = "";
    public int MileageKm { get; set; }
    public List<string> Notes { get; set; } = new();
}
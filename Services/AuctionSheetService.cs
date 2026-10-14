using JPTrading.Web.Models;

namespace JPTrading.Web.Services;

public class AuctionSheetService
{
    // Abhi dummy result. Baad me OCR engine ki API yahan call hogi.
    public async Task<AuctionSheetResult> TranslateAsync(string fileName)
    {
        await Task.Delay(1500); // processing ka simulation

        return new AuctionSheetResult
        {
            FileName = fileName,
            OriginalText = "評価点: 4  内装: B  外装: B  走行: 54000km",
            TranslatedText = "Overall grade: 4, Interior: B, Exterior: B, Mileage: 54,000 km",
            OverallGrade = "4",
            InteriorGrade = "B",
            ExteriorGrade = "B",
            MileageKm = 54000,
            Notes = new List<string>
            {
                "Small scratch on rear bumper",
                "Minor dent on left door"
            }
        };
    }
}
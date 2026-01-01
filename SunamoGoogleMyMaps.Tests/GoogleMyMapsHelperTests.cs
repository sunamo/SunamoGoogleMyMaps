namespace SunamoGoogleMyMaps.Tests;
using TextCopy;

/// <summary>
/// EN: Test class for GoogleMyMapsHelper functionality
/// CZ: Testovací třída pro funkcionalitu GoogleMyMapsHelper
/// </summary>
public class GoogleMyMapsHelperTests
{
    /// <summary>
    /// EN: Tests the CreateExportForGoogleMyMaps method by creating a sample dictionary and verifying the output is copied to clipboard
    /// CZ: Testuje metodu CreateExportForGoogleMyMaps vytvořením ukázkového slovníku a ověřením že výstup je zkopírován do schránky
    /// </summary>
    [Fact]
    public void CreateExportForGoogleMyMapsTest()
    {
        Dictionary<string, string> testData = new()
        {
            { "A", "B" },
            { "C", "D" }
        };

        var result = GoogleMyMapsHelper.CreateExportForGoogleMyMaps(testData);
        ClipboardService.SetText(result);
    }
}

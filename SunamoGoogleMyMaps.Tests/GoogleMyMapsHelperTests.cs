// variables names: ok
namespace SunamoGoogleMyMaps.Tests;
using TextCopy;

/// <summary>
/// Test class for GoogleMyMapsHelper functionality
/// </summary>
public class GoogleMyMapsHelperTests
{
    /// <summary>
    /// Tests the CreateExportForGoogleMyMaps method by creating a sample dictionary and verifying the output is copied to clipboard
    /// </summary>
    [Fact]
    public void CreateExportForGoogleMyMapsTest()
    {
        Dictionary<string, string> testDictionary = new()
        {
            { "A", "B" },
            { "C", "D" }
        };

        var result = GoogleMyMapsHelper.CreateExportForGoogleMyMaps(testDictionary);
        ClipboardService.SetText(result);
    }
}

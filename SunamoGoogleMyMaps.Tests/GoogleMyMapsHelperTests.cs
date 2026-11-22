namespace SunamoGoogleMyMaps.Tests;

/// <summary>
/// Test class for GoogleMyMapsHelper functionality
/// </summary>
public class GoogleMyMapsHelperTests
{
    /// <summary>
    /// The dictionary overload writes one tab separated row per entry and no header.
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

        Assert.Equal("A\tB" + Environment.NewLine + "C\tD" + Environment.NewLine, result);
    }

    /// <summary>
    /// The pair overload accepts two records with the same name and can write the header row.
    /// </summary>
    [Fact]
    public void CreateExportForGoogleMyMaps_PairsWithSameKeyAndHeader()
    {
        var pairs = new List<KeyValuePair<string, string>>
        {
            new("Seller", "Street 1, Prague"),
            new("Seller", "Street 2, Brno")
        };

        var result = GoogleMyMapsHelper.CreateExportForGoogleMyMaps(pairs, true);

        Assert.Equal("Name\tAddress" + Environment.NewLine + "Seller\tStreet 1, Prague" + Environment.NewLine + "Seller\tStreet 2, Brno" + Environment.NewLine, result);
    }

    /// <summary>
    /// The record overload gives the same rows as the pair overload.
    /// </summary>
    [Fact]
    public void CreateExportForGoogleMyMaps_Records()
    {
        var records = new List<SunamoGoogleMyMaps.Data.ABSGoogleMyMaps> { new("A", "B"), new("A", "C") };

        var result = GoogleMyMapsHelper.CreateExportForGoogleMyMaps(records);

        Assert.Equal("A\tB" + Environment.NewLine + "A\tC" + Environment.NewLine, result);
    }
}

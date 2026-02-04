namespace SunamoGoogleMyMaps;

/// <summary>
/// Helper class for creating exports compatible with Google My Maps import format
/// </summary>
public class GoogleMyMapsHelper
{
    /// <summary>
    /// Creates a tab-delimited export string from a dictionary of key-value pairs for Google My Maps import.
    /// The first element represents the header (typically "Name" and "Address").
    /// </summary>
    /// <param name="dictionary">Dictionary containing key-value pairs where key is the name and value is the address or description</param>
    /// <returns>Tab-delimited string suitable for Google My Maps import</returns>
    public static string CreateExportForGoogleMyMaps(Dictionary<string, string> dictionary)
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var entry in dictionary)
        {
            stringBuilder.AppendLine(entry.Key + "\t" + entry.Value);
        }
        return stringBuilder.ToString();
    }

    /// <summary>
    /// Creates a Google My Maps compatible string from address row data. This method will be implemented in future versions.
    /// </summary>
    /// <param name="city">The city name</param>
    /// <param name="addressData">Clipboard content containing address data</param>
    /// <param name="isAllowingEmptyCity">Whether to allow empty city values</param>
    /// <returns>Formatted string for Google My Maps</returns>
    /// <exception cref="NotImplementedException">This method is not yet implemented</exception>
    public static string CreateForGoogleMyMapsFromAddressRow(string city, string addressData, bool isAllowingEmptyCity)
    {
        throw new NotImplementedException();
    }
}
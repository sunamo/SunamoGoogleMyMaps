namespace SunamoGoogleMyMaps;

/// <summary>
/// Represents the google my maps helper type.
/// </summary>
public class GoogleMyMapsHelper
{
    /// <summary>
    /// Create export for google my maps.
    /// </summary>
    /// <param name="dictionary">The dictionary.</param>
    /// <returns>The create export for google my maps result.</returns>
    public static string CreateExportForGoogleMyMaps(Dictionary<string, string> dictionary)
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var entry in dictionary)
        {
            stringBuilder.AppendLine($"{entry.Key}\t{entry.Value}");
        }
        return stringBuilder.ToString();
    }

    /// <summary>
    /// Create for google my maps from address row.
    /// </summary>
    /// <param name="city">The city.</param>
    /// <param name="addressData">The address data.</param>
    /// <param name="isAllowingEmptyCity">The is allowing empty city.</param>
    /// <returns>The create for google my maps from address row result.</returns>
    public static string CreateForGoogleMyMapsFromAddressRow(string city, string addressData, bool isAllowingEmptyCity)
    {
        throw new NotImplementedException();
    }
}

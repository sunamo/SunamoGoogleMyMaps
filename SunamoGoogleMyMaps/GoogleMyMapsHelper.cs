namespace SunamoGoogleMyMaps;

/// <summary>
/// Represents the google my maps helper type.
/// </summary>
public class GoogleMyMapsHelper
{
    /// <summary>
    /// The header row that Google My Maps expects in an imported table.
    /// </summary>
    public const string Header = "Name\tAddress";

    /// <summary>
    /// Create export for google my maps.
    /// </summary>
    /// <param name="dictionary">The dictionary.</param>
    /// <returns>The create export for google my maps result.</returns>
    public static string CreateExportForGoogleMyMaps(Dictionary<string, string> dictionary)
    {
        return CreateExportForGoogleMyMaps(dictionary, false);
    }

    /// <summary>
    /// Creates the tab separated export from name and address pairs; the same name may repeat, and the header row "Name, Address" is optional.
    /// </summary>
    /// <param name="pairs">The pairs of name (key) and address (value), in the order they are written.</param>
    /// <param name="isAddingHeader">Whether the first row is the header.</param>
    /// <returns>One row per pair, each ended with a new line.</returns>
    public static string CreateExportForGoogleMyMaps(IEnumerable<KeyValuePair<string, string>> pairs, bool isAddingHeader = false)
    {
        if (pairs == null) throw new ArgumentNullException(nameof(pairs));
        StringBuilder stringBuilder = new StringBuilder();
        if (isAddingHeader)
        {
            stringBuilder.AppendLine(Header);
        }

        foreach (var entry in pairs)
        {
            stringBuilder.AppendLine($"{entry.Key}\t{entry.Value}");
        }
        return stringBuilder.ToString();
    }

    /// <summary>
    /// Creates the tab separated export from name and address records; the same name may repeat, and the header row "Name, Address" is optional.
    /// </summary>
    /// <param name="records">The records with the name in Key and the address in Value.</param>
    /// <param name="isAddingHeader">Whether the first row is the header.</param>
    /// <returns>One row per record, each ended with a new line.</returns>
    public static string CreateExportForGoogleMyMaps(IEnumerable<ABSGoogleMyMaps> records, bool isAddingHeader = false)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));
        return CreateExportForGoogleMyMaps(records.Select(record => new KeyValuePair<string, string>(record.Key, record.Value)), isAddingHeader);
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

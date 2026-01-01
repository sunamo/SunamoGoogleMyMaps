namespace SunamoGoogleMyMaps;

/// <summary>
/// EN: Helper class for creating exports compatible with Google My Maps import format
/// CZ: Pomocná třída pro vytváření exportů kompatibilních s formátem Google My Maps importu
/// </summary>
public class GoogleMyMapsHelper
{
    /// <summary>
    /// EN: Creates a tab-delimited export string from a dictionary of key-value pairs for Google My Maps import.
    ///     The first element represents the header (typically "Name" and "Address").
    /// CZ: Vytvoří tabulátorem oddělený exportní řetězec ze slovníku klíč-hodnota párů pro import do Google My Maps.
    ///     První prvek představuje záhlaví (typicky "Name" a "Address").
    /// </summary>
    /// <param name="data">Dictionary containing key-value pairs where key is the name and value is the address or description</param>
    /// <returns>Tab-delimited string suitable for Google My Maps import</returns>
    public static string CreateExportForGoogleMyMaps(Dictionary<string, string> data)
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var entry in data)
        {
            stringBuilder.AppendLine(entry.Key + "\t" + entry.Value);
        }
        return stringBuilder.ToString();
    }

    /// <summary>
    /// EN: Creates a Google My Maps compatible string from address row data. This method will be implemented in future versions.
    /// CZ: Vytvoří řetězec kompatibilní s Google My Maps z dat řádku adresy. Tato metoda bude implementována v budoucích verzích.
    /// </summary>
    /// <param name="city">The city name</param>
    /// <param name="clipboard">Clipboard content containing address data</param>
    /// <param name="isAllowingEmptyCity">Whether to allow empty city values</param>
    /// <returns>Formatted string for Google My Maps</returns>
    /// <exception cref="NotImplementedException">This method is not yet implemented</exception>
    public static string CreateForGoogleMyMapsFromAddressRow(string city, string clipboard, bool isAllowingEmptyCity)
    {
        throw new NotImplementedException();
    }
}

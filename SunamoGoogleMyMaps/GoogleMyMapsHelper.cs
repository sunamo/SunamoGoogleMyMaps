// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy

namespace SunamoGoogleMyMaps;

public class GoogleMyMapsHelper
{
    /// <summary>
    /// In first element is header
    /// It can be Name, Address
    /// </summary>
    /// <param name="rows"></param>
    /// <returns></returns>
    public static string CreateExportForGoogleMyMaps(Dictionary<string, string> rows)
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var item in rows)
        {
            stringBuilder.AppendLine(item.Key + "\t" + item.Value);
        }
        return stringBuilder.ToString();
    }
    /// <summary>
    /// Will be implemented
    /// </summary>
    /// <param name="city"></param>
    /// <param name="clipboard"></param>
    /// <param name="allowEmptyCity"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static string CreateForGoogleMyMapsFromAddressRow(string city, string clipboard, bool allowEmptyCity)
    {
        throw new NotImplementedException();
    }
}

namespace SunamoGoogleMyMaps;
using SunamoGoogleMyMaps.Data;
using System.Text;

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
        StringBuilder sb = new StringBuilder();
        foreach (var item in rows)
        {
            sb.AppendLine(item.Key + "\t" + item.Value);
        }

        return sb.ToString();
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
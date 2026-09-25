namespace SunamoGoogleMyMaps;

public class GoogleMyMapsHelper
{
    public static string CreateExportForGoogleMyMaps(Dictionary<string, string> dictionary)
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var entry in dictionary)
        {
            stringBuilder.AppendLine($"{entry.Key}\t{entry.Value}");
        }
        return stringBuilder.ToString();
    }

    public static string CreateForGoogleMyMapsFromAddressRow(string city, string addressData, bool isAllowingEmptyCity)
    {
        throw new NotImplementedException();
    }
}

namespace SunamoGoogleMyMaps.Data;

/// <summary>
///     Implicitly are strings.Empty to avoid cheching data class for null
/// </summary>
public class ABSGoogleMyMaps : ABTGoogleMyMaps<string, string>
{
    public ABSGoogleMyMaps()
    {
        A = B = string.Empty;
    }

    public ABSGoogleMyMaps(string a, string b)
    {
        A = a;
        B = b;
    }
}
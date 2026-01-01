namespace SunamoGoogleMyMaps.Data;

/// <summary>
/// EN: Specialized Google My Maps class with string values. Implicitly initialized to string.Empty to avoid checking data class for null
/// CZ: Specializovaná Google My Maps třída s textovými hodnotami. Implicitně inicializována na string.Empty aby se předešlo kontrole dat třídy na null
/// </summary>
public class ABSGoogleMyMaps : ABTGoogleMyMaps<string, string>
{
    /// <summary>
    /// EN: Default constructor initializing both values to empty strings
    /// CZ: Výchozí konstruktor inicializující obě hodnoty na prázdné řetězce
    /// </summary>
    public ABSGoogleMyMaps() : base(string.Empty, string.Empty)
    {
        A = B = string.Empty;
    }

    /// <summary>
    /// EN: Constructor with specific key and value
    /// CZ: Konstruktor s konkrétním klíčem a hodnotou
    /// </summary>
    /// <param name="key">The first value (typically name)</param>
    /// <param name="value">The second value (typically address)</param>
    public ABSGoogleMyMaps(string key, string value) : base(key, value)
    {
    }
}

namespace SunamoGoogleMyMaps.Data;

/// <summary>
/// Specialized Google My Maps class with string values. Implicitly initialized to string.Empty to avoid checking data class for null
/// </summary>
public class ABSGoogleMyMaps : ABTGoogleMyMaps<string, string>
{
    /// <summary>
    /// Default constructor initializing both values to empty strings
    /// </summary>
    public ABSGoogleMyMaps() : base(string.Empty, string.Empty)
    {
        Key = Value = string.Empty;
    }

    /// <summary>
    /// Constructor with specific key and value
    /// </summary>
    /// <param name="key">The first value (typically name)</param>
    /// <param name="value">The second value (typically address)</param>
    public ABSGoogleMyMaps(string key, string value) : base(key, value)
    {
    }
}
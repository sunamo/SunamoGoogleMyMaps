namespace SunamoGoogleMyMaps.Data;

/// <summary>
/// Represents the ABS google my maps type.
/// </summary>
public class ABSGoogleMyMaps : ABTGoogleMyMaps<string, string>
{
    /// <summary>
    /// Initializes a new instance of the ABS google my maps class.
    /// </summary>
    public ABSGoogleMyMaps() : base(string.Empty, string.Empty)
    {
        Key = Value = string.Empty;
    }

    /// <summary>
    /// Initializes a new instance of the ABS google my maps class.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    public ABSGoogleMyMaps(string key, string value) : base(key, value)
    {
    }
}

namespace SunamoGoogleMyMaps.Data;

/// <summary>
/// Generic base class for Google My Maps data with two values
/// </summary>
/// <typeparam name="TKey">The type of the first value</typeparam>
/// <typeparam name="TValue">The type of the second value</typeparam>
public class ABTGoogleMyMaps<TKey, TValue>(TKey key, TValue value)
{
    /// <summary>
    /// First value (typically used as key or name)
    /// </summary>
    public TKey Key { get; set; } = key;

    /// <summary>
    /// Second value (typically used as value or address)
    /// </summary>
    public TValue Value { get; set; } = value;
}
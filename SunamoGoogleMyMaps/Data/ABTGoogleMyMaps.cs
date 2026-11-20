namespace SunamoGoogleMyMaps.Data;

/// <summary>
/// ABT google my maps.
/// </summary>
/// <param name="key">The key.</param>
/// <param name="value">The value.</param>
/// <returns>The ABT google my maps result.</returns>
public class ABTGoogleMyMaps<TKey, TValue>(TKey key, TValue value)
{
    /// <summary>
    /// Gets or sets the key.
    /// </summary>
    public TKey Key { get; set; } = key;

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public TValue Value { get; set; } = value;
}

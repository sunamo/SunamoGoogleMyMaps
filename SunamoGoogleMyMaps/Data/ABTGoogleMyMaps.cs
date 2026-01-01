namespace SunamoGoogleMyMaps.Data;

/// <summary>
/// EN: Generic base class for Google My Maps data with two values
/// CZ: Generická základní třída pro Google My Maps data se dvěma hodnotami
/// </summary>
/// <typeparam name="TKey">The type of the first value</typeparam>
/// <typeparam name="TValue">The type of the second value</typeparam>
public class ABTGoogleMyMaps<TKey, TValue>(TKey key, TValue value)
{
    /// <summary>
    /// EN: First value (typically used as key or name)
    /// CZ: První hodnota (typicky použita jako klíč nebo název)
    /// </summary>
    public TKey A = key;

    /// <summary>
    /// EN: Second value (typically used as value or address)
    /// CZ: Druhá hodnota (typicky použita jako hodnota nebo adresa)
    /// </summary>
    public TValue B = value;
}

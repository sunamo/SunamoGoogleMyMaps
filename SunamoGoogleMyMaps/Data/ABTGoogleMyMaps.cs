namespace SunamoGoogleMyMaps.Data;

public class ABTGoogleMyMaps<TKey, TValue>(TKey key, TValue value)
{
    public TKey Key { get; set; } = key;

    public TValue Value { get; set; } = value;
}

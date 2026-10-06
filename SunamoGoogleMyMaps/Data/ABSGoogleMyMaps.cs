namespace SunamoGoogleMyMaps.Data;

public class ABSGoogleMyMaps : ABTGoogleMyMaps<string, string>
{
    public ABSGoogleMyMaps() : base(string.Empty, string.Empty)
    {
        Key = Value = string.Empty;
    }

    public ABSGoogleMyMaps(string key, string value) : base(key, value)
    {
    }
}

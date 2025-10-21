// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
﻿namespace SunamoGoogleMyMaps.Data;

/// <summary>
///     Implicitly are strings.Empty to avoid cheching data class for null
/// </summary>
public class ABSGoogleMyMaps : ABTGoogleMyMaps<string, string>
{
    public ABSGoogleMyMaps() : base(string.Empty, string.Empty)
    {
        A = B = string.Empty;
    }

    public ABSGoogleMyMaps(string a, string b) : base(a, b)
    {
    }
}
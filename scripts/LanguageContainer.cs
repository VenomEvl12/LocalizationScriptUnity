using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LanguageContainer
{

    public string language { get; set; }
    public Dictionary<string, string>[] texts { get; set; }

    public LanguageContainer(int totalLanguage)
    {
        texts = new Dictionary<string, string>[totalLanguage];
    }

    public string GetText(string key, int language)
    {
        string value;
        texts[language].TryGetValue(key, out value);
        return value;
    }

}

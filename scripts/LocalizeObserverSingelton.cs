using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.Linq;
using TMPro;

public class LocalizeObserverSingelton : MonoBehaviour
{
    public static LocalizeObserverSingelton instance;
    public int language = 0;
    private int totalLanguage = 0;
    [SerializeField]
    private List<Component> components;
    public TextAsset[] jsonFiles;

    private LanguageContainer languageContainer;

    private void Awake()
    {
        if (instance) return;

        instance = this;

        if(!jsonFiles[0]) return;

        languageContainer = new LanguageContainer(jsonFiles.Length);
        totalLanguage = jsonFiles.Length;

        int i = 0;
        foreach(TextAsset jsonFile in jsonFiles)
        {
            var dictionary = JsonConvert.DeserializeObject<List<KeyValuePair<string, string>>>(jsonFile.ToString()).ToDictionary(x => x.Key, y => y.Value);
            languageContainer.texts[i] = dictionary;
            i++;
        }
    }

   public void AddComponent(Component component)
    {
        components.Add(component);
    }

    public string GetString(string key)
    {
        return languageContainer.GetText(key, language);
    }

    public void Trigger()
    {
        if (language < totalLanguage - 1) language++;
        else language = 0;
        foreach(Component component in components)
        {
            var text = component.GetComponentInChildren<TextMesh>();
            if (text)
            {
                text.text = languageContainer.GetText(component.GetComponent<LocalizeObservable>().key.ToLower(), language);
                continue;
            }
            var textPro = component.GetComponentInChildren<TextMeshProUGUI>();
            if (textPro)
            {
                textPro.text = languageContainer.GetText(component.GetComponent<LocalizeObservable>().key.ToLower(), language);
                continue;
            }
        }
    }

}

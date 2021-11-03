using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LocalizeObservable : MonoBehaviour
{

    public string key;

    private void Start()
    {
        SetTextDefault();
        LocalizeObserverSingelton.instance.AddComponent(this);
    }

    private void SetTextDefault()
    {
        var component = GetComponent<TextMesh>();
        if (component)
        {
            component.text = LocalizeObserverSingelton.instance.GetString(key);
            return;
        }
        component = GetComponentInChildren<TextMesh>();
        if (component)
        {
            component.text = LocalizeObserverSingelton.instance.GetString(key);
            return;
        }
        var componentPro = GetComponent<TextMeshProUGUI>();
        if (componentPro)
        {
            componentPro.text = LocalizeObserverSingelton.instance.GetString(key);
            return;
        }
        componentPro = GetComponentInChildren<TextMeshProUGUI>();
        if (componentPro)
        {
            componentPro.text = LocalizeObserverSingelton.instance.GetString(key);
            return;
        }
    }
}

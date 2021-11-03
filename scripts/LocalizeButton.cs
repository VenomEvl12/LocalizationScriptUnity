using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.Events;
using UnityEngine.Events;

public class LocalizeButton : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(ChangeLanguage);
    }

    public void ChangeLanguage()
    {
        LocalizeObserverSingelton.instance.Trigger();
    }
}

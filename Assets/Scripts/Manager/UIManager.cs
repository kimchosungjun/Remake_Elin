using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager 
{
    public GameObject UIObject { get; private set; }
    public FadeEffectUI Fade { get; private set; }
    public void Init()
    {
        UIObject = GameObject.FindGameObjectWithTag("UI");
        if (UIObject != null)
        {
            Fade = UIObject.GetComponentInChildren<FadeEffectUI>();
        }
    }
}

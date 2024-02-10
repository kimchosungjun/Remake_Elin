using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUI : MonoBehaviour
{
    [SerializeField] private GameObject InfoUIObject;
    public bool IsOn { get; set; } = false;
    public Image image;

    public void EnableUI(string _imageName)
    {
        //image.sprite = 
        IsOn = true;
        Time.timeScale = 0f;
        InfoUIObject.SetActive(true);
    }

    public void DisableUI()
    {
        IsOn = false;
        Time.timeScale = 1f;
        InfoUIObject.SetActive(false);
    }
}

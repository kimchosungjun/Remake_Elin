using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUI : MonoBehaviour
{
    [SerializeField] private GameObject InfoUIObject;
    public Image image;

    public void EnableUI(string _imageName)
    {
        //image.sprite = 
        Time.timeScale = 0f;
        InfoUIObject.SetActive(true);
    }

    public void DisableUI()
    {
        Time.timeScale = 1f;
        InfoUIObject.SetActive(false);
    }
}

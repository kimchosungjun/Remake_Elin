using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoUITriggerBox : MonoBehaviour
{
    private string _infoName = "";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")){
            GameManager.UIM.Info.EnableUI(_infoName);
            Destroy(this.gameObject);
        }
    }
}

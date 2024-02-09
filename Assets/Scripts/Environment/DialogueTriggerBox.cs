using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerBox : MonoBehaviour
{
    public string loadDialogueName = "ElinMonologue0";
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.DialogueM.StartConversation(loadDialogueName);
            //this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private bool triggerPlayer = false;
    public GameObject infoBox;
    public SceneNames connectSceneName = SceneNames.Forest;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            triggerPlayer = true;
            infoBox.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            triggerPlayer = false;
            infoBox.SetActive(false);
        } 
    }

    private void Update()
    {
        if(triggerPlayer && Input.GetKeyDown(KeyCode.UpArrow))
            GameManager.SceneM.LoadScene(connectSceneName);
    }
}

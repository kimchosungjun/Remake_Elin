using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEndTriggerBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.CameraM.IsFollowPlayer(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.CameraM.IsFollowPlayer(true);
        }
    }
}

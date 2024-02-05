using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Component
    Rigidbody2D rb;
    SpriteRenderer spr;
    #endregion

    #region Variable
    public float speed;
    #endregion
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) { spr.flipX = false; rb.velocity = new Vector2(speed, rb.velocity.y); }
        else if (Input.GetKey(KeyCode.LeftArrow)) { spr.flipX = true; rb.velocity = new Vector2(-1 * speed, rb.velocity.y); }
    }
}

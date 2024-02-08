using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager
{
    private GameObject elin;
    public GameObject Elin { get
        {
            if (elin == null)
            {
                GameObject go = GameObject.FindGameObjectWithTag("Player");
                elin = go;
                if (go == null)
                    return null;
                else
                    return elin;
            }
            else
            {
                return elin;
            }
        }
        set
        {
            elin = value ;       
        } 
    } 
    public PlayerController Controller{ get; private set; }

    public void Init()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        elin = go;
        if(elin!=null)
            Controller = go.GetComponent<PlayerController>();
    }

    public void ControllPlayer(bool _canMove) { if (Controller == null) return;  Controller.CanMove = _canMove; }
  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public abstract class BaseScene : MonoBehaviour
{
    private void Start()
    {
        Init();        
    }

    public virtual void Init()
    {
        Object obj = GameObject.FindObjectOfType(typeof(EventSystem));
        //if (obj == null)
        //    MasterManager.Resource.Instantiate("UI/EventSystem");
    }
    public virtual void ExitGame() { Application.Quit(); }
    public abstract void Clear();
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //GameManager
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }
    //SceneManager
    private SceneLoadManager sceneM = new SceneLoadManager();
    public static SceneLoadManager SceneM { get { return instance.sceneM; } }
    //PlayerManager
    private PlayerManager playerM = new PlayerManager();
    public static PlayerManager PlayerM { get { return instance.playerM; } }
    //EventManager
    private EventManager eventM = new EventManager();
    public static EventManager EventM { get { return instance.eventM; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this.gameObject.GetComponent<GameManager>();
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Update()
    {
        //Scene.Update();
    }

    public void Init()
    {
        
    }

    public void Clear()
    {

    }
}

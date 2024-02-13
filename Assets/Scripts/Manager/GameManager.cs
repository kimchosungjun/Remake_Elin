using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region CoreManager
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
    //DialogueManager
    private DialogueManager dialogueM = new DialogueManager();
    public static DialogueManager DialogueM { get { return instance.dialogueM; } }
    //UIManager
    private UIManager uiM = new UIManager(); 
    public static UIManager UIM { get { return instance.uiM; } }
    //CameraManager
    private CameraManager cameraM = new CameraManager();
    public static CameraManager CameraM { get { return instance.cameraM; } }
    #endregion

    private void Awake()
    {
        if (instance == null)
        {
            instance = this.gameObject.GetComponent<GameManager>();
            DontDestroyOnLoad(this.gameObject);
        }
        //ManagersInit();
    }

    private void Update()
    {
        //Scene.Update();
    }

    public void ManagersInit()
    {
        PlayerM.Init();
        DialogueM.Init();
        UIM.Init();
        CameraM.Init();
    }

    public void Clear()
    {

    }
}

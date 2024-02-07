using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TitleScene : BaseScene
{
    private void Start()
    {
        Init();
        int width = 1920;
        int height = 1080;
        Screen.SetResolution(width, height, true);
    }

    public override void Init()
    {
        base.Init();
        CurrentSceneName = SceneNames.Title;
    }

    public override void Clear()
    {
        
    }

    public void EnterGame()
    {
        GameManager.SceneM.LoadScene(CurrentSceneName + 1);
    }
}

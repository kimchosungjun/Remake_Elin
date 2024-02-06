using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TitleScene : BaseScene
{
    public SceneNames CurrentSceneName { get; set; } = SceneNames.Title;
    private void Start()
    {
        Init();
    }

    public override void Clear()
    {
        
    }

    public void EnterGame()
    {
        GameManager.SceneM.LoadScene(CurrentSceneName + 1);
    }
}

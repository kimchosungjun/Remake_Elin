using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScene : BaseScene
{
    private string tutorialHumanDialogue = "TutorialHuman1";
    private void Start()
    {
        GameManager.Instance.ManagersInit();
        Init();
    }

    public override void Init()
    {
        base.Init();
        CurrentSceneName = SceneNames.Tutorial;
    }

    public override void Clear()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            GameManager.DialogueM.StartConversation(tutorialHumanDialogue);
    }
}

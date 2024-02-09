using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScene : BaseScene
{
    private string tutorialHumanDialogue = "TutorialHuman";
    private void Start()
    {
        GameManager.Instance.ManagersInit();
        Init();
    }

    public override void Init()
    {
        base.Init();
        CurrentSceneName = SceneNames.Tutorial;
        GameManager.DialogueM.StartConversation(tutorialHumanDialogue);
    }

    public override void Clear()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn;
using Yarn.Unity;

public class DialogueManager 
{
    public DialogueRunner runner;
    public void Init()
    {
        runner = GameObject.FindWithTag("Runner").GetComponent<DialogueRunner>();
        runner.onDialogueComplete.AddListener(() => { GameManager.PlayerM.ControllPlayer(true); });
    }

    public void StartConversation(string _dialogueName)
    {
        if (runner.IsDialogueRunning)
            return;
        GameManager.PlayerM.ControllPlayer(false);
        runner.StartDialogue(_dialogueName);
    }

}

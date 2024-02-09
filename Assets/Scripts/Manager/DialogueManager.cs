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
        // string conversationName = string.Concat(_dialogueName, dialogueDictionary[_dialogueName]);
        // Init runner & Complete Dialogue
        runner = GameObject.FindWithTag("Runner").GetComponent<DialogueRunner>();
        runner.onDialogueComplete.AddListener(() => { GameManager.PlayerM.ControllPlayer(true); });

        // Add DialogueEvent
        runner.AddCommandHandler<bool>("IsFadeIn", IsFadeIn); 
        runner.AddCommandHandler<string>("StartConversation", StartConversation); 
    }

    public void StartConversation(string _dialogueName)
    {
        if (runner.IsDialogueRunning)
            return;
        GameManager.PlayerM.ControllPlayer(false);
        runner.StartDialogue(_dialogueName);
    }

    public void IsFadeIn(bool _isFadeIn) { GameManager.UIM.Fade.FadeEffect(_isFadeIn); }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn;
using Yarn.Unity;

public class DialogueManager 
{
    public DialogueRunner runner;
    public Dictionary<string, int> dialogueDictionary;
    public void Init()
    {
        //Save DialougeList
        dialogueDictionary = new Dictionary<string, int>();

        // Init runner & Complete Dialogue
        runner = GameObject.FindWithTag("Runner").GetComponent<DialogueRunner>();
        runner.onDialogueComplete.AddListener(() => { GameManager.PlayerM.ControllPlayer(true); });

        // Add DialogueEvent
        runner.AddCommandHandler<bool>("IsFadeIn", IsFadeIn); 
        runner.AddCommandHandler<string>("StartConversation", StartConversation); 
    }

    public void FindDialogueDictionary(string _dialogueName) 
    { 
        if (!dialogueDictionary.ContainsKey(_dialogueName)) 
            dialogueDictionary.Add(_dialogueName, 0);
    }

    public void StartConversation(string _dialogueName)
    {
        if (runner.IsDialogueRunning)
            return;
        FindDialogueDictionary(_dialogueName);
        
        GameManager.PlayerM.ControllPlayer(false);
        runner.StartDialogue(_dialogueName);
    }

    
    public void IsFadeIn(bool _isFadeIn) { GameManager.UIM.Fade.FadeEffect(_isFadeIn); }

    [YarnFunction("TT")]
    public static int Test(int num)
    {
        return num;
    }
}

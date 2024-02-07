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
        //runner.AddCommandHandler("Test",Test);
    }

    public void StartConversation(string _dialogueName)
    {
        runner.StartDialogue(_dialogueName);
    }


}

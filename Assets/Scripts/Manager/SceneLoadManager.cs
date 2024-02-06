using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneLoadManager
{
    public void LoadScene(SceneNames _sceneName)
    {
        GameManager.Instance.Clear();
        string sceneName = GetSceneName(_sceneName);
        SceneManager.LoadScene(sceneName);
    }

    string GetSceneName(SceneNames _sceneName)
    {
        string name = Enum.GetName(typeof(SceneNames), _sceneName);
        return name;
    }
}

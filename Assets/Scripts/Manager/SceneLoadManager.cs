using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneLoadManager
{
    public void LoadScene(Scene scene)
    {
        GameManager.Instance.Clear();
        string sceneName = GetSceneName(scene);
        SceneManager.LoadScene(sceneName);
    }

    string GetSceneName(Scene scene)
    {
        string name = Enum.GetName(typeof(Scene), scene);
        return name;
    }
}

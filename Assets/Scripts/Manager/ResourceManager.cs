using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager
{
    public T Load<T>(string _path) where T : Object
    {
        return Resources.Load<T>(_path);
    }
}

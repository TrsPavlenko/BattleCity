using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public static bool loaded;

    void Awake()
    {
        if (!loaded)
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);
        loaded = true;
    }
}

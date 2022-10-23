using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    public static T Instance;
    //change simple Awake ---- private void Awake()
    // to polymorf awake, if you want to use it in derived class
    //protected virtual void Awake()
    protected virtual void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this as T;
        DontDestroyOnLoad(this);
        Debug.Log("This *Awake* from base class Singleton<T>");
    }
}

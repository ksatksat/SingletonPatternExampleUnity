using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this how you can create singleton by using generic types <T>
public class GameManager : Singleton<GameManager>//: Singleton<GameManager> --- this inheritance you can add to every class that you desire to be singleton
{
    // this how you can create singleton without generic type <T>
    //public static GameManager Instance;
    //private void Awake()
    //{
    //    if (Instance != null)
    //    {
    //        Destroy(this);
    //        return;
    //    }
    //    Instance = this;
    //    DontDestroyOnLoad(this);
    //}

    //if you want to call Awake also here than use inheritance
    protected override void Awake()
    {
        base.Awake();//this important not to miss call base.Awake() before overriding it
        Debug.Log("This *Awake* called from derived class GameManager");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PersistentData : MonoBehaviour
{
    public static PersistentData sharedInstance;
    

    private void Awake()
    {
        if (sharedInstance == null) //Guarda la posicion del player de la escena anterior en la escena nueva
        {
            sharedInstance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
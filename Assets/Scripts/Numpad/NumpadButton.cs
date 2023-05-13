using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class NumpadButton : MonoBehaviour
{

    [SerializeField]
    private int Number;

    [SerializeField]
    private Numpad Numpad;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPress()
    {
        if (!Numpad.IsUnlocked())
        {
            Debug.Log("Not Unlocked");
            Numpad.AddNumberToPasscode(Number);
            string pass = Numpad.GetCurrentPasscode().text.ToString();
            if (pass.Length >= 4 && pass == Numpad.GetPassword())
            {
                Debug.Log("Unlock");
                Numpad.Unlock();
            }else if(pass.Length >= 4 && pass != Numpad.GetPassword())
            {
                Debug.Log("KeepLocked");
                Numpad.KeepLocked();
            }
            
        }
    }
}

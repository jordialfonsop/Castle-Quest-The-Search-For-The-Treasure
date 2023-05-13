using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Numpad : MonoBehaviour
{
    [SerializeField]
    private AudioSource audiosource;

    [SerializeField]
    private AudioClip unlock;

    [SerializeField]
    private AudioClip wrong;

    [SerializeField]
    private string Password = "0000";

    [SerializeField]
    GameObject door;

    [SerializeField]
    private TMP_Text CurrentPasscode;

    private bool unlocked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsUnlocked()
    {
        return unlocked;
    }

    public void SetUnlocked(bool status)
    {
        unlocked = status;

    }

    public void Unlock()
    {
        SetUnlocked(true);
        audiosource.clip = unlock;
        audiosource.Play();
        door.GetComponent<BoxCollider>().enabled = true;   
    }

    public void KeepLocked()
    {
        audiosource.clip = wrong;
        audiosource.Play();
        ResetPasscode();
    }

    public string GetPassword()
    {
        return Password;
    }

    public void AddNumberToPasscode(int number)
    {
        CurrentPasscode.text = CurrentPasscode.text + number.ToString();
    }

    public void ResetPasscode()
    {
        CurrentPasscode.text = "";
    }

    public TMP_Text GetCurrentPasscode()
    {
        return CurrentPasscode;
    }
}

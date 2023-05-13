using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Pedestal : MonoBehaviour
{
    private bool isActive = false;
    [SerializeField] private GameObject winTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetIsActive(bool state) 
    { 
    
        isActive = state;

    }

    public bool GetIsActive()
    {
        return isActive;
    }

    public void SetWinTriggerState(bool state)
    {
        winTrigger.SetActive(state);
    }


}

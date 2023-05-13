using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject tula;
    [SerializeField] private Pedestal pedestal1;
    [SerializeField] private Pedestal pedestal2;
    [SerializeField] private Pedestal pedestal3;
    [SerializeField] private Pedestal pedestal4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckStatus()
    {
        pedestal1.SetWinTriggerState(pedestal1.GetIsActive());
        pedestal2.SetWinTriggerState(pedestal2.GetIsActive());
        pedestal3.SetWinTriggerState(pedestal3.GetIsActive());
        pedestal4.SetWinTriggerState(pedestal4.GetIsActive());
        if (pedestal1.GetIsActive() && pedestal2.GetIsActive() && pedestal3.GetIsActive() && pedestal4.GetIsActive())
        {
            tula.SetActive(true);
        }
        else
        {
            tula.SetActive(false);
        }
    }
}
